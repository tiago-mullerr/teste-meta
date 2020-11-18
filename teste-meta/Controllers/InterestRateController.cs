using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    [ApiController]
    [Route("api1/taxajuros")]
    public class InterestRateController : ControllerBase
    {
        [HttpGet()]
        public async Task<decimal> GetInterestRate()
        {
            return await Task.FromResult(0.01M);
        }
    }
}
