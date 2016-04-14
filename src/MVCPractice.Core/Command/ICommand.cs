using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Command
{
    public interface ICommand<T>
    {
        T Execute();
    }
}
