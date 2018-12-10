using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sut_test.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SutController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<string>> WaitXMsReturnYStrings(int X, int Y)
        {
            await Task.Delay(X);

            var listOfStrings = new List<string>(Y);

            for (var i = 0; i < Y; ++i)
            {
                listOfStrings.Add($"Value-{i}");
            }

            return listOfStrings;
        }

        [HttpGet]
        public async Task<ObjectResult> WaitXMsGiveAnError(int X, int E, string M = "An error occured")
        {
            await Task.Delay(X);

            return StatusCode(E, M);
        }
    }
}
