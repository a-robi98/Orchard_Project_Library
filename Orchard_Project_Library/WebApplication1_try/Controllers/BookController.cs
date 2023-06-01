using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace WebApplication1_try.Controllers
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
