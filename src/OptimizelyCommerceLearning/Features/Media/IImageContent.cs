namespace OptimizelyCommerceLearning.Features.Media;

using EPiServer.Core;

/// <summary>
/// Used to define a standard image content structure across the site.
/// This combined with <see cref="ImageContentUIDescriptor"/> simplify these declarations.
/// </summary>
public interface IImageContent : IContent
{
    string? AltText { get; }
}