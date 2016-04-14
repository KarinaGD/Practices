using MVCPractice.Data.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Facade
{
    public interface ILogicLink
    {
        // *** Product ***
        #region
        bool AddProduct(Product product);
        bool DeleteProduct(int id);
        bool UpdateProduct(int id, Product product);
        List<Product> GetProducts();
        Product GetProductById(int id);
        List<Product> GetProductsByClient(Client client);
        #endregion

        // *** Client ***
        #region
        bool AddClient(Client client);
        bool DeleteClient(int id);
        bool UpdateClient(int id, Client client);
        List<Client> GetClients();
        Client GetClientById(int id);
        List<Client> GetClientsByProduct(Product product);
        #endregion

        // *** Sale ***
        #region
        bool AddSale(Sale sale);
        List<Sale> GetSales();
        Sale GetSaleById(int id);
        bool DeleteSale(int id);
        #endregion
    }
}
