using Dapper;
using Framework.Repositories.ConditionModel;
using Framework.Repositories.DataModel;
using Framework.Repositories.Helper;
using Framework.Repositories.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repositories.Implement
{
    public class TestRepository : ITestRepository
    {
        public TestRepository(IDatabaseHelper databaseHelper)
        {
        }

        public async Task<IEnumerable<TestDataModel>> GetTest(TestConditionModel para)
        {
            //using (MySqlConnection conn = (_databaseHelper.GetMySQLConnection(_databaseHelper.MySQLConnectionString)) as MySqlConnection)
            //{
            //    var result2 = await conn.QueryAsync<TestDataModel>(GetTestSQL());
            //}

            List<TestDataModel> result = new List<TestDataModel>();
            result.Add(new TestDataModel { id = 1, name = "aaaa" });
            result.Add(new TestDataModel { id = 2, name = "aaAAAaa" });
            return result;
        }

        private string GetTestSQL()
        {
            string sql = $@"
SELECT * FROM test.test
";
            return sql;
        }
    }
}