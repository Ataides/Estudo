using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {        
        // GET: Usuario
        public ActionResult IndexUsuario()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult IndexUsuario(UsuarioModels usuario)
        {            
            return View(usuario);
        }

        [HttpPost]
        public ActionResult ResultadoUsuario(UsuarioModels usuario)
        {
            //Estou usando data anotation
            //if (string.IsNullOrEmpty(usuario.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O campo Nome é obrigatório");
            //}

            //if (usuario.Senha != usuario.ConfirmaSenha)
            //{
            //    ModelState.AddModelError("", "Confirmação de senha não confere!");
            //}

            if (ModelState.IsValid)
            {
                return View("ResultadoUsuario", usuario);
            }
            return View("IndexUsuario", usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Hugo",
                "Ataides",
                "31159",
                "6568"
            };

            return Json(bdExemplo.All(x=>x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }

    }
}