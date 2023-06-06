using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace GWHelper.Infrastructure.AutofacModules
{
    public class InfrastructureModule : Module   
    {
        protected override void Load(ContainerBuilder builder)
        {
            var module = new InfrastructureModuleBuilder(builder);
            module.Registers();
        }
    }
}
