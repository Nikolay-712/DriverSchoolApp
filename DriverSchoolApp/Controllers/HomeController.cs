using DriverSchoolApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DriverSchoolApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
        => this.View();

    public IActionResult Courses() 
        => this.View();

    public IActionResult Contacts()
        => this.View();

}