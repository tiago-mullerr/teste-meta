using System;
using System.Threading.Tasks;
using Api2.Contracts;

namespace Api2.Services
{
    public class CalcInterestRateService : ICalcInterestRateService
    {
        private readonly IInterestRate _interestRateService;
        public CalcInterestRateService(IInterestRate interestRateService)
        {
            _interestRateService = interestRateService;
        }
        public async Task<decimal> CalcInterestRate(decimal initialValue, int time)
        {
            var interestRate = await _interestRateService.ReturnInterestRate();
            var compoundInterest = 1 + (double)interestRate;
            return (decimal)Math.Round((Math.Pow(compoundInterest, time) * (double)initialValue), 2);
        }
    }
}