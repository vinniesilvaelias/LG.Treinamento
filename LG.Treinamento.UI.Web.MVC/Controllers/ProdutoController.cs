using LG.Treinamento.Data;
using LG.Treinamento.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LG.Treinamento.UI.Web.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            using (var dao = new Dao<Produto>())
            {
                return View(dao.SelectAll());
            }
        }

        // GET: Produto/Details/5
        public ActionResult Details(int? id)
        {
            var produto = new Produto();
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            using (var dao = new Dao<Produto>())
            {
                produto = dao.Select(id.Value);
            }
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                using (var dao = new Dao<Produto>())
                {
                    dao.Create(produto);
                }

                return RedirectToAction("Index");
            }

            return View(produto);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var produto = new Produto();

            using (var dao = new Dao<Produto>())
            {
                produto = dao.Select(id.Value);
            }
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                using (var dao = new Dao<Produto>())
                {
                    dao.Update(produto);
                }

                return RedirectToAction("Index");
            }

            return View(produto);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int? id)
        {
            var produto = new Produto();
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            using (var dao = new Dao<Produto>())
            {
                produto = dao.Select(id.Value);
            }
            if (produto == null)
            {
                return HttpNotFound();
            }

            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(Produto produto)
        {
            using (var dao = new Dao<Produto>())
            {
                dao.Delete(produto);
            }

            return RedirectToAction("Index");

        }
    }

}
