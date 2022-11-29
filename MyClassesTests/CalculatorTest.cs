using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [Owner("Douglas")]
        [DataRow(10.0, 5.0, 5.0)]
        [DataRow(13.0, 5.0, 8.0)]
        [DataRow(24.0, 12.00, 12.0)]
        [DataRow(-5.0, 5.0, -10.0)]
        public void sumValuesTest(double expectedValue, double firstValue, double secondValue)
        {
            //Triple A

            //Arange 
            Calculator calc = new Calculator();
            double value;

            //Action 
            value = calc.calculateSum(firstValue, secondValue);

            //Assert
            Assert.AreEqual(expectedValue, value);

        }

    }
}
