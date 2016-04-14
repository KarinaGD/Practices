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
    class UpdateClient : ICommand<bool>
    {
        private int id;
        private Client client;
        private IDatalink data;

        public UpdateClient(int id, Client client)
        {
            this.id = id;
            this.client = client;
            this.client.UpdateAt = DateTime.Now;
            data = DependencyResolver.Instance.Data();
        }
        public bool Execute()
        {
            return data.UpdateClient(id, client);
        }
    }
}
