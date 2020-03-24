using Framework.Repository.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Repository.Interface
{
    public interface ITestRepository
    {
        Task<IEnumerable<TestDataModel>> GetTest();
    }
}