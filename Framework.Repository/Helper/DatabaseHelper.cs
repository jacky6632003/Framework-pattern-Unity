using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository.Helper
{
    public class DatabaseHelper : IDatabaseHelper
    {
        public DatabaseHelper(string SQLConnectionString)
        {
            this.SQLConnectionString = SQLConnectionString;
        }

        /// <summary>
        ///WLDO連線字串
        /// </summary>
        public string SQLConnectionString { get; }

        public IDbConnection GetConnection(string connectionString)
        {
            var conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}