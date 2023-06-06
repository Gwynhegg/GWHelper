using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using GWHelper.Infrastructure.AutofacModules;
using GWHelper.Infrastructure.Services;
using GWHelper.Infrastructure.Services.Interfaces;

namespace GWHelper.AppStart
{
    public static class RegisterConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<InfrastructureModule>();

            AutofacContainer.Container = builder.Build();

        }
    }
}
