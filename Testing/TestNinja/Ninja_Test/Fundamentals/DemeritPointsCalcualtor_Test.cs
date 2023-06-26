using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace Ninja_Test.Fundamentals
{
    [TestFixture]
    class DemeritPointsCalcualtor_Test
    {
        [Test]
        public void TestDemeritPoints_ThrowExceptionIfNumberLessThenZeroOrGreaterThanMaxSpeed()
        {
            var demeritCalculator = new DemeritPointsCalculator();

            Assert.That(() => demeritCalculator.CalculateDemeritPoints(390), Throws.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() => demeritCalculator.CalculateDemeritPoints(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(60,0)]
        [TestCase(70, 1)]
        public void TestDemeritPoints_ReturnZeroIfSpeedEqualToLimitSpeedAndSomeValueIfItIsGreaterOrEqualToLimitSpeed(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            int result = calculator.CalculateDemeritPoints(speed);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
