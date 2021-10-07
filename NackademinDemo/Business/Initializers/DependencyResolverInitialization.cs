using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using NackademinDemo.Abstractions;
using NackademinDemo.Models;
using NackademinDemo.Services;
using System.Web.Mvc;

namespace NackademinDemo.Business.Initializers
{
    [InitializableModule]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.ConfigurationComplete += (o, e) =>
            {
                context.Services.AddTransient<IMovieService, MovieService>();
                context.Services.AddTransient<IDdsService, DdsService>();
            };
        }

        public void Initialize(InitializationEngine context)
        {
            DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}