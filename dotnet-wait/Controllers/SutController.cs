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
        public IEnumerable<string> WaitXMsReturnYStrings(int X, int Y)
        {
            Task.Delay(X).Wait();

            var listOfStrings = new List<string>(Y);

            for (var i = 0; i < Y; ++i)
            {
                listOfStrings.Add($"Value-{i}");
            }

            return listOfStrings;
        }

        [HttpGet]
        public ObjectResult WaitXMsGiveAnError(int X, int E, string M = "An error occured")
        {
            Task.Delay(X).Wait();

            return StatusCode(E, M);
        }
    }
}
