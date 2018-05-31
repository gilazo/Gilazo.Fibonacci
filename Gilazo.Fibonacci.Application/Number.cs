using System;

namespace Gilazo.Fibonacci.Application
{
    public sealed class Number : INumber
    {
        private readonly int _number;

        public Number(int number)
        {
            _number = number;
        }

        public int Value()
        {
            return _number;
        }
    }
}