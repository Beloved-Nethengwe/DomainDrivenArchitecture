using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;

namespace Fundamentals_of_Programming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringGenerateController : ControllerBase
    {
        private readonly IReverseString _reverseString;

        public ReverseStringGenerateController(IReverseString reverseString)
        {
            _reverseString = reverseString;
        }

        [HttpGet]
        [Route("reversed/{input}")]
        public string GenerateReversedString(string input)
        {
            return _reverseString.ReverseString(input);
        }

    }
}
