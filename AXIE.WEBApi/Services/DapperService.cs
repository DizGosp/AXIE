using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AXIE.WEBApi.Services
{
    public class DapperService
    {
        private readonly IConfiguration _configuration;
        public DapperService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<T> GetAll<T>(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("default"));
            return db.Query<T>(query, sp_params, commandType: commandType).ToList();
        }
        public T execute_sp<T>(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using (IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("database")))
            {
                if (dbConnection.State == ConnectionState.Closed)
                    dbConnection.Open();
                using var transaction = dbConnection.BeginTransaction();
                try
                {
                    dbConnection.Query<T>(query, sp_params, commandType: commandType, transaction: transaction);
                    result = sp_params.Get<T>("retVal"); //get output parameter value
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            };
            return result;
        }
    }
}
