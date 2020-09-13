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
    public class Produto
    {
        [HiddenInput]
        public int id { get; set; }

        [DisplayName("Categoria")]
        public int? categoria_id { get; set; }

        [DisplayName("Nome")]
        [Required]
        [StringLength(45)]
        public String nome { get; set; }

        [DisplayName("Preço")]
        [Required]
        [Range(0, 99999999)]
        public decimal preco { get; set; }

        [DisplayName("Ativo")]
        [DefaultValue(true)]
        public bool ativo { get; set; }

        public Categoria getCategoria()
        {
            if(this.categoria_id != 0 && this.categoria_id != null)
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("_id", this.categoria_id);
                return DapperORM.ReturnList<Categoria>("CategoriaViewById", parameters).FirstOrDefault();
            }
            else
            {
                Categoria categoria = new Categoria();
                categoria.nome = "Sem Categoria";
                return categoria;
            }
        }
    }
}
