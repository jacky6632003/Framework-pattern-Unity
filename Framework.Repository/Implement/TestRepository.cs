using Framework.Repository.DataModel;
using Framework.Repository.Helper;
using Framework.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository.Implement
{
    public class TestRepository : ITestRepository
    {
        public readonly IDatabaseHelper _databaseHelper;

        public TestRepository(IDatabaseHelper databaseHelper)
        {
            this._databaseHelper = databaseHelper;
        }

        public async Task<IEnumerable<TestDataModel>> GetTest()
        {
            // var aaa = _databaseHelper.GetConnection(_databaseHelper.SQLConnectionString);
            List<TestDataModel> result = new List<TestDataModel>();

            result.Add(new TestDataModel
            {
                id = 1,
                name = "aaa"
            });

            return result;
        }
    }
}