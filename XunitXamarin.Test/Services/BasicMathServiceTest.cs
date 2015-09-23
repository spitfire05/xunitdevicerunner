using Xunit;
using XunitXamarin.Services;

namespace XunitXamarin.Test.Services
{
    public class BasicMathServiceTest
    {
        private BasicMathService _basicMathService;

        public BasicMathServiceTest()
        {
            _basicMathService = new BasicMathService();
        }

        [Fact]
        public void Add_GivenTwoNumbers_TheSumIsReturned()
        {
            var x = 35;
            var y = 7;
            var expectedResult = 42;

            var result = _basicMathService.Add(x, y);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Subtract_GivenTwoNumbers_TheSubtractedResultIsReturned()
        {
            var x = 456;
            var y = 123;
            var expectedResult = 333;

            var result = _basicMathService.Subtract(x, y);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Mulitply_GivenTwoNumbers_TheResultIsReturned()
        {
            var x = 2;
            var y = 2;
            var expectedResult = 4;

            var result = _basicMathService.Multiply(x, y);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Divide_GivenTwoNumbers_TheSumIsReturned()
        {
            var x = 848;
            var y = 8;
            var expectedResult = 106;

            var result = _basicMathService.Divide(x, y);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TheFailingTest()
        {
            var x = 4;
            var y = 2;
            var expectedResult = 8;

            var result = _basicMathService.Add(x, y);

            Assert.Equal(expectedResult, result);
        }
    }
}
