namespace OptimizelyCommerceLearning.Features.Pages;

using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Geta.Optimizely.Categories.DataAnnotations;
using OptimizelyCommerceLearning.Features.Common;

public class SitePageData : PageData, ISitePageData
{
    [Categories]
    public virtual IList<ContentReference>? Categories { get; set; }

    [Display(
        Name = "Header",
        Description = "The page title to display in the header for the page.",
        GroupName = GroupNames.Content,
        Order = 5)]
    [Searchable]
    [CultureSpecific]
    [Required]
    public virtual string? Heading { get; set; }

    [Display(
        Name = "Short Page Name",
        Description = "Defines the page title for use in the breadcrumb trail and <title> tag. Where not specified the PageName attribute is used",
        GroupName = GroupNames.Content,
        Order = 9)]
    [Searchable]
    [CultureSpecific]
    public virtual string? ShortPageName { get; set; }

    [Display(
        Name = "Teaser Title",
        Description = "A teaser title to use when displaying as a block, card or search result.",
        GroupName = GroupNames.Teaser,
        Order = 700)]
    [CultureSpecific]
    public virtual string? TeaserTitle { get; set; }

    [Display(
        Name = "Teaser Subtitle",
        Description = "The subtitle to use when displaying as a block, card or search result.",
        GroupName = GroupNames.Teaser,
        Order = 701)]
    [CultureSpecific]
    public virtual string? TeaserSubtitle { get; set; }

    [Display(
        Name = "Teaser Intro Text",
        Description = "Teaser text to use when displaying as a block, card or search result.",
        GroupName = GroupNames.Teaser,
        Order = 702)]
    [CultureSpecific]
    public virtual string? TeaserDescription { get; set; }

    [Display(
        Name = "Teaser Image",
        Description = "The image to use when displaying as a block, card or search result.",
        GroupName = GroupNames.Teaser,
        Order = 703)]
    [UIHint(UIHint.Image)]
    [CultureSpecific]
    public virtual ContentReference? TeaserImage { get; set; }
}