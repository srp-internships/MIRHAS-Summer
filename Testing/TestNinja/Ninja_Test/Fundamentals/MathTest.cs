using NUnit.Framework;
using System;
using TestNinja.Mocking;

namespace Ninja_Test
{
    [TestFixture]
    class MathTest
    {
        TestNinja.Fundamentals.Math math;

        [SetUp]
        public void SetUp()
        {
            math = new TestNinja.Fundamentals.Math();
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 4, 7)]
        public void TestAdd_HasToAddTwoNumber(int a, int b, int expectedResult)
        {
            var result = math.Add(a, b);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Test_NumbersGotRightly()
        {
            var result = math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 2, 3 }));

            //Assert.That(result, Is.Ordered);
            //Assert.That(result, Is.Unique);
        }

    }
}
