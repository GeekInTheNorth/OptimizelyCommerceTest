namespace OptimizelyCommerceLearning.Features.Media;

using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using OptimizelyCommerceLearning.Features.Common;

[ContentType(
    DisplayName = "Image Content",
    GUID = "31e8200f-aec9-4463-a31d-053aec3f03a4",
    Description = "Images can be uploaded as JPG, JPE, JPEG, PNG or GIF formats only",
    GroupName = GroupNames.Content)]
[MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,png,gif")]
public class ImageContent : ImageData, IImageContent
{
    [Display(
        Name = "Alternative Text",
        Description = "Description of the image to be rendered in the image's alt property.",
        GroupName = GroupNames.Content,
        Order = 10)]
    public virtual string? AltText { get; set; }
}