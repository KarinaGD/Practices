using MVCPractice.Core.Dependencies;
using MVCPractice.Data.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Command.ProductCommands
{
    class DeleteProductCommand : ICommand<bool>
    {
        private int id;
        private IDatalink data;

        public DeleteProductCommand(int id)
        {
            this.id = id;
            data = DependencyResolver.Instance.Data();
        }
        public bool Execute()
        {
            return data.Delete(id);
        }
    }
}
