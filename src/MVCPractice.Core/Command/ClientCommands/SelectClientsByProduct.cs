using MVCPractice.Core.Dependencies;
using MVCPractice.Data.Databases;
using MVCPractice.Data.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Command.ClientCommands
{
    class SelectClientsByProduct : ICommand<List<Client>>
    {
        private Product product;
        private IDatalink data;

        public SelectClientsByProduct(Product product)
        {
            this.product = product;
            data = DependencyResolver.Instance.Data();
        }
        public List<Client> Execute()
        {
            return data.SelectClientsByProduct(product);
        }
    }
}
