using System.Threading.Tasks;

namespace Api2.Contracts
{
    public interface ICalcInterestRateService
    {
        Task<decimal> CalcInterestRate(decimal initialValue, int time);
    }
}