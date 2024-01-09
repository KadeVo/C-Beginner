using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTest;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {

            Calculator calculator = new Calculator();
            double num1 = 2.5, num2 = 3.7;

            // Act
            double result = num1 + num2;

            // Assert
            Assert.AreEqual(6.2, result);
        }

    
    }
}