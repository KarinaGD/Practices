using MVCPractice.Core.Command;
using MVCPractice.Core.Command.ClientCommands;
using MVCPractice.Data.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Factory
{
    class ClientFactory
    {
        public static ICommand<bool> AddClientCommand(Client client)
        {
            return new AddClient(client);
        }
        public static ICommand<bool> DeleteClientCommand(int id)
        {
            return new DeleteClient(id);
        }
        public static ICommand<Client> SelectClientByIdCommand(int id)
        {
            return new SelectByIdClient(id);
        }
        public static ICommand<List<Client>> SelectClientsCommand()
        {
            return new SelectClients();
        }
        public static ICommand<bool> UpdateClientCommand(int id, Client client)
        {
            return new UpdateClient(id, client);
        }
        public static ICommand<List<Client>> SelectClientsByProductCommand(Product product)
        {
            return new SelectClientsByProduct(product);
        }
    }
}
