using AXIE.Models.Account;
using AXIE.WEBApi.Interfaces;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AXIE.WEBApi.Services
{
    public class AccountService : IAccountService
    {
        private readonly IConfiguration _config;

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

        public List<AccountDTO> GetByParametars(AccountSearchDTO request)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("database")))
            {
                connection.Open();

                var quary = @$"SELECT [nftAccountPK] AS NftAccountPK
                                                             ,[userFK] AS UserFK
                                                             ,[accountStatusFK] AS AccountStatusFK
                                                             ,[teamFK] AS TeamFK
                                                             ,[accountRoninFK] AS AccountRoninFK
                                                             ,[dateOfEntry] AS DateOfEntry
                                                             ,[mailAddress] AS EmailAddress
                                                             ,[password] AS Password
                                                             ,[accName] AS AccName
                                                             ,[MMR] AS MMR
                                                         FROM [AXIE].[dbo].[NftAccount]";

                if (!string.IsNullOrWhiteSpace(request.AccName) && !string.IsNullOrWhiteSpace(request.EmailAddress))
                {
                    quary += " WHERE ";

                    if (!string.IsNullOrWhiteSpace(request.AccName))
                        quary += @$"[accName] LIKE '%{request.AccName}%' AND ";

                    if (!string.IsNullOrWhiteSpace(request.EmailAddress))
                        quary += @$"[mailAddress] LIKE '%{request.EmailAddress.PadRight(30)}%'";
                }

                else if (!string.IsNullOrWhiteSpace(request.AccName))
                    quary += @$" WHERE [accName] LIKE '%{request.AccName}%'";

                else if (!string.IsNullOrWhiteSpace(request.EmailAddress))
                    quary += @$" WHERE [mailAddress] LIKE '%{request.EmailAddress}%'";


                return connection.Query<AccountDTO>(quary)
                                 .ToList();
            }
        }

        public async Task<AccountDTO> GetById(Guid id)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("database")))
            {
                connection.Open();

                var quary = @$"SELECT TOP 1 [nftAccountPK] AS NftAccountPK
                                                             ,[userFK] AS UserFK
                                                             ,[accountStatusFK] AS AccountStatusFK
                                                             ,[teamFK] AS TeamFK
                                                             ,[accountRoninFK] AS AccountRoninFK
                                                             ,[dateOfEntry] AS DateOfEntry
                                                             ,[mailAddress] AS EmailAddress
                                                             ,[password] AS Password
                                                             ,[accName] AS AccName
                                                             ,[MMR] AS MMR
                                                         FROM [AXIE].[dbo].[NftAccount]
                                                         WHERE NftAccountPK = '{id}'";

                return (AccountDTO)await connection.QueryFirstAsync<AccountDTO>(quary);
            }
        }

        public Task<bool> Add(AccountDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
