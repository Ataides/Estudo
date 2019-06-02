using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [MaxLength(50,ErrorMessage ="Campo com tamanho máximo de 50 caracteres!")]
        [Display(Name ="Nome departamento")]
        [Index("Departament_Name_Index", IsUnique = true )]
        public string Nome { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public virtual ICollection<Company> Company { get; set; }
    }
}