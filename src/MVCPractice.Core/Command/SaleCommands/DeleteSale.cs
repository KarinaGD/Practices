using MVCPractice.Core.Dependencies;
using MVCPractice.Data.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Command.SaleCommands
{
    class DeleteSale : ICommand<bool>
    {
        private int id;
        private IDatalink data;

        public DeleteSale(int id)
        {
            this.id = id;
            data = DependencyResolver.Instance.Data();
        }

        public bool Execute()
        {
            return data.DeleteSale(id);
        }
    }
}
