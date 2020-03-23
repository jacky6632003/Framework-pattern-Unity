using AutoMapper;
using Framework.ParameterModel;
using Framework.Service.InfoModel;
using Framework.Service.ResultModel;
using Framework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Framework.Infrastructure.Mappings
{
    public class ControllerMapperingProfile : Profile
    {
        public ControllerMapperingProfile()
        {
            this.CreateMap<TestParameterModel, TestInfoModel>();
            this.CreateMap<TestResultModel, TestViewModel>();
        }
    }
}