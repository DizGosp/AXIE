using AXIE.Models.AccountRonin;
using AXIE.WEBApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AXIE.WEBApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountRoninController : Controller
    {
        private readonly IAccountRoninService _acountRoninService;

        public AccountRoninController(IAccountRoninService accountRoninService)
        {
            _acountRoninService = accountRoninService;
        }

        [HttpGet]
        public ActionResult<List<AccountRoninDTO>> Index()
        {
            return _acountRoninService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<AccountRoninDTO> GetById(Guid id)
        {
            return await _acountRoninService.GetById(id);
        }

        [HttpPost]
        public Task Add([FromQuery] AccountRoninDTO request)
        {
            return _acountRoninService.Add(request);
        }

        //[HttpGet("{ronin}")]
        //public async Task<AccountRoninDTO> GetByParams(string ronin)
        //{
        //    return await _acountRoninService.GetAccountRoninByParams(ronin);
        //}
    }
}
