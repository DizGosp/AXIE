using AXIE.Models.Account;
using AXIE.Models.AccountRonin;
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

        [HttpPost]
        public  List<AccountDTO> GetByParametars([FromQuery]AccountSearchDTO request)
        {
            return _accountService.GetByParametars(request);
        }
        
        [HttpGet("{id}")]
        public async Task<AccountDTO> GetById(Guid id)
        {
            return await _accountService.GetById(id);
        }
    }
}
