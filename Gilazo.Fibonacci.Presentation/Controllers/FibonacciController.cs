using Microsoft.AspNetCore.Mvc;

namespace Gilazo.Fibonacci.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
        [HttpGet]
        public int Get(int number)
        {
            return new Application().Create(number);
        }
    }
}