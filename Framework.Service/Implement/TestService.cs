using AutoMapper;

using Framework.Service.InfoModel;
using Framework.Service.Interface;
using Framework.Service.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Service.Implement
{
    public class TestService : ITestService
    {
        private readonly IMapper _mapper;

        public TestService()
        {
        }

        public async Task<IEnumerable<TestResultModel>> Gettest(TestInfoModel para)
        {
            List<TestResultModel> result = new List<TestResultModel>();

            return result;
        }
    }
}