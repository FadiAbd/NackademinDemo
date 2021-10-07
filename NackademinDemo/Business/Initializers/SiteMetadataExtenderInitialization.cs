using EPiServer.Cms.Shell;
using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Shell.ObjectEditing;
using NackademinDemo.Business.MetaDataExtenders;

namespace NackademinDemo.Business.Initializers
{
    [InitializableModule]
    [ModuleDependency(typeof(InitializableModule))]
    public class SiteMetadataExtenderInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                var registry = context.Locate.Advanced.GetInstance<MetadataHandlerRegistry>();
                registry.RegisterMetadataHandler(typeof(ContentData), new SiteMetadataExtender());
            }
        }

        public void Uninitialize(InitializationEngine context)
        {            
        }
    }
}