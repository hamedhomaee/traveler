using Microsoft.AspNetCore.Mvc;

namespace Traveler.WebSite.Controllers;

public class PagesController : Controller
{
    [Route("")]
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Contact()
    {
        return View();
    }
}