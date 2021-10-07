using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace NackademinDemo.Models.Media
{
    [ContentType(
        GUID = "CBE0FFD0-BC59-4780-B72A-F0E8E3CDF431"
    )]
    [MediaDescriptor(
        ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png"
    )]
    public class ImageFile : ImageData
    {
    }
}