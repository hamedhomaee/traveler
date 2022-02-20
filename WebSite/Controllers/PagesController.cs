using Microsoft.AspNetCore.Mvc;

namespace Traveler.WebSite.Controllers;

public class PagesController : Controller
{
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }
}   