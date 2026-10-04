
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicalsAsProject.Models;

namespace practicalsAsProject.Controllers;

public class ResultController : Controller
{

    public IActionResult Results(){
        return View();
    }

    public IActionResult Marksheet()
    {
        return View();
    }

    public IActionResult Grades()
    {
        return View();
    }

    public IActionResult RankList()
    {
        return View();
    }
    


}
