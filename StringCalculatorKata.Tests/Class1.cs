namespace StringCalculatorKata.Tests
{
    using NUnit.Framework;
    using FluentAssertions;
    using Source;

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
        [TestCase("3", 3)]
        [TestCase("99", 99)]
        public void ReturnNumber_WhenAdding_GivenOneDigit(string toAdd, int expectedResult)
        {
            var stringCalculatorService = new StringCalculatorService();

            var result = stringCalculatorService.Add(toAdd);

            result.Should().Be(expectedResult);
        }

        [TestCase("2,3", 5)]
        [TestCase("2,100", 102)]
        [TestCase("2,101", 103)]
        public void ReturnNumber_WhenAdding_GivenTwoDigits(string toAdd, int expectedResult)
        {
            new StringCalculatorService()
                .Add(toAdd)
                .Should().Be(expectedResult);
        }
    }
}