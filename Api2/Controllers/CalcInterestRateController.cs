using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api2.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api2.Controllers
{
    [ApiController]
    [Route("api2/calculajuros")]
    public class CalcInterestRateController : ControllerBase
    {

        private readonly ICalcInterestRateService _serviceCalcInterestRate;
        public CalcInterestRateController(ICalcInterestRateService service)
        {
            _serviceCalcInterestRate = service;
        }
        [HttpGet]
        public async Task<decimal> InterestCalc(decimal initialValue, int time)
        {
            return await _serviceCalcInterestRate.CalcInterestRate(initialValue, time);
        }
    }
}
