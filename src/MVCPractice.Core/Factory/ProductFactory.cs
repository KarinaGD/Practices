using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPractice.Core.Command;
using MVCPractice.Core.Command.ProductCommands;
using MVCPractice.Data.Databases;

namespace MVCPractice.Core.Factory
{
    class ProductFactory
    {
        public static ICommand<bool> AddProduct(Product product)
        {
            return new AddProductCommand(product);
        }

        public static ICommand<bool> DeleteProduct(int id)
        {
            return new DeleteProductCommand(id);
        }


        public static ICommand<bool> UpdateProduct(int id, Product product)
        {
            return new UpdateProductCommand(id, product);
        }

        public static ICommand<List<Product>> SelectProducts()
        {
            return new SelectProductsCommand();
        }
        public static ICommand<Product> SelectProductById(int id)
        {
            return new SelectByIdProductCommand(id);
        }
        public static ICommand<List<Product>> SelectProductsByClientCommand(Client client)
        {
            return new SelectProductsByClient(client);
        }
    }
}
