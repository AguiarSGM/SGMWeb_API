using Oracle.ManagedDataAccess.Client;
using PortalBusiness.Shared;

namespace PortalBusiness.Infrastructure.Data.DataBase;

public class DapperConfiguration
{
    public static OracleConnection GetSqlConnection()
    {
        return new OracleConnection(Runtime.ConnectionString);
    }
}
