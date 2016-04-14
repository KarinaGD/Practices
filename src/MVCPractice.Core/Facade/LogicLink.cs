using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPractice.Data.Databases;
using MVCPractice.Core.Command;
using MVCPractice.Core.Factory;

namespace MVCPractice.Core.Facade
{
    public class LogicLink : ILogicLink
    {
        // *** Product ***
        #region
        public bool AddProduct(Product product)
        {
            ICommand<bool> command = ProductFactory.AddProduct(product);
            return command.Execute();
        }

        public bool DeleteProduct(int id)
        {
            ICommand<bool> command = ProductFactory.DeleteProduct(id);
            return command.Execute();
        }

        public Product GetProductById(int id)
        {
            ICommand<Product> command = ProductFactory.SelectProductById(id);
            return command.Execute();
        }

        public List<Product> GetProducts()
        {
            ICommand<List<Product>> command = ProductFactory.SelectProducts();
            return command.Execute();
        }

        public bool UpdateProduct(int id, Product product)
        {
            ICommand<bool> command = ProductFactory.UpdateProduct(id, product);
            return command.Execute();
        }
        public List<Product> GetProductsByClient(Client client)
        {
            ICommand<List<Product>> command = ProductFactory.SelectProductsByClientCommand(client);
            return command.Execute();
        }
        #endregion

        // *** Client ***
        #region
        public bool AddClient(Client client)
        {
            ICommand<bool> command = ClientFactory.AddClientCommand(client);
            return command.Execute();
        }
        public bool DeleteClient(int id)
        {
            ICommand<bool> command = ClientFactory.DeleteClientCommand(id);
            return command.Execute();
        }
        public Client GetClientById(int id)
        {
            ICommand<Client> command = ClientFactory.SelectClientByIdCommand(id);
            return command.Execute();
        }
        public List<Client> GetClients()
        {
            ICommand<List<Client>> command = ClientFactory.SelectClientsCommand();
            return command.Execute();
        }
        public bool UpdateClient(int id, Client client)
        {
            ICommand<bool> command = ClientFactory.UpdateClientCommand(id, client);
            return command.Execute();
        }
        public List<Client> GetClientsByProduct(Product product)
        {
            ICommand<List<Client>> command = ClientFactory.SelectClientsByProductCommand(product);
            return command.Execute();
        }
        #endregion

        // *** Sale ***
        #region
        public bool AddSale(Sale sale)
        {
            ICommand<bool> command = SaleFactory.AddSaleCommand(sale);
            return command.Execute();
        }
        public List<Sale> GetSales()
        {
            ICommand<List<Sale>> command = SaleFactory.GetSalesCommand();
            return command.Execute();
        }
        public bool DeleteSale(int id)
        {
            ICommand<bool> command = SaleFactory.DeleteSaleCommand(id);
            return command.Execute();
        }
        public Sale GetSaleById(int id)
        {
            ICommand<Sale> command = SaleFactory.SelectSaleByIdCommand(id);
            return command.Execute();
        }
        #endregion
    }
}
