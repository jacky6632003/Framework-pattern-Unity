using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repositories.Helper
{
    public interface IDatabaseHelper
    {
        /// <summary>
        /// WLDO連線字串
        /// </summary>
        string SQLConnectionString { get; }

        /// <summary>
        /// MySQL
        /// </summary>
        string MySQLConnectionString { get; }

        IDbConnection GetConnection(string connectionString);

        IDbConnection GetMySQLConnection(string connectionString);
    }
}