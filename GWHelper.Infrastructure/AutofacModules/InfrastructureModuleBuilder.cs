using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GWHelper.Infrastructure.Models;
using GWHelper.Infrastructure.Services;
using GWHelper.Infrastructure.Services.Interfaces;

namespace GWHelper.Infrastructure.AutofacModules
{
    public class InfrastructureModuleBuilder
    {
        private readonly ContainerBuilder _builder;

        public InfrastructureModuleBuilder(ContainerBuilder builder)
        {
            _builder = builder;
        }
        public void Registers()
        {
            _builder.RegisterType<DbService<User>>().As<IDbService<User>>();
            _builder.RegisterType<GwUserService>().As<IGwUserService>();
            _builder.RegisterType<GwInfoService>().As<IGwInfoService>();
        }
    }
}
