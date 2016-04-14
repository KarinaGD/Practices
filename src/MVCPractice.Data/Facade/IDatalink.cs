using MVCPractice.Data.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Data.Facade
{
    public interface IDatalink
    {
        // ***Product ***
        #region
        bool Insert(Product product);
        bool Update(int id, Product product);
        bool Delete(int id);
        List<Product> Select();
        Product SelectById(int id);
        List<Product> SelectProductsByClient(Client client);
        #endregion

        // *** Client ***
        #region
        bool InsertClient(Client client);
        bool UpdateClient(int id, Client client);
        bool DeleteClient(int id);
        List<Client> SelectClient();
        Client SelectByIdClient(int id);
        List<Client> SelectClientsByProduct(Product product);
        #endregion

        // *** Sale ***
        #region
        bool InsertSale(Sale sale);
        List<Sale> SelectSales();
        Sale SelectSaleById(int id);
        bool DeleteSale(int id);
        #endregion
    }
}
