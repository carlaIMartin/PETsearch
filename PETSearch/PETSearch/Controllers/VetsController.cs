using Microsoft.AspNetCore.Mvc;

namespace PETSearch.Controllers
{
    public class VetsController : Controller
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
