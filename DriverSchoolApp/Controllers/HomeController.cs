using DriverSchoolApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DriverSchoolApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
        => this.View();

    public IActionResult Courses()
    {
        CoursesModel courses = new CoursesModel();

        return this.View(courses);
    }


    public IActionResult Contacts()
        => this.View();

    public IActionResult AboutUs()
        => this.View();

    public IActionResult Error() => this.View();

}