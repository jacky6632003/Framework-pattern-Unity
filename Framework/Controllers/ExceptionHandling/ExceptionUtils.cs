using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;

namespace Framework.Controllers.ExceptionHandling
{
    public class ExceptionUtils
    {
        public static ApiResponse ConvertToApiResponse(Object obj)
        {
            var context1 = (obj is HttpActionExecutedContext) ? obj as HttpActionExecutedContext : null;
            var context2 = (obj is ExceptionHandlerContext) ? obj as ExceptionHandlerContext : null;
            var request = (context1 == null) ? context2.Request : context1.Request;
            var exception = (context1 == null) ? context2.Exception : context1.Exception;
            var errorApiResponseResult = new ApiResponse()
            {
                apiVersion = "1.0.0",
                method = string.Format("{0}.{1}",
                                    request.RequestUri.AbsolutePath,
                                    request.Method),
                status = "ERROR",
                id = System.Guid.NewGuid()
            };
            if (exception is ApiException)
            {
                var apiException = exception as ApiException;
                if (apiException.code != null)
                {
                    errorApiResponseResult.error = new
                    {
                        domain = "Framework",
                        code = apiException.code,
                        message = apiException.Message,
                        description = apiException.description
                    };
                }
                else
                {
                    if (apiException.Message == "特定")
                    {
                        errorApiResponseResult.error = new
                        {
                            domain = "Framework",
                            code = "33000",
                            message = "特定錯誤",
                            description = apiException.Message
                        };
                    }
                    else
                    {
                        errorApiResponseResult.error = new
                        {
                            domain = "Framework",
                            code = "33001",
                            message = "未預期的錯誤",
                            description = apiException.Message
                        };
                    }
                }

                //errorApiResponseResult.StatusCode = apiException.StatusCode;
            }
            else
            {
                switch (exception.Message)
                {
                    case "id":
                        errorApiResponseResult.error = new
                        {
                            domain = "Framework",
                            code = "40002",
                            message = "id",
                            description = exception.ToString()
                        };
                        break;

                    default:
                        errorApiResponseResult.error = new
                        {
                            domain = "Framework",
                            code = "40001",
                            message = "未預期的錯誤",
                            description = exception.ToString()
                        };
                        break;
                }
                //errorApiResponseResult.StatusCode = HttpStatusCode.BadRequest;
            }
            return errorApiResponseResult;
        }
    }
}