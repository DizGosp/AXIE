using AXIE.Models.Account;
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

        [HttpGet]
        protected async Task<List<AccountDTO>> GetByParametars([FromQuery]AccountSearchDTO request)
        {
            return await _accountService.GetByParametars(request);
        }
    }
}
