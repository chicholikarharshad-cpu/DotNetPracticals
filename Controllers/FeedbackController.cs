using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class feedbackController : Controller
{

    

    public IActionResult Feedback()
    {
        
        return View();
    }


    public IActionResult FormSubmit()
    {
        return View();
    }


    public IActionResult TotalFeedback()
    {
        return View();
    }

    
    public IActionResult Details()
    {
        return View();
    }

 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
