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

    class UpdateProductCommand : ICommand<bool>
    {
        private Product product;
        private int id;
        private IDatalink data;

        public UpdateProductCommand(int id,  Product product)
        {
            this.id = id;
            this.product = product;
            product.UpdateAt = DateTime.Now;
            data = DependencyResolver.Instance.Data();
        }

        public bool Execute()
        {
            return data.Update(id,product);
        }
    }
}
