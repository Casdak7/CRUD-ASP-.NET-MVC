using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Teste_Pratico.Models;

namespace Teste_Pratico.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.categorias = DapperORM.ReturnList<Produto>("CategoriaAll");

            return View(DapperORM.ReturnList<Produto>("ProdutoAll"));
        }

        [HttpGet]
        public ActionResult CreateOrUpdate(int id = 0)
        {
            ViewBag.categorias = DapperORM.ReturnList<Produto>("CategoriaAll");

            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("_id", id);
                return View(DapperORM.ReturnList<Produto>("ProdutoViewById", parameters).FirstOrDefault());
            }

        }

        [HttpPost]
        public ActionResult CreateOrUpdate(Produto produto)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("_id", produto.id);
            parameters.Add("_nome", produto.nome);
            parameters.Add("_categoria_id", produto.categoria_id);
            parameters.Add("_preco", produto.preco);
            parameters.Add("_ativo", produto.ativo);
            DapperORM.ExecuteWithoutReturn("ProdutoCreateOrUpdate", parameters);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("_id", id);
            Produto produto = DapperORM.ReturnList<Produto>("ProdutoViewById", parameters).FirstOrDefault();
            parameters.Add("_nome", produto.nome);
            parameters.Add("_categoria_id", produto.categoria_id);
            parameters.Add("_preco", produto.preco);
            parameters.Add("_ativo", !produto.ativo);
            DapperORM.ExecuteWithoutReturn("ProdutoCreateOrUpdate", parameters);
            return RedirectToAction("Index");
        }
    }
}
