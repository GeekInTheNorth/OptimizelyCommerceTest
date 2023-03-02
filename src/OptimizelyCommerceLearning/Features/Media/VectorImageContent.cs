namespace OptimizelyCommerceLearning.Features.Media;

using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using OptimizelyCommerceLearning.Features.Common;

[ContentType(
    DisplayName = "Vector Image Content",
    GUID = "e113f322-c6fe-4567-9b5f-5cc5206873fd",
    Description = "Images can be uploaded as SVG formats only",
    GroupName = GroupNames.Content)]
[MediaDescriptor(ExtensionString = "svg")]
public class VectorImageContent : ImageData, IImageContent
{
    [Display(
        Name = "Image alt text",
        Description = "Description of the image",
        GroupName = GroupNames.Content,
        Order = 10)]
    public virtual string? AltText { get; set; }

    public string? ImageFocalPoint => null;
}