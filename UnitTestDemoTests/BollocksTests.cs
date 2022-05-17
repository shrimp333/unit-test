using System;
using Xunit;
using UnitTestDemo;

namespace UnitTestDemoTests
{
    public class BollocksTests
    {
        [Fact]
        public void ConstructorTest()
        {
            Bollocks b = new Bollocks(5, "bollocks1");

            Assert.Equal(5, b.bollNum);
            Assert.Equal("bollocks1", b.bollString);
        }

        [Theory]
        [InlineData(5, 5, 10)]
        public void AddToTest(int input,int bollocks, int expected)
        {
            Bollocks b = new Bollocks(bollocks, "bollocks1");
            Assert.Equal(expected , b.AddTo(input));
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(2, 2, 1)]
        [InlineData(10, 3, 3)]
        public void DivByTest(int input, int divisor, int expected)
        {
            Bollocks b = new Bollocks(input, "bollocks2");
            int result = b.DivBy(divisor);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void DivBy_Zero_Test()
        {
            Bollocks b = new Bollocks(0, "bollocks1");
            try
            {
                b.DivBy(0);
                Assert.True(false);
            }
            catch
            {
                Assert.True(true);
            }
        }

        [Theory]
        [InlineData(11, 2, 1)]
        public void ModOfDivByTest(int input, int mod, int expected)
        {
            Bollocks b = new Bollocks(input, "bollocks1");
            Assert.Equal(expected, b.ModOfDivBy(mod));
        }
    }
}
