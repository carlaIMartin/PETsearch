using Microsoft.AspNetCore.Mvc;

namespace PETSearch.Controllers
{
    public class PersonsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

    }
}
