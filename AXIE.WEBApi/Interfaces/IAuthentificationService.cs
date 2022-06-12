using AXIE.Models.AppUsers;

namespace AXIE.WEBApi.Interfaces
{
    public interface IAuthentificationService
    {
        Task<AppUserDTO> Login(AppUserDTO request);
        Task<AppUserDTO> GetUserByUserName(string userName);
        Task<bool> Register(AppUserDTO request);
    }
}
