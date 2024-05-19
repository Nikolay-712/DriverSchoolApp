using DriverSchoolApp.Models.Categories;
using Microsoft.AspNetCore.Mvc;

namespace DriverSchoolApp.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Category_b()
    {
        Category_B category_B = new Category_B();

        return this.View(category_B);
    }


    public IActionResult Category_b_auto()
    {
        Category_BAuto category_B = new Category_BAuto();

        return this.View(category_B);
    }

    public IActionResult Category_be()
    {
        Category_BE category_BE = new Category_BE();

        return this.View(category_BE);
    }

    public IActionResult Category_c()
    {
        Category_C category_C = new Category_C();

        return this.View(category_C);
    }

    public IActionResult Category_ce()
    {
        Category_CE category_CE = new Category_CE();

        return this.View(category_CE);
    }

    public IActionResult Category_refresh()
    {
        return this.View();
    }

}
