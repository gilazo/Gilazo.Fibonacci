using Xunit;

namespace Gilazo.Fibonacci.Application.Tests
{
    public class AbsoluteNumberTests
    {
        [Fact]
        public void Number_Negative_1_Becomes_1()
        {
            Assert.Equal(1, new AbsoluteNumber(-1).Value());
        }

        [Fact]
        public void Number_1_Stays_1()
        {
            Assert.Equal(1, new AbsoluteNumber(1).Value());
        }
    }
}