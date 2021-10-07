using EPiServer.Shell;
using NackademinDemo.Models.Pages;

namespace NackademinDemo.Business.UIDescriptors
{
    public class ForceAllPropertiesViewUiDescriptor : UIDescriptor<StartPage>
    {
        public ForceAllPropertiesViewUiDescriptor()
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}