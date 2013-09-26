using CombiSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CombiSoft.Controllers
{
    public class ChoferController : Controller
    {
        //
        // GET: /Chofer/

        public ActionResult Index()
        {
            return View(ChoferDb.Choferes.Values.ToList());
        }

        //
        // GET: /Chofer/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Chofer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Chofer/Create

        [HttpPost]
        public ActionResult Create(ChoferModel choferM)
        {
            try
            {
                if (ChoferDb.Choferes.Count == 0)
                    choferM.Id = 1;
                else
                    choferM.Id = ChoferDb.Choferes[ChoferDb.Choferes.Count() - 1].Id + 1;

                ChoferDb.Choferes.Add(choferM.Id, choferM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Chofer/Edit/5

        public ActionResult Edit(int id)
        {
            return View(ChoferDb.Choferes[id]);
        }

        //
        // POST: /Chofer/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, ChoferModel choferM)
        {
            try
            {
                // TODO: Add update logic here
                ChoferDb.Choferes[id] = choferM;
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Chofer/Delete/5

        public ActionResult Delete(int id)
        {
            return View(ChoferDb.Choferes[id]);
        }

        //
        // POST: /Chofer/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, ChoferModel choferM)
        {
            try
            {
                // TODO: Add delete logic here
                ChoferDb.Choferes.Remove(choferM.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
