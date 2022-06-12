using AXIE.Models.AccountRonin;
using AXIE.WEBApi.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace AXIE.WEBApi.Services
{
    public class AccountRoninService : IAccountRoninService
    {
        private readonly IConfiguration _config;

        public AccountRoninService(IConfiguration config)
        {
            _config = config;
        }
        public async Task<bool> Add(AccountRoninDTO reqest)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("database")))
            {
                connection.Open();

                string insertQuery = @"INSERT INTO [AXIE].[dbo].[NftAccountRonin]([accountRoninPK],[ronin], [dateOfEntry]) VALUES (@accountRoninPK,@ronin, @dateOfEntry)";

                var result = connection.Execute(insertQuery, new
                {
                    accountRoninPK=Guid.NewGuid(),
                    ronin = reqest.Ronin,
                    dateOfEntry = DateTime.Now
                });

                return true;
            }
        }

        public async Task<AccountRoninDTO> GetAccountRoninByParams(string ronin)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("database")))
            {
                connection.Open();
                return await connection.QueryFirstAsync<AccountRoninDTO>(@$"SELECT [accountRoninPK] AS AccountRoninPK
                                                                                  ,[ronin] AS Ronin
                                                                                  ,[dateOfEntry] AS DateOfEntry
                                                                              FROM [AXIE].[dbo].[NftAccountRonin]
                                                                              WHERE [ronin] = {ronin}");
            }
        }

        public List<AccountRoninDTO> GetAll()
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("database")))
            {
                connection.Open();
                return connection.Query<AccountRoninDTO>(@$"SELECT [accountRoninPK] AS AccountRoninPK
                                                                  ,[ronin] AS Ronin
                                                                  ,[dateOfEntry] AS DateOfEntry
                                                              FROM [AXIE].[dbo].[NftAccountRonin]")
                                 .ToList();
            }
        }

        public async Task<AccountRoninDTO> GetById(Guid id)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("database")))
            {
                connection.Open();

                return await connection.QueryFirstAsync<AccountRoninDTO>(@$"SELECT [accountRoninPK] AS AccountRoninPK
                                                                                  ,[ronin] AS Ronin
                                                                                  ,[dateOfEntry] AS DateOfEntry
                                                                              FROM [AXIE].[dbo].[NftAccountRonin]
                                                                              WHERE [accountRoninPK] = '{id}'");
            }
        }
    }
}
