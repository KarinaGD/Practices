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
    public class ClientController : Controller
    {
        ILogicLink core;

        public ClientController(ILogicLink core)
        {
            this.core = core;
        }
        // GET: Client
        public ActionResult Index()
        {
            List<Client> clients = core.GetClients();
            return View(clients);
        }

        [HttpGet]
        public ActionResult Add()
        {
            Client client = new Client();
            return View(client);
        }

        [HttpPost]
        public ActionResult Add(Client client)
        {
            if (ModelState.IsValid)
            {
                if (core.AddClient(client))
                {
                    return Redirect("/Client/Index");
                }
            }
            return View(client);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Client client = core.GetClientById(id);
            return View(client);
        }

        [HttpPost]
        public ActionResult Edit(int id, Client client)
        {
            if (ModelState.IsValid)
            {
                if (core.UpdateClient(id, client))
                {
                    return Redirect("/Client/Index");
                }
            }
            return View(client);
        }

        public ActionResult Delete(int id)
        {
            if (core.DeleteClient(id))
            {
                return Redirect("/Client/Index");
            }
            return HttpNotFound();
        }
        public ActionResult Products(Client client)
        {
            List<Product> products = core.GetProductsByClient(client);
            return View(products);
        }
    }
}