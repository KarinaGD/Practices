using MVCPractice.Data.Facade;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVCPractice.Core.Dependencies
{
    public class DependencyResolver
    {
        private IKernel Kernel { get; set; }

        private static DependencyResolver instance = null;

        public static DependencyResolver Instance
        { 
            get
            {
                if (instance == null)
                {
                    instance = new DependencyResolver();
                }
                return instance;
            }
        }

        private DependencyResolver()
        {
            Kernel = new StandardKernel();
            Kernel.Load(Assembly.GetExecutingAssembly());
        }
        public IDatalink Data()
        {
            return Kernel.Get<Datalink>();
        }
    }
}
