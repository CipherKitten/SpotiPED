using Microsoft.AspNetCore.Mvc;

namespace SpotiPED.Controllers;

public class ProfileController : Controller 
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}