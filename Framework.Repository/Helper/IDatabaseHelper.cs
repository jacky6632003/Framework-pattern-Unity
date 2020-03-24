using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository.Helper
{
    public interface IDatabaseHelper
    {
        /// <summary>
        /// 連線字串
        /// </summary>
        string SQLConnectionString { get; }

        IDbConnection GetConnection(string connectionString);
    }
}