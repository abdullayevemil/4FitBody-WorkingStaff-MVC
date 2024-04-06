﻿namespace Just4Fit_WorkingStaff.Presentation.Controllers;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Just4Fit_WorkingStaff.Presentation.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}