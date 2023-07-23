using Microsoft.AspNetCore.Mvc;

namespace DriverSchoolApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult CategoryB() =>
            this. View();

        public IActionResult CategoryBAuto() =>
            this.View();

        public IActionResult CategoryC() =>
            this.View();

    }
}
