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
    class AddClient : ICommand<bool>
    {
        private Client client;
        private IDatalink data;

        public AddClient(Client client)
        {
            this.client = client;
            data = DependencyResolver.Instance.Data();
        }
        public bool Execute()
        {
            client.CreatedAt = DateTime.Now;
            client.UpdateAt = DateTime.Now;

            return data.InsertClient(client);
        }
    }
}
