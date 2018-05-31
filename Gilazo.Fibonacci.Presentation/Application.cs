using System;
using Gilazo.Fibonacci.Application;

namespace Gilazo.Fibonacci.Presentation
{
    internal sealed class Application
    {
        public int Create(int number)
        {
            return new FibonacciNumber(
                new AbsoluteNumber(
                    new LoggedNumber(
                        new Number(number)
                    )
                )
            ).Value();
        }
    }
}
