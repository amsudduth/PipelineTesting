using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUtils;

namespace Pipeline.Test
{
    [TestClass]
    public class CalculatorTest
    {
       private Chance _utils;
       private Calculator _calc;

        [TestInitialize]
        public void BeforeAll()
        {
            _utils = new Chance();
            _calc = new Calculator();
        }

        [TestClass]
        [TestCategory("Addition Testing (ADD())")]
        public class AddingTest : CalculatorTest
        {
            [TestMethod]
            public void ShouldAddTwoInts()
            {
                //Arrange
                int a = _utils.Int(0, 100);
                int b = _utils.Int(0, 100);
                int expectedResult = a + b;
                //Act
                int result = _calc.Add(a, b);
                //Assert

                Assert.AreEqual(expectedResult, result);
            }
        }

        [TestClass]
        [TestCategory("Subtraction Testing (SUB())")]
        public class SubtractingTest : CalculatorTest
        {
            [TestMethod]
            public void ShouldSubtractTwoInts()
            {
                //Arrange
                int a = _utils.Int(0, 100);
                int b = _utils.Int(0, 100);
                int expectedResult = a - b;
                //Act
                int result = _calc.Sub(a, b);
                //Assert

                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}
