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
    class SelectClients : ICommand<List<Client>>
    {
        private IDatalink data;

        public SelectClients()
        {
            data = DependencyResolver.Instance.Data();
        }
        public List<Client> Execute()
        {
            return data.SelectClient();
        }
    }
}
