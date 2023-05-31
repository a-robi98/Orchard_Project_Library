using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Orchard_Project_Library.BookModule.Controllers
{
    public class BookController : Controller
    {
        private readonly IStringLocalizer T;

        public BookController(IStringLocalizer<BookController> stringLocalizer)
        {
                T = stringLocalizer;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = T["Ady Endre: Verses kötet"];
            return View();
        }
    }
}
