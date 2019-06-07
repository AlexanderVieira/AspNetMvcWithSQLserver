using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetMvcWithSQLserver;
using AspNetMvcWithSQLserver.Context;

namespace AspNetMvcWithSQLserver.Controllers
{
    public class PacientesController : Controller
    {
        private ConsultorioDbContext db = new ConsultorioDbContext();

        // GET: Pacientes
        public ActionResult Index()
        {
            return View(db.Pacientes.ToList());
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PACIENTE pACIENTE = db.Pacientes.Find(id);
            if (pACIENTE == null)
            {
                return HttpNotFound();
            }
            return View(pACIENTE);
        }

        // GET: Pacientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NOME,SEXO,EMAIL,NASCIMENTO")] PACIENTE pACIENTE)
        {
            if (ModelState.IsValid)
            {
                db.Pacientes.Add(pACIENTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pACIENTE);
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PACIENTE pACIENTE = db.Pacientes.Find(id);
            if (pACIENTE == null)
            {
                return HttpNotFound();
            }
            return View(pACIENTE);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NOME,SEXO,EMAIL,NASCIMENTO")] PACIENTE pACIENTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pACIENTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pACIENTE);
        }

        // GET: Pacientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PACIENTE pACIENTE = db.Pacientes.Find(id);
            if (pACIENTE == null)
            {
                return HttpNotFound();
            }
            return View(pACIENTE);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PACIENTE pACIENTE = db.Pacientes.Find(id);
            db.Pacientes.Remove(pACIENTE);
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
