using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Introducao.Models
{
    public class PessoaModels
    {
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo tipo é obrigatório")]
        public string Tipo { get; set; }
    }
}