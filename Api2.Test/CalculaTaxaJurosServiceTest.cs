using System.Threading.Tasks;
using Xunit;
using Api2.Contracts;
using Moq;
using Api2.Services;

namespace ApiTwo.Test
{
    public class CalcInterestRateServiceTest
    {
        private readonly Mock<IInterestRate> _mockInterestRate;
        private readonly ICalcInterestRateService _service;
        
        public CalcInterestRateServiceTest()
        {
            _mockInterestRate = new Mock<IInterestRate>();
            _mockInterestRate.Setup(x => x.ReturnInterestRate()).Returns(Task.FromResult<decimal>(0.01M));
            _service = new CalcInterestRateService(_mockInterestRate.Object);
        }

        [Theory]
        [InlineData(100.00, 5)]
        public async Task InterestCalcTest(decimal initalValue, int time)
        {
            var result = await _service.CalcInterestRate(initalValue, time);
            Assert.Equal(105.10M, result);
        }
    }
}
