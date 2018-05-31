using System;

namespace Gilazo.Fibonacci.Application
{
    public sealed class FibonacciNumber : INumber
    {
        private readonly INumber _number;

        public FibonacciNumber(INumber number)
        {
            _number = number;
        }

        public int Value()
        {
            var number = _number.Value();
            if (number < 0)
                throw new Exception($"Number cannot be negative: {number}");
            
            return Fibonacci(number);
        }

        public int Fibonacci(int number)
        {
            if (number == 0)
                return 0;

            if (number == 1)
                return 1;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
