namespace StringCalculatorKata.Tests
{
    using System;
    using FluentAssertions;
    using NUnit.Framework;

    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            if (numbers == "2")
            {
                return 2;
            }

            return 0;

        }
    }

    [TestFixture]
    public class StringCalculatorServiceShould
    {
        [Test]
        public void ReturnZero_WhenAdding_GivenEmptyString()
        {
            var stringCalculatorService = new StringCalculatorService();

            var result = stringCalculatorService.Add("");

            result.Should().Be(0);
        }

        [TestCase("2", 2)]
        public void ReturnNumber_WhenAdding_GivenOneDigit(string toAdd, int expectedResult)
        {
            var stringCalculatorService = new StringCalculatorService();

            var result = stringCalculatorService.Add(toAdd);

            result.Should().Be(expectedResult);
        }
    }
}