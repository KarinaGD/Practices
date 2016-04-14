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
    class SelectProductsCommand : ICommand<List<Product>>
    {
        private IDatalink data;

        public SelectProductsCommand()
        {
            data = DependencyResolver.Instance.Data();
        }
        public List<Product> Execute()
        {
            return data.Select();
        }
    }
}
