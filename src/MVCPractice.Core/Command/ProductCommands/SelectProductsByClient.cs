using MVCPractice.Core.Dependencies;
using MVCPractice.Data.Databases;
using MVCPractice.Data.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Command.ProductCommands
{
    class SelectProductsByClient : ICommand<List<Product>>
    {
        private Client client;
        private IDatalink data;

        public SelectProductsByClient(Client client)
        {
            this.client = client;
            data = DependencyResolver.Instance.Data();
        }
        public List<Product> Execute()
        {
            return data.SelectProductsByClient(client);
        }
    }
}
