﻿using Framework.Controllers.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Framework.ActionFilter
{
    public class ApiExceptionResponseAttribute : ExceptionFilterAttribute
    {
        //OnActionExecuting – 在執行 Action 之前執行
        //OnActionExecuted – 在執行 Action 之後執行
        //OnResultExecuting – 在執行 Action Result 之前執行
        //OnResultExecuted – 在執行 Action Result 之後執行

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnException(actionExecutedContext);

            // 將錯誤訊息轉成要回傳的ApiResponseResult
            //var errorApiResponseResult = exceptionToApiResponse(actionExecutedContext);
            var errorApiResponseResult = ExceptionUtils.ConvertToApiResponse(actionExecutedContext);
            // 重新打包回傳的訊息
            //actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(errorApiResponseResult.StatusCode , errorApiResponseResult);
            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse((HttpStatusCode)200, errorApiResponseResult);
        }
    }
}

public class ApiResponseSuccess
{
    public Guid id { get; set; }
    public string apiVersion { get; set; }
    public string method { get; set; }
    public string status { get; set; }
    public object data { get; set; }
}

public class ApiResponse
{
    public Guid id { get; set; }
    public string apiVersion { get; set; }
    public string method { get; set; }
    public string status { get; set; }
    public object data { get; set; }

    public object error { get; set; }
    //public HttpStatusCode StatusCode { get; set; }
}

public class ApiException : Exception
{
    public string code { get; set; }
    public string description { get; set; }
    public string domain { get; set; }

    //public HttpStatusCode StatusCode { get; set; }

    public ApiException()
        : this("API呼叫錯誤")
    {
    }

    public ApiException(string errorMessage)
        : base(errorMessage)
    {
        //StatusCode = HttpStatusCode.BadRequest;
    }
}