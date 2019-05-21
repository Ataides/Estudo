using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class UsuarioModels : PessoaModels
    {
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Campo observação deve ter no mínimo 5 caracteres e no máximo 50!")]
        public string Observacoes { get; set; }
        
        [Range(18, 80, ErrorMessage = "Idade limite entre 18 à 80 anos!")]
        public int Idade { get; set; }

        [RegularExpression(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$", ErrorMessage = "E-mail inválido!")]
        [Required(ErrorMessage = "Campo e-mail é obrigatório!")]
        public string Email { get; set; }
                
        [Required(ErrorMessage = "Login é obrigatório!")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Login á existe na base de dados!")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Campo senha é obrigatório!")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "Senhas não conferem!")]
        [Required(ErrorMessage ="Campo confirmação de senha é obrigatório!")]
        public string ConfirmaSenha { get; set; }
    }
}