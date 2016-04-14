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
    public class ProductController : Controller
    {
        private ILogicLink core;

        public ProductController(ILogicLink core)
        {
            this.core = core;
        }
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = core.GetProducts();
            return View(products);
        }

        [HttpGet]
        public ActionResult Add()
        {
            Product product = new Product();
            return View(product);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                if (core.AddProduct(product))
                {
                    return Redirect("/Product/Index");
                }
            }
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product product = core.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                if (core.UpdateProduct(id, product))
                {
                    return Redirect("/Product/Index");
                }
            }
            return View(product);
        }

        
        public ActionResult Delete(int id)
        {
            if (core.DeleteProduct(id))
            {
                return Redirect("/Product/Index");
            }
            return HttpNotFound();

        }

        public ActionResult Clients(Product Product)
        {
            List<Client> clients = core.GetClientsByProduct(Product);
            return View(clients);
        }
    }
}