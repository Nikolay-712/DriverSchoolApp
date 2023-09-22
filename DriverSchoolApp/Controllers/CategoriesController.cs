using DriverSchoolApp.Models.Categories;
using Microsoft.AspNetCore.Mvc;

namespace DriverSchoolApp.Controllers;

public class CategoriesController : Controller
{
    public IActionResult CategoryB()
    {
        Category_B category_B = new Category_B();

        return this.View(category_B);
    }


    public IActionResult CategoryBAuto() =>
        this.View();

    public IActionResult CategoryC() =>
        this.View();

}
