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
        public int CityId { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        public string Nome { get; set; }

        public int DepartamentsId { get; set; }

        public virtual Departaments Departaments { get; set; }
    }
}