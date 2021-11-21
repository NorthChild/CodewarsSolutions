using NUnit.Framework;
using CodeWarsSolutions;
using CodeWarsSolutions.Interfaces;
using CodeWarsSolutions.Objects;

namespace CodeWarsSolutionsTests
{
    public class TestsI
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [TestCase(80, 1.80, "Normal")]
        [TestCase(180, 1.80, "Obese")]
        [TestCase(5, 1.80, "Underweight")]
        [TestCase(50, 1.40, "Overweight")]
        public void BMISolutionTests(double weight, double height, string evaluation)
        {
            BMICalculator bmiCalc = new BMICalculator();
            var test = bmiCalc.BMIValue(weight, height);

            Assert.That(test, Is.EqualTo(evaluation));
        }




    }
}