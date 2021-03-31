using jenkinsTestProject.Models;
using NUnit.Framework;

namespace sampleTest
{
    public class Tests
    {
        public CalculationService calculationService { get; set; }
        [SetUp]
        public void Setup()
        {
            calculationService = new CalculationService();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void CalculationTest()
        {
            int number1 = 5;
            int number2 = 4;
            int expectedResult = 9;

            var result = calculationService.sum(number1, number2);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void CalculationFailTest()
        {
            int number1 = 3;
            int number2 = 0;
            int expectedResult = 3;

            var result = calculationService.sum(number1, number2);
            Assert.AreEqual(result, expectedResult);
        }
    }
}