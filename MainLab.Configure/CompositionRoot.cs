using Autofac;
using MainLab.BusinessService;
using MainLab.DataAccess;
using MainLab.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.Configure
{
    public class CompositionRoot
    {
        public IBusinessService root { get; private set; }

        public void BuildApplication()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GeneralLogger>().As<ILogger>();
            builder.RegisterType<BusinessServiceImpl>().As<IBusinessService>();
            builder.RegisterType<DataAccessImpl>().As<IDataAccess>();

            var container = builder.Build();
            root = container.Resolve<IBusinessService>();
        }
    }
}
