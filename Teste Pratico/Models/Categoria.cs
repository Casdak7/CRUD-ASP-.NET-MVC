using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Pratico.Models
{
    public class Categoria
    {
        [HiddenInput]
        public int id { get; set; }

        [DisplayName("Nome")]
        [Required]
        [StringLength(45)]
        public String nome { get; set; } 

        public IEnumerable<Produto> GetProdutos()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("_id", this.id);
            return DapperORM.ReturnList<Produto>("ProdutosByCategoria", parameters);
        }
    }
}
