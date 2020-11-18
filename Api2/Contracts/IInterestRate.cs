using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api2.Contracts
{
    public interface IInterestRate
    {
        [Get("/api1/taxajuros")]
        Task<decimal> ReturnInterestRate();
    }
}
