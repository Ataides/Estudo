using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Company
    {
        [Key]        
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        [MaxLength(50, ErrorMessage = "Campo com tamanho máximo de 50 caracteres!")]
        [Display(Name = "Nome departamento")]
        [Index("Company_Name_Index", IsUnique = true)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        [MaxLength(15, ErrorMessage = "Campo com tamanho máximo de 15 caracteres!")]
        [Display(Name = "Telefone")]  
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        [MaxLength(100, ErrorMessage = "Campo com tamanho máximo de 100 caracteres!")]
        [Display(Name = "Endereço")]        
        public string Address { get; set; }
                
        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Campo cidade é obrigatório!")]
        [Display(Name = "Código da cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "Campo departamento é obrigatório!")]
        [Display(Name = "Código departamento")]
        public int DepartamentsId { get; set; }

        public virtual City City { get; set; }
        public virtual Departaments Departaments { get; set; }
    }
}