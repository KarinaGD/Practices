using MVCPractice.Core.Command;
using MVCPractice.Core.Command.SaleCommands;
using MVCPractice.Data.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Factory
{
    class SaleFactory
    {
        public static ICommand<bool> AddSaleCommand(Sale sale)
        {
            return new AddSale(sale);
        }
        public static ICommand<List<Sale>> GetSalesCommand()
        {
            return new SelectSales();
        }
        public static ICommand<bool> DeleteSaleCommand(int id)
        {
            return new DeleteSale(id);
        }
        public static ICommand<Sale> SelectSaleByIdCommand(int id)
        {
            return new SelectSaleById(id);
        }

    }
}
