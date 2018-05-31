using System;

namespace Gilazo.Fibonacci.Application
{
    public sealed class LoggedNumber : INumber
    {
        private readonly INumber _number;
        private readonly Action<int> _log;

        public LoggedNumber(INumber number, Action<int> log)
        {
            _number = number;
            _log = log;
        }

        public int Value()
        {
            var number = _number.Value();
            _log(number);

            return number;
        }
    }
}