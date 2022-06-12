using AXIE.Models.AccountRonin;

namespace AXIE.WEBApi.Interfaces
{
    public interface IAccountRoninService : IGlobalService<AccountRoninDTO>
    {
        Task<AccountRoninDTO> GetAccountRoninByParams(string ronin);
    }
}
