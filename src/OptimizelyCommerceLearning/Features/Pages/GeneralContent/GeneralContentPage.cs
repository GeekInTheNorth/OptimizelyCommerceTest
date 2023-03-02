namespace OptimizelyCommerceLearning.Features.Pages.GeneralContent;

using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using Geta.Optimizely.ContentTypeIcons;
using Geta.Optimizely.ContentTypeIcons.Attributes;
using OptimizelyCommerceLearning.Features.Blocks;
using OptimizelyCommerceLearning.Features.Common;

[ContentType(
    DisplayName = "General Content Page",
    Description = "A flexible page for general usage that allows all content blocks.",
    GUID = "B14FD34A-EA69-4CE7-849A-EBE6F0541727",
    GroupName = GroupNames.Content)]
[ContentTypeIcon(FontAwesome5Solid.File)]
public class GeneralContentPage : SitePageData
{
    [Display(
        Name = "Main Content",
        Description = "A content area that allows blocks that have been specifically designed as content.",
        GroupName = GroupNames.Content,
        Order = 10)]
    [AllowedTypes(typeof(IContentBlock))]
    public virtual ContentArea? MainContent { get; set; }
}