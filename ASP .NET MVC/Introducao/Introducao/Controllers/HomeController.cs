using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexNew()
        {
            return View();
        }

        public ActionResult Contatos()
        {
            var pessoa = new PessoaModels { PessoaId = 1, Nome= "José Ataides Frota Filho", Tipo="Administrador"};
            ViewData["PessoaID"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;
            ViewBag.Teste = "Nome para teste";
            return View();
        }

        public ActionResult ContatoTipado()
        {
            PessoaModels pessoa = new PessoaModels { PessoaId = 1, Nome = "José Ataides Frota Filho", Tipo = "Administrador"};
            return View(pessoa);
        }

        public ActionResult ContatoTipadoHtmlForm()
        {
            PessoaModels pessoa = new PessoaModels { PessoaId = 1, Nome = "José Ataides Frota Filho", Tipo = "Administrador" };
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult ListaContatoTipado(int PessoaId, string Nome, string Tipo)
        {
            ViewData["PessoaId"] = PessoaId;
            ViewData["Nome"] = Nome;
            ViewData["Tipo"] = Tipo;

            return View();
        }
        
        [HttpPost]
        public ActionResult ListaContatoFormColletionTipado(FormCollection form)
        {
            ViewData["PessoaId"] = form["PessoaId"];
            ViewData["Nome"] = form["Nome"];
            ViewData["Tipo"] = form["Tipo"];

            return View();
        }

        [HttpPost]
        public ActionResult ListaContatoObjeto(PessoaModels pessoa)
        {
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View();
        }

        [HttpPost]
        public ActionResult ListaContatoObjetoReturnObjeto(PessoaModels pessoa)
        {
            return View(pessoa);
        }

        //public string Index()
        //{
        //    return "José Ataides";
        //}

        public string Teste()
        {
            return "José Ataides - Teste";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}