using Framework.Repositories.ConditionModel;
using Framework.Repositories.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repositories.Interface
{
    public interface ITestRepository
    {
        Task<IEnumerable<TestDataModel>> GetTest(TestConditionModel para);
    }
}