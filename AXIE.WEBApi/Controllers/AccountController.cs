using AXIE.Model.Account;
using AXIE.WEBApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AXIE.WEBApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult <List<AccountDTO>> Index()
        {
            return _accountService.GetAll();
        }
    }
}
