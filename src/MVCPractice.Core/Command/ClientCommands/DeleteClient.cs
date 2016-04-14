using MVCPractice.Core.Dependencies;
using MVCPractice.Data.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Command.ClientCommands
{
    class DeleteClient : ICommand<bool>
    {
        int id;
        private IDatalink data;

        public DeleteClient(int id)
        {
            this.id = id;
            data = DependencyResolver.Instance.Data();
        }
        public bool Execute()
        {
            return data.DeleteClient(id);
        }
    }
}
