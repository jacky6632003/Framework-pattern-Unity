using AutoMapper;
using Framework.Repository.DataModel;
using Framework.Repository.Interface;
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

        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository, IMapper mapper)
        {
            this._testRepository = testRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<TestResultModel>> Gettest(TestInfoModel para)
        {
            var data = await this._testRepository.GetTest();
            var result = _mapper.Map<IEnumerable<TestDataModel>, IEnumerable<TestResultModel>>(data);

            return result;
        }
    }
}