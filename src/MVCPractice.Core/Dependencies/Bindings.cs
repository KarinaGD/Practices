using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPractice.Data.Facade;

namespace MVCPractice.Core.Dependencies
{
    class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IDatalink>().To<Datalink>().InSingletonScope();
        }
    }
}
