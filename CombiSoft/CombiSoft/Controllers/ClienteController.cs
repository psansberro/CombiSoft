using CombiSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CombiSoft.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            return View(ClienteDb.Clientes.Values.ToList());
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cliente/Create

        [HttpPost]
        public ActionResult Create(ClienteModel clienteM)
        {
            try
            {
                if (ClienteDb.Clientes.Count == 0)
                    clienteM.Id = 1;
                else
                    clienteM.Id = ClienteDb.Clientes[ClienteDb.Clientes.Count() - 1].Id + 1;
                
                ClienteDb.Clientes.Add(clienteM.Id, clienteM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cliente/Edit/5

        public ActionResult Edit(int id)
        {
            return View(ClienteDb.Clientes[id]);
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, ClienteModel clienteM)
        {
            try
            {
                // TODO: Add update logic here
                ClienteDb.Clientes[id] = clienteM;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id)
        {
            return View(ClienteDb.Clientes[id]);
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost]
        public ActionResult Delete(ClienteModel clienteM)
        {
            try
            {
                // TODO: Add delete logic here
                ClienteDb.Clientes.Remove(clienteM.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
