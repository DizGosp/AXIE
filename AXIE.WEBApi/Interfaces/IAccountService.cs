using AXIE.Models.Account;

namespace AXIE.WEBApi.Interfaces
{
    public interface IAccountService : IGlobalService<AccountDTO>
    {
        Task<List<AccountDTO>> GetByParametars(AccountSearchDTO request);
    }
}
