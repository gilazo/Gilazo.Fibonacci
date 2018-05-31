using Xunit;

namespace Gilazo.Fibonacci.Application.Tests
{
    public sealed class AbsoluteNumberTests
    {
        [Fact]
        public void Number_Negative_1_Becomes_1()
        {
            Assert.Equal(1, new AbsoluteNumber(new Number(-1)).Value());
        }

        [Fact]
        public void Number_1_Stays_1()
        {
            Assert.Equal(1, new AbsoluteNumber(new Number(1)).Value());
        }
    }
}