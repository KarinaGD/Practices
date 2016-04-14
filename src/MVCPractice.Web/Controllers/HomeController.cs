using MVCPractice.Core.Facade;
using MVCPractice.Data.Databases;
using MVCPractice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Web.Controllers
{
    public class HomeController : Controller
    {
        private ILogicLink core;

        public HomeController(ILogicLink core)
        {
            this.core = core;
        }
        public ActionResult Index()
        {
            ViewBag.Leo = "Bienvenido!!!";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}