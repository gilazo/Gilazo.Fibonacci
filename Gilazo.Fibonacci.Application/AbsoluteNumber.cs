using System;

namespace Gilazo.Fibonacci.Application
{
    public sealed class AbsoluteNumber : INumber
    {
        private readonly INumber _number;
        
        public AbsoluteNumber(INumber number)
        {
            _number = number;
        }

        public int Value() => Math.Abs(_number.Value());
    }
}