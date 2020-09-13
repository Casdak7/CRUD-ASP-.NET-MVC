using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Teste_Pratico.Models;
using Dapper;

namespace Teste_Pratico.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            
            return View(DapperORM.ReturnList<Categoria>("CategoriaAll"));
        }

        [HttpGet]
        public ActionResult CreateOrUpdate(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("_id", id);
                return View(DapperORM.ReturnList<Categoria>("CategoriaViewById", parameters).FirstOrDefault());
            }

        }

        [HttpPost]
        public ActionResult CreateOrUpdate(Categoria categoria)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("_id", categoria.id);
            parameters.Add("_nome", categoria.nome);
            DapperORM.ExecuteWithoutReturn("CategoriaCreateOrUpdate", parameters);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("_id", id);
            DapperORM.ExecuteWithoutReturn("CategoriaDeleteById", parameters);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("_id", id);
            return View(DapperORM.ReturnList<Categoria>("CategoriaViewById", parameters).FirstOrDefault());
        }

    }
}
