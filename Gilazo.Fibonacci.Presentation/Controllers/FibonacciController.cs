using Microsoft.AspNetCore.Mvc;

namespace Gilazo.Fibonacci.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class FibonacciController : Controller
    {
        private readonly Application _application;

        public FibonacciController()
        {
            _application = new Application();
        }

        [HttpGet]
        public int Get(int number)
        {
            return _application.Fibonacci(number);
        }
    }
}