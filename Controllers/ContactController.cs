using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class ContactController : Controller
{

    

    public IActionResult Contacts()
    {
        
        return View();
    }


    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Location()
    {
        
        return View();
    }

    public IActionResult OfficeTime()
    {
        return View();
    }

    public IActionResult Helps()
    {
        return View();
    }


    

 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
