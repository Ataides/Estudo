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
    public class ObjetoController : Controller
    {
        private MapaDeAplicacoesContext db = new MapaDeAplicacoesContext();

        // GET: Objeto
        public ActionResult Index()
        {
            return View(db.ObjetoModels.ToList());
        }

        // GET: Objeto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObjetoModels objetoModels = db.ObjetoModels.Find(id);
            if (objetoModels == null)
            {
                return HttpNotFound();
            }
            return View(objetoModels);
        }

        // GET: Objeto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Objeto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ObjetoId,Nome,Descricao,DataCriacaoObjeto")] ObjetoModels objetoModels)
        {
            if (ModelState.IsValid)
            {
                db.ObjetoModels.Add(objetoModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objetoModels);
        }

        // GET: Objeto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObjetoModels objetoModels = db.ObjetoModels.Find(id);
            if (objetoModels == null)
            {
                return HttpNotFound();
            }
            return View(objetoModels);
        }

        // POST: Objeto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ObjetoId,Nome,Descricao,DataCriacaoObjeto")] ObjetoModels objetoModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(objetoModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(objetoModels);
        }

        // GET: Objeto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObjetoModels objetoModels = db.ObjetoModels.Find(id);
            if (objetoModels == null)
            {
                return HttpNotFound();
            }
            return View(objetoModels);
        }

        // POST: Objeto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ObjetoModels objetoModels = db.ObjetoModels.Find(id);
            db.ObjetoModels.Remove(objetoModels);
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
