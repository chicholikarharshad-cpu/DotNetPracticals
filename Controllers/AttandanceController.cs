using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class AttandanceController : Controller
{


    public IActionResult Attandances()
    {
        
        return View();
    }

    public IActionResult ShowMassage()
    {
        return View();
    }


    public IActionResult DailyAttandance()
    {
        var Students = StudentController.students;
        ViewBag.students = Students;
        return View();
    }

    public IActionResult MonAttandance()
    {
        return View();
    }

    public IActionResult Absent()
    {
        return View();
    }


    public IActionResult Present()
    {
        return View();
    }

 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
