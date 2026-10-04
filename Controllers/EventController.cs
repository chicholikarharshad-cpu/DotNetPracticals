using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class EventController : Controller
{

    

    public IActionResult Events()
    {
        
        return View();
    }



        public IActionResult Details()
    {
        
        return View();
    }


    public IActionResult Calendar()
    {
        
        return View();
    }


    public IActionResult Registration()
    {
        
        return View();
    }


    

 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
