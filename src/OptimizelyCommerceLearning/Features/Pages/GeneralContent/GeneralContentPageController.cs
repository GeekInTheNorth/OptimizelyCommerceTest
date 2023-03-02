namespace OptimizelyCommerceLearning.Features.Pages.GeneralContent;

using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

public class GeneralContentPageController : PageController<GeneralContentPage>
{
    [HttpGet]
    public IActionResult Index(GeneralContentPage currentPage)
    {
        var model = new GeneralContentPageViewModel(currentPage);

        return View(model);
    }
}