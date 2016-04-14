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
    class AddProductCommand : ICommand<bool>
    {
        private Product product;
        private IDatalink data;

        public AddProductCommand(Product product)
        {
            this.product = product;
            data = DependencyResolver.Instance.Data();
        }
        public bool Execute()
        {
            product.CreateAt = DateTime.Now;
            product.UpdateAt = DateTime.Now;
            return data.Insert(product);
        }
    }
}
