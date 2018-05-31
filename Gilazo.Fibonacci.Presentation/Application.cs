using System;
using Gilazo.Fibonacci.Application;

namespace Gilazo.Fibonacci.Presentation
{
    internal class Application
    {
        public int Create(int number)
        {
            return new FibonacciNumber(
                new AbsoluteNumber(number)
            ).Value();
        }
    }
}
