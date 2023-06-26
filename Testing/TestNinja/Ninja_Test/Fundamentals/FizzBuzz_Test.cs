using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Ninja_Test.Fundamentals
{
    [TestFixture]
    class FizzBuzz_Test
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(2, "2")]
        public void TestFizzBuzz_Number_ReturnFizzBazzOrFizzOrBazzAccordingToTheValue(int number, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
