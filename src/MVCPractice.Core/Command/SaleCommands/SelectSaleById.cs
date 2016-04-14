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
    class SelectSaleById : ICommand<Sale>
    {
        private int id;
        private IDatalink data;

        public SelectSaleById(int id)
        {
            this.id = id;
            data = DependencyResolver.Instance.Data();
        }
        public Sale Execute()
        {
            return data.SelectSaleById(id);
        }
    }
}
