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
    class SelectByIdClient : ICommand<Client>
    {
        int id;
        private IDatalink data;
        
        public SelectByIdClient(int id)
        {
            this.id = id;
            data = DependencyResolver.Instance.Data();
        }
        public Client Execute()
        {
            return data.SelectByIdClient(id);
        }
    }
}
