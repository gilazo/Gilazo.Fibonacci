using System;

namespace Gilazo.Fibonacci.Application
{
    public class FibonacciNumber : INumber
    {
        private readonly int _number;

        public FibonacciNumber(int number)
        {
            _number = number;
        }

        public int Value()
        {
            if (_number < 0)
                throw new Exception($"Number cannot be negative: {_number}");
            
            return Fibonacci(_number);
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
