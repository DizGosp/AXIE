using Microsoft.AspNetCore.Mvc;

namespace AXIE.WEBApi.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
