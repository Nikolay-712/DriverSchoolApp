﻿using DriverSchoolApp.Models.Categories;
using Microsoft.AspNetCore.Mvc;

namespace DriverSchoolApp.Controllers;

public class CategoriesController : Controller
{
    public IActionResult CategoryB()
    {
        Category_B category_B = new Category_B();

        return this.View(category_B);
    }


    public IActionResult CategoryBAuto()
    {
        Category_BAuto category_B = new Category_BAuto();

        return this.View(category_B);
    }

    public IActionResult CategoryBE()
    {
        Category_BE category_BE = new Category_BE();

        return this.View(category_BE);
    }

    public IActionResult CategoryC()
    {
        Category_C category_C = new Category_C();

        return this.View(category_C);
    }

    public IActionResult CategoryCE()
    {
        Category_CE category_CE = new Category_CE();

        return this.View(category_CE);
    }

    public IActionResult CategoryRefresh()
    {
        return this.View();
    }

}
