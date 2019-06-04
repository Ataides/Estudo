using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MapaDeAplicacoes.Models;

namespace MapaDeAplicacoes.Controllers
{
    public class TecnologiaController : Controller
    {
        private MapaDeAplicacoesContext db = new MapaDeAplicacoesContext();

        // GET: Tecnologia
        public ActionResult Index()
        {
            return View(db.TecnologiaModels.ToList());
        }

        // GET: Tecnologia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TecnologiaModels tecnologiaModels = db.TecnologiaModels.Find(id);
            if (tecnologiaModels == null)
            {
                return HttpNotFound();
            }
            return View(tecnologiaModels);
        }

        // GET: Tecnologia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tecnologia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TecnologiaId,Nome")] TecnologiaModels tecnologiaModels)
        {
            if (ModelState.IsValid)
            {
                db.TecnologiaModels.Add(tecnologiaModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tecnologiaModels);
        }

        // GET: Tecnologia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TecnologiaModels tecnologiaModels = db.TecnologiaModels.Find(id);
            if (tecnologiaModels == null)
            {
                return HttpNotFound();
            }
            return View(tecnologiaModels);
        }

        // POST: Tecnologia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TecnologiaId,Nome")] TecnologiaModels tecnologiaModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tecnologiaModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tecnologiaModels);
        }

        // GET: Tecnologia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TecnologiaModels tecnologiaModels = db.TecnologiaModels.Find(id);
            if (tecnologiaModels == null)
            {
                return HttpNotFound();
            }
            return View(tecnologiaModels);
        }

        // POST: Tecnologia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TecnologiaModels tecnologiaModels = db.TecnologiaModels.Find(id);
            db.TecnologiaModels.Remove(tecnologiaModels);
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
