using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SidcaMrv2.Models;
using PagedList;
using System.IO;
using ExcelDataReader;
using System.Data.OleDb;
using Microsoft.Office.Core;
using System.Data.Entity.Infrastructure;

namespace SidcaMrv2.Controllers
{
    public class ImportacaoController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: Importacao
        public ActionResult Index(int? pagina)
        {
            var lista = db.PreCadastroUniverso;
            
            int tamanhoPagina = 10;
            int numeroPagina = pagina ?? 1;
            return View(db.PreCadastroUniverso.OrderBy(e => e.Expediente).ToPagedList(numeroPagina, tamanhoPagina));
            //  return View(db.PreCadastroUniverso.ToList());
        }
        
        // GET: Importacao/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single();//.Find(id);
            if (preCadastroUniverso == null)
            {
                return HttpNotFound();
            }
            return View(preCadastroUniverso);
        }

        // GET: Importacao/Create
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                try
                {
                    string path = Path.Combine(Server.MapPath("~/Images")
                                               , Path.GetFileName(file.FileName));

                    if (!System.IO.File.Exists(path))
                    {
                        //save file                        
                        file.SaveAs(path);
                        ViewBag.Message = "File uploaded successfully";
                    }

                    Microsoft.Office.Interop.Excel.Application xlApp;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    Microsoft.Office.Interop.Excel.Range xlRange;

                    int xlRow;
                    string strfileName = path;

                    if (strfileName != string.Empty)
                    {
                        xlApp = new Microsoft.Office.Interop.Excel.Application();
                        xlWorkBook = xlApp.Workbooks.Open(strfileName);
                        xlWorkSheet = xlWorkBook.Worksheets["Entrantes"];
                        xlRange = xlWorkSheet.UsedRange;
                        int i = 0;
                        for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                        {
                            if (xlRange.Cells[xlRow, 1].Text != "")
                            {
                                i++;
                                PreCadastroUniverso PreCadUniverso = new PreCadastroUniverso() {
                                    Expediente = xlRange.Cells[xlRow, 1].Text,
                                    Processo = xlRange.Cells[xlRow, 2].Text,
                                    DtEntrada = xlRange.Cells[xlRow, 3].Text,
                                    NuVara = xlRange.Cells[xlRow, 4].Text,
                                    NoParteJudicial = xlRange.Cells[xlRow, 5].Text,
                                    CondicaoParte = xlRange.Cells[xlRow, 6].Text
                                };

                                db.PreCadastroUniverso.Add(PreCadUniverso);

                                //db.PreCadastroUniverso.Add(preCadastroUniverso);
                                db.SaveChanges();
                            }
                        }

                        xlWorkBook.Close();
                        xlApp.Quit();
                    }
                    db.SaveChanges();
                    return RedirectToAction("Index"/*, "FileUpload"*/);
                }
                catch (/*ConstraintException ExceptionContext AccessViolationException DataException DBConcurrencyException OleDbException DbEntityValidationException DbException DbUpdateConcurrencyException DbUpdateException*/ Exception ex)
                {
                    ViewBag.Message = $"Error:{ex.Message}";
                }
            }
            else
            {
                ViewBag.Message = "You have not specified a file.";
                return RedirectToAction("Index"/*, "FileUpload"*/);
            }

            //return View(preCadastroUniverso);
            return RedirectToAction("Index"/*, "FileUpload"*/);
        }


        // POST: Importacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Expediente,Processo,NoParteJudicial,CondicaoParte,DtEntrada,NuAdvogado,AreaJud,GrupoAssunto,VlrCausa,DtCausa,NuVara,NuForo,Comarca,CentroCusto,UnidSubsidio,TpAcao,IdTerceirizacao,IdRelevante,ExpVinculado,DtAcervoInfo,AcervoInfo,DtFinalizado,Finalizado")] PreCadastroUniverso preCadastroUniverso)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.PreCadastroUniverso.Add(preCadastroUniverso);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(preCadastroUniverso);
        //}

        // GET: Importacao/Edit/5
        public ActionResult Edit(string id)
        {            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id ).Single();//.Find(Id);
            if (preCadastroUniverso == null)
            {
                return HttpNotFound();
            }
            return View(preCadastroUniverso);
        }

        // POST: Importacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expediente,Processo,NoParteJudicial,CondicaoParte,DtEntrada,NuAdvogado,AreaJud,GrupoAssunto,VlrCausa,DtCausa,NuVara,NuForo,Comarca,CentroCusto,UnidSubsidio,TpAcao,IdTerceirizacao,IdRelevante,ExpVinculado,DtAcervoInfo,AcervoInfo,DtFinalizado,Finalizado")] PreCadastroUniverso preCadastroUniverso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(preCadastroUniverso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(preCadastroUniverso);
        }

        // GET: Importacao/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single();//.Find(id);
            if (preCadastroUniverso == null)
            {
                return HttpNotFound();
            }
            return View(preCadastroUniverso);
        }

        // POST: Importacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single();//.Find(id);
            db.PreCadastroUniverso.Remove(preCadastroUniverso);
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
