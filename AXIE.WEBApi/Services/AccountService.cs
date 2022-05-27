using AXIE.Model.Account;
using AXIE.WEBApi.Interfaces;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AXIE.WEBApi.Services
{
    public class AccountService : IAccountService
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "DefaultConnection";

        public AccountService(IConfiguration config)
        {
            _config = config;
        }

        public List<AccountDTO> Add()
        {
            throw new NotImplementedException();
        }

        public List<AccountDTO> GetAll()
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("database")))
            {
                connection.Open();
                return connection.Query<AccountDTO>(@$"SELECT [nftAccountPK] AS NftAccountPK
                                                             ,[userFK] AS UserFK
                                                             ,[accountStatusFK] AS AccountStatusFK
                                                             ,[teamFK] AS TeamFK
                                                             ,[accountRoninFK] AS AccountRoninFK
                                                             ,[dateOfEntry] AS DateOfEntry
                                                             ,[mailAddress] AS EmailAddress
                                                             ,[password] AS Password
                                                             ,[accName] AS AccName
                                                             ,[MMR] AS MMR
                                                         FROM [AXIE].[dbo].[NftAccount]")
                                                   .ToList();
            }
        }

        AccountDTO IGlobalService<AccountDTO>.GetById()
        {
            throw new NotImplementedException();
        }
    }
}
