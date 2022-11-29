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
        public void calculateSumTest(double expectedValue, double firstValue, double secondValue)
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

        [TestMethod]
        [Owner("Douglas")]
        [DataRow(0, 10.0, 10.0)]
        [DataRow(10.0, 20.0, 10.0)]
        public void calculateSubTest(double expectedValue, double firstValue, double secondValue)
        {
            //Arange  
            Calculator calc = new Calculator();
            double value;

            //Action 
            value = calc.calculateSub(firstValue, secondValue);

            //Assert 
            Assert.AreEqual(expectedValue, value);
        }

        [TestMethod]
        [Owner("Douglas")]
        [DataRow(4.0, 2.0, 2.0)]
        [DataRow(25.0, 5.0, 5.0)]
        [DataRow(16.0, 4.0, 4.0)]
        public void calculateMultTest(double expectedValue, double firstValue, double secondValue)
        {
            //Arange 
            Calculator calc = new Calculator();
            double value;

            //Action 
            value = calc.calculateMult(firstValue, secondValue);

            //Assert 
            Assert.AreEqual(expectedValue, value);
        }

        [TestMethod]
        [Owner("Douglas")]
        [TestCategory("Exception")]
        [DataRow(10, 20, 0)]
        public void calculateDivTest_ThrowsArgumentNullException_UsingTryCatch(double expectedValue, double firstValue, double secondValue)
        {
            try
            {
                //Arange 
                Calculator calc = new Calculator();
                double value;

                //Action 
                value = calc.calculateDiv(firstValue, secondValue);
            } 
            catch (ArgumentException)
            {
                //Isso foi um sucesso!
                return;
            }

            //Assert 
            Assert.Fail("Fail expected");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        [Owner("Douglas")]
        [Priority(0)]
        [TestCategory("Exception")]
        [DataRow(10, 20, 0)]
        public void calculateDivTest_ThrowsArgumentNullException(double expectedValue, double firstValue, double secondValue)
        {
            //Exception Handling

            //Arange 
            Calculator calc = new Calculator();
            double value;

            //Action 
            value = calc.calculateDiv(firstValue, secondValue);
        }

    }
}
