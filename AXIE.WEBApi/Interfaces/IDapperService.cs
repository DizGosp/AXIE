using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AXIE.WEBApi.Interfaces
{
    public interface IDapperService
    {
        T execute_sp<T>(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string query, DynamicParameters sp_params, CommandType commandType = CommandType.StoredProcedure);
    }
}
