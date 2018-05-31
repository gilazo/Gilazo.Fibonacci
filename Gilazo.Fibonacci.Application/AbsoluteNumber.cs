using System;

namespace Gilazo.Fibonacci.Application
{
    public class AbsoluteNumber : INumber
    {
        private readonly int _number;
        
        public AbsoluteNumber(int number)
        {
            _number = number;
        }

        public int Value() => Math.Abs(_number);
    }
}