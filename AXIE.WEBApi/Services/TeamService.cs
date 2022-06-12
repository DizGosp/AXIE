using AXIE.Models.Team;
using AXIE.WEBApi.Interfaces;

namespace AXIE.WEBApi.Services
{
    public class TeamService : ITeamService
    {
        public Task<bool> Add(TeamDTO request)
        {
            throw new NotImplementedException();
        }

        public List<TeamDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TeamDTO> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
