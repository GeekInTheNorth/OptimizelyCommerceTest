namespace OptimizelyCommerceLearning.Features.Blocks.Image;

using System.ComponentModel.DataAnnotations;

using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

using Geta.Optimizely.ContentTypeIcons;
using Geta.Optimizely.ContentTypeIcons.Attributes;

using OptimizelyCommerceLearning.Features.Common;

[ContentType(
    DisplayName = "Image Block",
    GUID = "96A7ADB5-7E3B-4958-A611-BDF8F1B7F3D3",
    Description = "Encapsulates an image and a caption.",
    GroupName = SystemTabNames.Content)]
[ContentTypeIcon(FontAwesome.Image)]
public class ImageBlock : BlockData, IContentBlock
{
    [Display(
        Name = "Image",
        Description = "The image to render on the block.",
        GroupName = GroupNames.Content,
        Order = 10)]
    [Required]
    [UIHint(UIHint.Image)]
    public virtual ContentReference? ImageReference { get; set; }

    [Display(
        Name = "Caption",
        Description = "The text to show below the image as a caption.",
        GroupName = GroupNames.Content,
        Order = 20)]
    public virtual string? Caption { get; set; }
}