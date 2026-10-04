using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class FacultyController : Controller
{

    

    public IActionResult Facultys()
    {
        
        return View();
    }


    public IActionResult Details()
    {
        return View();
    }


     public IActionResult SubjectOffaculty()
    {
        return View();
    }


     public IActionResult ScheduleOfFaculty()
    {
        return View();
    }
    

 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
