using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System;
using System.Collections.Generic;

namespace NackademinDemo.Business.CustomProperties.BackgroundColor
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = "BackgroundColor"
    )]
    public class BackgroundColorDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            SelectionFactoryType = typeof(BackgroundColorSelectionFactory);
            ClientEditingClass = "epi-cms/contentediting/editors/SelectionEditor";

            base.ModifyMetadata(metadata, attributes);
        }
    }
}