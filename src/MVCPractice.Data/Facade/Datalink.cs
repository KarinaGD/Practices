using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPractice.Data.Databases;

namespace MVCPractice.Data.Facade
{
    public class Datalink : IDatalink
    {
        // ******* Product *******
        #region

        public bool Insert(Product product)
        {
            var inserted = false;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    // Coloco la informacion de la tabla producto en la variable table.
                    var table = context.Set<Product>();
                    // Agrego un nuevo producto en la tabla Producto.
                    table.Add(product);
                    // salvo los cambios en la BD.
                    context.SaveChanges();
                }
                inserted = true;
            }
            catch (Exception e)
            {
                
            }

            return inserted;
        }


        public List<Product> Select()
        {
            List<Product> products = null;
            using (MVCPracticeDB context = new MVCPracticeDB())
            {
                products = context.Products.ToList();
            }
            return products;
        }

        public Product SelectById(int id)
        {
            Product product = null;
            using (MVCPracticeDB context = new MVCPracticeDB())
            {
                product = context.Products.SingleOrDefault(p => p.Id == id);
            }
            return product;
        }

        public bool Delete(int id)
        {
            var deleted = false;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    Product product = SelectById(id);
                    context.Products.Attach(product);
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                deleted = true;
            }
            catch (Exception e)
            {

            }

            return deleted;
        }

        public bool Update(int id, Product product)
        {
            var updated = false;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    Product dbProduct = SelectById(id);
                    context.Products.Attach(dbProduct);
                    dbProduct.Name = product.Name;
                    dbProduct.Descriptions = product.Descriptions;
                    dbProduct.Price = product.Price;
                    context.SaveChanges();
                }
                updated = true;
            }
            catch (Exception e)
            {

            }

            return updated;
        }
        public List<Product> SelectProductsByClient(Client client)
        {

            List <Product> products = null;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    List<Sale> sales = null;
                    sales = context.Sales.Include("Product").Where(s => s.ClientId == client.Id).ToList();
                    products = sales.Select(p => p.Product).Distinct().ToList();
                }
            }
            catch (Exception e)
            {

            }
            return products;
        }
        #endregion


        // ******* Client *******
        #region
        public bool InsertClient(Client client)
        {
            var inserted = false;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    // Coloco la informacion de la tabla Client en la variable table.
                    var table = context.Set<Client>();
                    // Agrego un nuevo cliente en la tabla Client.
                    table.Add(client);
                    // Salvo los cambios en la BD.
                    context.SaveChanges();
                }
                inserted = true;
            }
            catch (Exception e)
            {

            }
            return inserted;
        }

        public List<Client> SelectClient()
        {
            List<Client> clients = null;
            using (MVCPracticeDB context = new MVCPracticeDB())
            {
                clients = context.Clients.ToList();
            }
            return clients;
        }

        public Client SelectByIdClient(int id)
        {
            Client client = null;
            using (MVCPracticeDB context = new MVCPracticeDB())
            {
                client = context.Clients.SingleOrDefault(c => c.Id == id);
            }
            return client;
        }

        public bool DeleteClient(int id)
        {
            var deleted = false;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    Client client = SelectByIdClient(id);
                    context.Clients.Attach(client);
                    context.Clients.Remove(client);
                    context.SaveChanges();
                }
                deleted = true;
            }
            catch (Exception e)
            {

            }

            return deleted;
        }
        public bool UpdateClient(int id, Client client)
        {
            var updated = false;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    Client dbClient = SelectByIdClient(id);
                    context.Clients.Attach(dbClient);
                    dbClient.Name = client.Name;
                    dbClient.SurName= client.SurName;
                    dbClient.Email = client.Email;
                    dbClient.Birthday = client.Birthday;
                    dbClient.Gender = client.Gender;
                    context.SaveChanges();
                }
                updated = true;
            }
            catch (Exception e)
            {

            }

            return updated;
        }
        public List<Client> SelectClientsByProduct(Product product)
        {
            List<Client> clients = null;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    List<Sale> sales = null;
                    sales = context.Sales.Include("Client").Where(s => s.ProductId == product.Id).ToList();
                    clients = sales.Select(c => c.Client).Distinct().ToList();
                }
            }
            catch (Exception e)
            {

            }
            return clients;
        }
        #endregion

        // ******* Sale *******
        #region
        public bool InsertSale(Sale sale)
        {
            var inserted = false;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    // Coloco la informacion de la tabla Sale en la variable table.
                    var table = context.Set<Sale>();
                    // Agrego una nueva venta en la tabla Sale.
                    table.Add(sale);
                    // Salvo los cambios en la BD.
                    context.SaveChanges();
                }
                inserted = true;
            }
            catch (Exception e)
            {

            }
            return inserted;
        }

        public List<Sale> SelectSales()
        {
            List<Sale> sales = null;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    sales = context.Sales.Include("Client").Include("Product").ToList();
                }
            }
            catch (Exception e)
            {

            }
            return sales;
        }
        public Sale SelectSaleById(int id)
        {
            Sale sale = null;
            using (MVCPracticeDB context = new MVCPracticeDB())
            {
                sale = context.Sales.SingleOrDefault(s => s.Id == id);
            }
            return sale;
        }

        public bool DeleteSale(int id)
        {
            var deleted = false;

            try
            {
                using (MVCPracticeDB context = new MVCPracticeDB())
                {
                    Sale sale = SelectSaleById(id);
                    context.Sales.Attach(sale);
                    context.Sales.Remove(sale);
                    context.SaveChanges();
                }
                deleted = true;
            }
            catch (Exception e)
            {

            }

            return deleted;
        }

        
        #endregion
    }
}
