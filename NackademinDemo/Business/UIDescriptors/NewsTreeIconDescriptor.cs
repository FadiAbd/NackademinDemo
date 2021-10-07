using EPiServer.Shell;
using NackademinDemo.Models;

namespace NackademinDemo.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class NewsTreeIconDescriptor : UIDescriptor<IUseNewsTreeIcon>
    {
        public NewsTreeIconDescriptor()
        {
            IconClass = EpiserverDefaultContentIcons.ObjectIcons.PageContextual;
        }
    }

    public interface IUseNewsTreeIcon
    {
    }
}