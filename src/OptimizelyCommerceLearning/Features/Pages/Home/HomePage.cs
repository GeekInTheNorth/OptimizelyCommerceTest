namespace OptimizelyCommerceLearning.Features.Pages.Home;

using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using Geta.Optimizely.ContentTypeIcons;
using Geta.Optimizely.ContentTypeIcons.Attributes;
using OptimizelyCommerceLearning.Features.Blocks;
using OptimizelyCommerceLearning.Features.Common;

[ContentType(
    DisplayName = "Home Page",
    GUID = "060C7B3A-971D-4632-92C4-B493C2DA8D52",
    Description = "A page designed as a default landing page.",
    GroupName = GroupNames.Content)]
[ContentTypeIcon(FontAwesome.Home)]
public class HomePage : SitePageData
{
    [Display(
        Name = "Content",
        GroupName = GroupNames.Content,
        Order = 10)]
    [AllowedTypes(typeof(IContentBlock))]
    public virtual ContentArea? Content { get; set; }
}