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
    class SelectByIdProductCommand : ICommand<Product>
    {
        private int id;
        private IDatalink data;


        public SelectByIdProductCommand(int id)
        {
            this.id = id;
            data = DependencyResolver.Instance.Data();
        }
        public Product Execute()
        {
            return data.SelectById(id);
        }
    }
}
