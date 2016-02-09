using Autofac;
using Autofac.Configuration;
using Autofac.Integration.Mvc;
//TODO Autofact
//using Autofac.Integration.WebApi;
using Core.Modules;
using System;
using System.Linq;
using System.Web;

namespace Web.Presentation.App_Start
{
    public class DependenciesConfig
    {

        public static void Register(System.Web.Http.HttpConfiguration config)
        {
            var builder = new Autofac.ContainerBuilder();

            builder.RegisterModule(new ConfigurationSettingsReader());
            //TODO Autofact
            //builder.RegisterModule(new DataModule.Modules.DataModule());
        }
    }
}