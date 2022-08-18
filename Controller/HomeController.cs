using Microsoft.AspNetCore.Mvc;

public class HomeController : HomeController
{
    public IActionResult Index()
    {
        return View();
    }
}