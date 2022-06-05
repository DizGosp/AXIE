using AXIE.Models.Account;

namespace AXIE.WEBApi.Interfaces
{
    public interface IAccountService : IGlobalService<AccountDTO>
    {
        List<AccountDTO> GetByParametars(AccountSearchDTO request);
    }
}
