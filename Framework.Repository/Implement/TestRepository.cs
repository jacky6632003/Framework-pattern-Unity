using Framework.Repository.DataModel;
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
        public async Task<IEnumerable<TestDataModel>> GetTest()
        {
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