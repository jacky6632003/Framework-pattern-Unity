using Framework.Controllers.Validator;
using Framework.Infrastructure.Validator;
using Framework.ParameterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Framework.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [ValidatorAttribute(typeof(ValuesValidator))]
        public async Task<bool> Post([FromBody]ValuesParameterModel para)
        {
            return true;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            var aa = "5555";
            var api = new ApiException("特定");
            api.code = "10001";
            api.description = "特定";
            throw api;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            throw new Exception("id");
        }
    }
}