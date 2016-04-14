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
    class SelectSales : ICommand<List<Sale>>
    {
        private IDatalink data;

        public SelectSales()
        {
            data = DependencyResolver.Instance.Data();
        }

        public List<Sale> Execute()
        {
            return data.SelectSales();
        }
    }
}
