﻿using Rotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> todasAsNoticias;

        public HomeController()
        {
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }

        public ActionResult Index()
        {
            var ultimasNoticias = todasAsNoticias.Take(3);
            var todasCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();
            ViewBag.Categorias = todasCategorias;

            return View(ultimasNoticias);
        }

        public ActionResult TodasNoticias()
        {
            return View(todasAsNoticias);
        }

        public ActionResult MostrarNoticia(int noticiaId, string categoria, string titulo)
        {
            return View(todasAsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
        }

        public ActionResult MostrarCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categorias = categoria;
            return View(categoriaEspecifica);
        }
    }
}