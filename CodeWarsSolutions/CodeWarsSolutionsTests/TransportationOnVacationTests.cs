using NUnit.Framework;
using CodeWarsSolutions;
using CodeWarsSolutions.Interfaces;
using CodeWarsSolutions.Objects;

namespace CodeWarsSolutionsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void TestingThatWhenGivenValueToRentalCarCostFuncItReturnsCorrectValues()
        {

            RentalCalculator calcu = new RentalCalculator();

            var test = calcu.TotalPriceAfterDiscount(1);
            var testI = calcu.TotalPriceAfterDiscount(3);
            var testII = calcu.TotalPriceAfterDiscount(7);

            Assert.That(test, Is.EqualTo(40));
            Assert.That(testI, Is.EqualTo(100));
            Assert.That(testII, Is.EqualTo(230));
        }

        [Test]
        public void TestingThatWhenGivenBounderiesValuesToRentalCarCostFuncItReturnsCorrectValues()
        {

            RentalCalculator calcu = new RentalCalculator();

            var test = calcu.TotalPriceAfterDiscount(2);
            var testI = calcu.TotalPriceAfterDiscount(3);
            var testII = calcu.TotalPriceAfterDiscount(6);
            var testIII = calcu.TotalPriceAfterDiscount(7);

            Assert.That(test, Is.EqualTo(80));
            Assert.That(testI, Is.EqualTo(100));
            Assert.That(testII, Is.EqualTo(220));
            Assert.That(testIII, Is.EqualTo(230));
        }



    }
}