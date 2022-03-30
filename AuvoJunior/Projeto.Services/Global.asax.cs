using Projeto.Business;
using Projeto.Business.Contracts;
using Projeto.Repository.Contracts;
using Projeto.Repository.Persistence;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Projeto.Services
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            container.Register<ICidadeBusiness, CidadeBusiness>(Lifestyle.Scoped);
            container.Register<IEstadoBusiness, EstadoBusiness>(Lifestyle.Scoped);
          container.Register<IPrevisaoClimaBusiness, PrevisaoClimaBusiness>(Lifestyle.Scoped);

            container.Register<ICidadeRepository, CidadeRepository>(Lifestyle.Scoped);
            container.Register<IEstadoRepository, EstadoRepository>(Lifestyle.Scoped);
            container.Register<IPrevisaoClimaRepository, PrevisaoClimaRepository>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

            // Here your usual Web API configuration stuff.
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");

            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, Authorization");
                HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
                HttpContext.Current.Response.End();
            }
        }
    }
}
