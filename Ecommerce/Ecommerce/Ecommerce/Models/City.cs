using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class City
    {
        [Key]
        [Display(Name ="Código da cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        [Display(Name ="Nome cidade")]
        public string Nome { get; set; }

        [Range(1, double.MaxValue, ErrorMessage ="Selecione um departamento!")]
        public int DepartamentsId { get; set; }

        public virtual Departaments Departaments { get; set; }

        public virtual ICollection<Company> Company { get; set; }
    }
}