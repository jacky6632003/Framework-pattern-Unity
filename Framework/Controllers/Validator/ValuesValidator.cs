using Framework.Infrastructure.Validator;
using Framework.ParameterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Framework.Controllers.Validator
{
    public class ValuesValidator : IValidator
    {
        public async Task<IEnumerable<ValidatorErrorResult>> ValidateAsync(Dictionary<string, object> arg)
        {
            var result = new List<ValidatorErrorResult>();

            var parameter = (ValuesParameterModel)arg["para"];

            if (parameter.name == "jacky")
            {
                result.Add(new ValidatorErrorResult
                {
                    Name = "name",
                    ErrorMessage = "NO jacky"
                });
            }

            return result;
        }
    }
}