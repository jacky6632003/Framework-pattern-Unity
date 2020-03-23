using AutoMapper;
using Framework.ParameterModel;
using Framework.Service.InfoModel;
using Framework.Service.Interface;
using Framework.Service.ResultModel;
using Framework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Framework.Controllers
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        private readonly ITestService _testService;
        private readonly IMapper _mapper;

        public TestController(ITestService testService, IMapper mapper)
        {
            this._testService = testService;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("GetTest")]
        public async Task<IEnumerable<TestViewModel>> GetTest([FromUri] TestParameterModel para)
        {
            var infoDto = this._mapper.Map<TestParameterModel, TestInfoModel>(para);
            var date = await this._testService.Gettest(infoDto);

            var result = this._mapper.Map<IEnumerable<TestResultModel>, IEnumerable<TestViewModel>>(date);

            return result;
        }
    }
}