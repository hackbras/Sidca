using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SidcaMrv2.Models;

namespace SidcaMrv2.Controllers
{
    public class PlanPortalCentroCustosController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: PlanPortalCentroCustos
        public ActionResult Index()
        {
            return View(db.PlanPortalCentroCusto.ToList());
        }

        // GET: PlanPortalCentroCustos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanPortalCentroCusto planPortalCentroCusto = db.PlanPortalCentroCusto.Find(id);
            if (planPortalCentroCusto == null)
            {
                return HttpNotFound();
            }
            return View(planPortalCentroCusto);
        }

        // GET: PlanPortalCentroCustos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanPortalCentroCustos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cod,Nu_Grupo,No_Grupo,CasoUsoGrupo,Nu_Assunto,No_Assunto,CasoUsoAssunto,CCGeral,CCEspecial,UnidSubsídio,Area")] PlanPortalCentroCusto planPortalCentroCusto)
        {
            if (ModelState.IsValid)
            {
                db.PlanPortalCentroCusto.Add(planPortalCentroCusto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(planPortalCentroCusto);
        }

        // GET: PlanPortalCentroCustos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanPortalCentroCusto planPortalCentroCusto = db.PlanPortalCentroCusto.Find(id);
            if (planPortalCentroCusto == null)
            {
                return HttpNotFound();
            }
            return View(planPortalCentroCusto);
        }

        // POST: PlanPortalCentroCustos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cod,Nu_Grupo,No_Grupo,CasoUsoGrupo,Nu_Assunto,No_Assunto,CasoUsoAssunto,CCGeral,CCEspecial,UnidSubsídio,Area")] PlanPortalCentroCusto planPortalCentroCusto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planPortalCentroCusto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(planPortalCentroCusto);
        }

        // GET: PlanPortalCentroCustos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlanPortalCentroCusto planPortalCentroCusto = db.PlanPortalCentroCusto.Find(id);
            if (planPortalCentroCusto == null)
            {
                return HttpNotFound();
            }
            return View(planPortalCentroCusto);
        }

        // POST: PlanPortalCentroCustos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PlanPortalCentroCusto planPortalCentroCusto = db.PlanPortalCentroCusto.Find(id);
            db.PlanPortalCentroCusto.Remove(planPortalCentroCusto);
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
