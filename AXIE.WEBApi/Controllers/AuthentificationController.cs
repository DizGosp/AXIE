using AXIE.Models.AppUsers;
using AXIE.WEBApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AXIE.WEBApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthentificationController : Controller
    {
        private readonly IAuthentificationService _authentificationService;

        public AuthentificationController(IAuthentificationService authentificationService)
        {
            _authentificationService = authentificationService;
        }

        [HttpPost]
        public IActionResult Index([FromQuery] AppUserDTO user)
        {
            var appUser=_authentificationService.Login(user);

            if(appUser != null)
            {
                return View(appUser);
            }

            return View(null);
        }
    }
}
