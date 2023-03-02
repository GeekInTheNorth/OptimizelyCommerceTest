namespace OptimizelyCommerceLearning.Features.Blocks;

using EPiServer.Core;

/// <summary>
/// Used to define a standard content block to be allowed in main content areas.
/// This combined with <see cref="ContentBlockUiDescriptor"/> simplify these declarations.
/// </summary>
public interface IContentBlock : IContentData
{
}