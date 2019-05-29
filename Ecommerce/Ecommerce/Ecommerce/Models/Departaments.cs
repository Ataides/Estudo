using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Departaments
    {
        [Key]
        [Display(Name ="Código departamento")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage ="Campo Nome é obrigatório!")]
        [Display(Name ="Nome departamento")]
        public string Nome { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}