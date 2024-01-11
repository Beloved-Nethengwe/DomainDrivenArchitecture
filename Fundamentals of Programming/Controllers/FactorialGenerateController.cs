using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Fundamentals_of_Programming.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FactorialGenerateController : ControllerBase
    {
        private readonly IFactorial _factorial;

        public FactorialGenerateController(IFactorial factorial)
        {
            _factorial = factorial;
        }

        [HttpGet]
        [Route("{num}")]
        public int GenerateFactorial(int num)
        {
            return _factorial.GetFactorial(num);
        }
    }
}
