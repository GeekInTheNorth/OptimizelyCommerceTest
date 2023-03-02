namespace OptimizelyCommerceLearning.Features.Blocks.RichText;

using System.ComponentModel.DataAnnotations;

using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using Geta.Optimizely.ContentTypeIcons;
using Geta.Optimizely.ContentTypeIcons.Attributes;

[ContentType(
    DisplayName = "Rich Text Block",
    GUID = "ad51630a-45a9-40d6-ba24-1817e7c3cdd7",
    Description = "",
    GroupName = SystemTabNames.Content)]
[ContentTypeIcon(FontAwesome.Pencil)]
public class RichTextBlock : BlockData, IContentBlock
{
    [Display(
        Name = "Content",
        Description = "Rich Text Content",
        GroupName = SystemTabNames.Content,
        Order = 1)]
    public virtual XhtmlString? Content { get; set; }
}
