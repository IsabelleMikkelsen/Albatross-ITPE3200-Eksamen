using Microsoft.AspNetCore.Mvc;

namespace Albatross.Controllers;

public class HomeController : Controller
{
    /*public IActionResult Index()
    {
        return View();
    } 
    
    Unsure if we need this*/


    //Redirect to login
    public IActionResult Index()
    {
        return RedirectToAction("Login", "Account");
    }
    
    //Front page after logging in
    public IActionResult Dashboard()
    {
        ViewBag.WelcomeMessage = "Welcome to Albatross!";
        return View();
    }
        
}