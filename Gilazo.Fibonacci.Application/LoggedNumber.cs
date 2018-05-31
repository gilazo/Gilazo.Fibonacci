using System;

namespace Gilazo.Fibonacci.Application
{
    public sealed class LoggedNumber : INumber
    {
        private readonly INumber _number;

        public LoggedNumber(INumber number)
        {
            _number = number;
        }

        public int Value()
        {
            var number = _number.Value();
            Console.WriteLine($"Number is {number}");

            return number;
        }
    }
}