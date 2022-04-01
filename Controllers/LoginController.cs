using Microsoft.AspNetCore.Mvc;

namespace TigerTix.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login/
        public IActionResult Index()
        {
            return View();
        }
    }
}
