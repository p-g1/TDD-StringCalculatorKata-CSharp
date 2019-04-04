namespace StringCalculatorKata.Tests
{
    using System;
    using FluentAssertions;
    using NUnit.Framework;

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

    }

    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            return 0;
        }
    }
}