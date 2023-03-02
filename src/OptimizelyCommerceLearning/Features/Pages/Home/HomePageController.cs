namespace OptimizelyCommerceLearning.Features.Pages.Home;

using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

public class HomePageController : PageController<HomePage>
{
    private readonly IHomePageViewModelBuilder _viewModelBuilder;

    public HomePageController(IHomePageViewModelBuilder viewModelBuilder)
    {
        _viewModelBuilder = viewModelBuilder;
    }

    [HttpGet]
    public IActionResult Index(HomePage currentPage)
    {
        var model = _viewModelBuilder.WithContent(currentPage).Build();

        return View(model);
    }
}
