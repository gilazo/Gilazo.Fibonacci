using System;
using Xunit;

namespace Gilazo.Fibonacci.Application.Tests
{
    public sealed class FibonacciNumberTests
    {
        [Fact]
        public void Number_Negative_1_Throws_Exception()
        {
            var exception = Assert.Throws<Exception>(() => new FibonacciNumber(new Number(-1)).Value());

            Assert.Equal("Number cannot be negative: -1", exception.Message);
        }

        [Fact]
        public void Number_0_Returns_0()
        {
            Assert.Equal(0, new FibonacciNumber(new Number(0)).Value());
        }

        [Fact]
        public void Number_1_Returns_1()
        {
            Assert.Equal(1, new FibonacciNumber(new Number(1)).Value());
        }

        [Fact]
        public void Number_2_Returns_1()
        {
            Assert.Equal(1, new FibonacciNumber(new Number(2)).Value());
        }

        [Fact]
        public void Number_3_Returns_2()
        {
            Assert.Equal(2, new FibonacciNumber(new Number(3)).Value());
        }

        [Fact]
        public void Number_4_Returns_3()
        {
            Assert.Equal(3, new FibonacciNumber(new Number(4)).Value());
        }

        [Fact]
        public void Number_5_Returns_5()
        {
            Assert.Equal(5, new FibonacciNumber(new Number(5)).Value());
        }

        [Fact]
        public void Number_10_Returns_55()
        {
            Assert.Equal(55, new FibonacciNumber(new Number(10)).Value());
        }
    }
}
