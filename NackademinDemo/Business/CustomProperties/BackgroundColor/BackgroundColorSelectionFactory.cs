using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

namespace NackademinDemo.Business.CustomProperties.BackgroundColor
{
    public class BackgroundColorSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var selections = new List<ISelectItem>
            {
                new SelectItem { Value = "", Text = "Välj en bakgrundsfärg" },
                new SelectItem { Value = "nackademin-orange", Text = "Nackademin orange" },
                new SelectItem { Value = "nackademin-blue", Text = "Nackademin blå" }
            };

            return selections;
        }
    }
}