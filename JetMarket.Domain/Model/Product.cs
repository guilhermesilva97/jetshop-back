using JetMarket.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetMarket.Domain.Models
{
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(150, ErrorMessage = "Nome pode ter no máximo 150 caractéres")]
        public string Name { get; set; }

        public string Image { get; set; }

        [MaxLength(150, ErrorMessage = "Descrição pode ter no máximo 150 caractéres")]
        [Required(ErrorMessage = "Descrição é obrigatória")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Estoque é obrigatório")]
        public int Stock { get; set; }

        public bool Status { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório")]
        public decimal Price { get; set; }
    }
}
