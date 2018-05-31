using System;
using Gilazo.Fibonacci.Application;

namespace Gilazo.Fibonacci.Presentation
{
    internal sealed class Application
    {
        public int Fibonacci(int number)
        {
            return new FibonacciNumber(
                new LoggedNumber(
                    new AbsoluteNumber(
                        new LoggedNumber(
                            new Number(number)
                            , num => Console.WriteLine($"Number is: {num}")
                        )
                    )
                    , num => Console.WriteLine($"Absolute number is: {num}")
                )
            ).Value();
        }
    }
}
