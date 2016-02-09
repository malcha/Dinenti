using System;
using System.Collections.Generic;
using Autofac;
using System.Threading.Tasks;

namespace Core.Modules
{
    public class DataModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder
                .RegisterType<Helpers.UnitOfWork>()
                .As<Core.Helpers.IUnitOfWork>()
                .InstancePerLifetimeScope();

        }
    }
}
