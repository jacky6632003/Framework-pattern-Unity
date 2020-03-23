using Framework.Service.InfoModel;
using Framework.Service.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Service.Interface
{
    public interface ITestService
    {
        Task<IEnumerable<TestResultModel>> Gettest(TestInfoModel para);
    }
}