using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class NoticeController : Controller
{

    

    public IActionResult Notices()
    {
        
        return View();
    
    }
    

    public IActionResult NoticeDetails(int id)
    {

        ViewData["Num"] = id;
        return View();
    }



    

 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
