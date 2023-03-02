namespace OptimizelyCommerceLearning.Features.Common;

using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

[GroupDefinitions]
public static class GroupNames
{
    [Display(Order = 10)]
    public const string Content = SystemTabNames.Content;

    [Display(Order = 20)]
    public const string Filter = "Filter";

    [Display(Order = 30)]
    public const string Teaser = "Teaser";

    [Display(Order = 40)]
    public const string SearchEngineOptimization = "SEO";

    [Display(Order = 50)]
    public const string SocialSharing = "Social Media";

    [Display(Order = 60)]
    public const string Header = "Header";

    [Display(Order = 70)]
    public const string Footer = "Footer";

    [Display(Order = 80)]
    public const string Search = "Search";

    [Display(Order = 999)]
    public const string Settings = SystemTabNames.Settings;
}