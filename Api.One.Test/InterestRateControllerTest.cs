using System.Reflection;
using System;
using Xunit;
using Api1.Controllers;

namespace Api1.Test
{
    public class InterestRateControllerTest
    {
        private readonly InterestRateController _controller;

        public InterestRateControllerTest()
        {
            _controller = new InterestRateController();
        }

        [Fact]
        public void GetInterestRateTest()
        {            
            var result = _controller.GetInterestRate().Result;
            Assert.Equal(0.01M, result);
        }
    }
}