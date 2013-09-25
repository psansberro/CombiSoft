using CombiSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CombiSoft.Controllers
{
    public class HomeController : Controller
    {
        private IClienteRepository _clienteRepository;


        public ActionResult Index()
        {
            return View(_clienteRepository.GetAll());

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
