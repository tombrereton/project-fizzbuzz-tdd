using NUnit.Framework;

namespace FizzBuzzCalcaulatorTests
{
    public class FizzBuzzCalculatorShould
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(45, "FizzBuzz")]
        [TestCase(89, "89")]
        [TestCase(75, "FizzBuzz")]
        [TestCase(99, "Fizz")]
        public void CalcultateIfNumberShouldBeFizzOrBuzzOrFizzBuzz(int number, string expectedFizzBuzz)
        {
            var actualFizzBuzz = FizzBuzzCalculator.FizzBuzz.Convert(number);

            Assert.That(actualFizzBuzz, Is.EqualTo(expectedFizzBuzz));
        }
    }
}