using DriverSchoolApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DriverSchoolApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        IndexViewModel indexViewModel = new IndexViewModel();

        return this.View(indexViewModel);
    }


    public IActionResult Courses()
    {
        CoursesModel courses = new CoursesModel();

        return this.View(courses);
    }


    public IActionResult Contacts()
        => this.View();

    public IActionResult AboutUs()
    {
        IndexViewModel indexViewModel = new IndexViewModel();

        return this.View(indexViewModel);
    }

    public IActionResult Error() => this.View();

}