using LG.Treinamento.Data;
using LG.Treinamento.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LG.Treinamento.UI.Web.MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            using (var dao = new Dao<Funcionario>())
            {
                return View(dao.SelectAll());
            }
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int? id)
        {
            Funcionario funcionario = new Funcionario();
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            using (var dao = new Dao<Funcionario>())
            {
                funcionario = dao.Select(id.Value);
            }
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create /*[Bind(Include = "Id,Nome,SobreNome")]*/
        [HttpPost]
        public ActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                using (var dao = new Dao<Funcionario>())
                {
                    dao.Create(funcionario);
                }

                return RedirectToAction("Index");
            }

            return View(funcionario);
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            Funcionario funcionario = new Funcionario();

            using (var dao = new Dao<Funcionario>())
            {
                funcionario = dao.Select(id.Value);
            }
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        public ActionResult Edit(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                using (var dao = new Dao<Funcionario>())
                {
                    dao.Update(funcionario);
                }

                return RedirectToAction("Index");
            }

            return View(funcionario);
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int? id)
        {
            Funcionario funcionario;
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            using (var dao = new Dao<Funcionario>())
            {
                funcionario = dao.Select(id.Value);
            }
            if (funcionario == null)
            {
                return HttpNotFound();
            }

            return View(funcionario);
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        public ActionResult Delete(Funcionario funcionario)
        {
            using (var dao = new Dao<Funcionario>())
            {
                dao.Delete(funcionario);
            }

            return RedirectToAction("Index");

        }
    }
}
