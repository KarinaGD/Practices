using MVCPractice.Core.Dependencies;
using MVCPractice.Data.Databases;
using MVCPractice.Data.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Command.SaleCommands
{
    class AddSale : ICommand<bool>
    {
        private Sale sale;
        private IDatalink data;

        public AddSale(Sale sale)
        {
            this.sale = sale;
            data = DependencyResolver.Instance.Data();
        }

        public bool Execute()
        {
            sale.CreatedAt = DateTime.Now;
            return data.InsertSale(sale);
        }
    }
}
