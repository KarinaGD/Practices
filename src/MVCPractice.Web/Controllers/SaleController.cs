using MVCPractice.Core.Facade;
using MVCPractice.Data.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Web.Controllers
{
    public class SaleController : Controller
    {
        ILogicLink core;

        public SaleController(ILogicLink core)
        {
            this.core = core;
        }
        // GET: Sale
        public ActionResult Index()
        {
            List<Sale> sales = core.GetSales();
            return View(sales);
        }

        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.ProductList = core.GetProducts();
            ViewBag.ClientList = core.GetClients(); 
            Sale sale = new Sale();
            return View(sale);
        }

        [HttpPost]
        public ActionResult Add(Sale sale)
        {
            if (ModelState.IsValid)
            {
                if (core.AddSale(sale))
                {
                    return Redirect("/Sale/Index");
                }
            }
            return View(sale);
        }

        public ActionResult Delete(int id)
        {
            if (core.DeleteSale(id))
            {
                return Redirect("/Sale/Index");
            }
            return HttpNotFound();

        }
    }
}