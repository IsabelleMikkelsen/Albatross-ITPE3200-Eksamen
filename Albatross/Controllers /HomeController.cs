//Testcommit
//Enda en testcommit
//Testcommit fra 80bble-branch 
using System.Diagnostics;
using Albatross.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Error()
{
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
}