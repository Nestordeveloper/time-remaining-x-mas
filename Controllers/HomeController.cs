using Microsoft.AspNetCore.Mvc;
namespace ProjectName.Controllers;
public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        return View("Index");
    }
}