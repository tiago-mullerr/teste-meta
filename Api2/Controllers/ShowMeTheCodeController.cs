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
    [Route("api2/Showmethecode")]
    public class ShowmethecodeController : ControllerBase
    {
        [HttpGet]
        public async Task<string> ObterUrl()
        {
            return await Task.FromResult("");
        }
    }
}
