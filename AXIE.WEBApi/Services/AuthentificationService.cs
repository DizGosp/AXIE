using AXIE.Models.AppUsers;
using AXIE.WEBApi.Interfaces;
using Dapper;
using Microsoft.AspNetCore.Identity;
using NPOI.SS.Formula.Functions;
using System.Data.SqlClient;

namespace AXIE.WEBApi.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IConfiguration _config;
        private readonly IPasswordHasher<AppUserDTO> _passwordHasher;
        public AuthentificationService(IConfiguration config, IPasswordHasher<AppUserDTO> passwordHasher)
        {
            _config = config;
            _passwordHasher = passwordHasher;
        }

        public async Task<AppUserDTO> GetUserByUserName(string userName)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("database")))
            {
                connection.Open();

                var quary = @$"SELECT TOP 1  [AppUserPK]
                                            ,[UserName]
                                            ,[Password]
                                            ,[RoleFK]
                                            ,[FirstName]
                                            ,[LastName]
                                            ,[CreatedOn]
	                                        ,[RoleName]
                               FROM [AXIE].[dbo].[AppUsers] AS a 
                               JOIN [AXIE].[dbo].[AppUserRoles] AS r 
                               ON a.RoleFK = r.RolePK
                               WHERE [UserName]={userName}";

                return await connection.QueryFirstAsync<AppUserDTO>(quary);
            }
        }

        public async Task<AppUserDTO> Login(AppUserDTO request)
        {
            AppUserDTO appUser = await GetUserByUserName(request.UserName);

            var passwordHasher = _passwordHasher.VerifyHashedPassword(request, appUser.Password,request.Password);
            if (passwordHasher == PasswordVerificationResult.Success)
                return appUser;

           return null;
        }

        public async Task<bool> Register(AppUserDTO request)
        {
            var user = await GetUserByUserName(request.UserName);

            if (user == null)
            {
                string hashedPassword = _passwordHasher.HashPassword(request, request.Password);

                using (var connection = new SqlConnection(_config.GetConnectionString("database")))
                {
                    connection.Open();

                    string insertQuery = @"INSERT INTO [dbo].[AppUserPK]([FirstName], [LastName], [UserName], [Password], [RoleFK], [CreatedOn]) VALUES (@FirstName, @LastName, @UserName, @Password, @RoleFK, @CreatedOn)";

                    var result = connection.Execute(insertQuery, new
                    {
                        request.FirstName,
                        request.LastName,
                        request.UserName,
                        request.Password,
                        request.RoleFK,
                        CreatedOn = DateTime.Now
                    });

                    return true;
                }
            }
            return false;
        }
    }
}
