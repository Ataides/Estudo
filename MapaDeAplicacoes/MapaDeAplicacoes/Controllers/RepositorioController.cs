using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MapaDeAplicacoes.Models;

namespace MapaDeAplicacoes.Controllers
{
    public class RepositorioController : Controller
    {
        private MapaDeAplicacoesContext db = new MapaDeAplicacoesContext();

        public DateTime DataTime { get; private set; }

        // GET: Repositorio
        public ActionResult Index()
        {
            return View(db.RepositorioModels.ToList());
        }

        // GET: Repositorio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepositorioModels repositorioModels = db.RepositorioModels.Find(id);
            if (repositorioModels == null)
            {
                return HttpNotFound();
            }
            return View(repositorioModels);
        }

        // GET: Repositorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Repositorio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RepositorioId,Nome,Descricao,DataCriacao")] RepositorioModels repositorioModels)
        {
            if (ModelState.IsValid)
            {
                //repositorioModels.DataCriacao = DateTime.Now;
                db.RepositorioModels.Add(repositorioModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(repositorioModels);
        }

        // GET: Repositorio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepositorioModels repositorioModels = db.RepositorioModels.Find(id);
            if (repositorioModels == null)
            {
                return HttpNotFound();
            }
            return View(repositorioModels);
        }

        // POST: Repositorio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RepositorioId,Nome,Descricao,DataCriacao")] RepositorioModels repositorioModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repositorioModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(repositorioModels);
        }

        // GET: Repositorio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RepositorioModels repositorioModels = db.RepositorioModels.Find(id);
            if (repositorioModels == null)
            {
                return HttpNotFound();
            }
            return View(repositorioModels);
        }

        // POST: Repositorio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RepositorioModels repositorioModels = db.RepositorioModels.Find(id);
            db.RepositorioModels.Remove(repositorioModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
