using System;
using System.Linq;
using Shouldly;
using Xunit;

namespace TDDKata.StringCalculator.Tests
{
    public class AddTests
    {
        [Fact]
        public void ShouldReturnZeroWhenInputsAreEmpty()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(string.Empty);

            result.ShouldBe(0);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("1,5", 6)]
        [InlineData("1,5,10", 16)]
        public void ShouldAddGivenNumbers(string numbers, int expectedResult)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            result.ShouldBe(expectedResult);
        }

    }

    public class StringCalculator
    {
        public int Add(string numbersToAdd)
        {
            return string.IsNullOrEmpty(numbersToAdd) ? 0 : numbersToAdd.Split(",").Sum(Convert.ToInt32);
        }
    }
}
