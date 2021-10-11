using LG.Treinamento.Data;
using LG.Treinamento.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LG.Treinamento.UI.Web.MVC.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            using (var dao = new Dao<Empresa>())
            {
                return View(dao.SelectAll());
            }
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int? id)
        {
            var empresa = new Empresa();
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            using (var dao = new Dao<Empresa>())
            {
                empresa = dao.Select(id.Value);
            }
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        public ActionResult Create(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                using (var dao = new Dao<Empresa>())
                {
                    dao.Create(empresa);
                }

                return RedirectToAction("Index");
            }

            return View(empresa);
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var empresa = new Empresa();

            using (var dao = new Dao<Empresa>())
            {
                empresa = dao.Select(id.Value);
            }
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult Edit(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                using (var dao = new Dao<Empresa>())
                {
                    dao.Update(empresa);
                }

                return RedirectToAction("Index");
            }

            return View(empresa);
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var empresa = new Empresa();

            using (var dao = new Dao<Empresa>())
            {
                empresa = dao.Select(id.Value);
            }
            if (empresa == null)
            {
                return HttpNotFound();
            }

            return View(empresa);
        }

        // POST: Empresa/Delete/5
        [HttpPost]
        public ActionResult Delete(Empresa empresa)
        {
            using (var dao = new Dao<Empresa>())
            {
                dao.Delete(empresa);
            }

            return RedirectToAction("Index");
        }
    }
}