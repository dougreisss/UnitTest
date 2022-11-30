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
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("NoException")]
        [Description("Verificar valores de soma")]
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
            double result;

            //Action 
            result = calc.calculateSum(firstValue, secondValue);
            TestContext.WriteLine($"Expected value: {expectedValue}");
            TestContext.WriteLine($"{firstValue} + {secondValue} = {result}");

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [TestCategory("NoException")]
        [Description("Verificar valores de subtração")]
        [Owner("Douglas")]
        [DataRow(0, 10.0, 10.0)]
        [DataRow(10.0, 20.0, 10.0)]
        public void calculateSubTest(double expectedValue, double firstValue, double secondValue)
        {
            //Arange  
            Calculator calc = new Calculator();
            double result;

            //Action 
            result = calc.calculateSub(firstValue, secondValue);
            TestContext.WriteLine($"Expected value: {expectedValue}");
            TestContext.WriteLine($"{firstValue} - {secondValue} = {result}");

            //Assert 
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [Owner("Douglas")]
        [TestCategory("NoException")]
        [Description("Verificar valores de multiplicação")]
        [DataRow(4.0, 2.0, 2.0)]
        [DataRow(25.0, 5.0, 5.0)]
        [DataRow(16.0, 4.0, 4.0)]
        public void calculateMultTest(double expectedValue, double firstValue, double secondValue)
        {
            //Arange 
            Calculator calc = new Calculator();
            double result;

            //Action 
            result = calc.calculateMult(firstValue, secondValue);
            TestContext.WriteLine($"Expected value: {expectedValue}");
            TestContext.WriteLine($"{firstValue} * {secondValue} = {result}");

            //Assert 
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [Owner("Douglas")]
        [Description("Verificar valores de divisão que não são iguais")]
        [TestCategory("NoException")]
        [DataRow(10, 20, 3)]
        [DataRow(25, 50, 5)]
        [DataRow(12, 24, 1)]
        public void calculateDiv_AreNotEqual(double expectedValue, double firstValue, double secondValue)
        {
            // Arange
            Calculator calc = new Calculator();
            double result;

            // Action
            result = calc.calculateDiv(firstValue, secondValue);
            TestContext.WriteLine($"Expected value: {expectedValue}");
            TestContext.WriteLine($"{firstValue} / {secondValue} = {result}");

            // Assert
            Assert.AreNotEqual(expectedValue, result);
        }


        [TestMethod]
        [Owner("Douglas")]
        [Description("Verificar valores de divisão que geram exceptions")]
        [TestCategory("Exception")]
        [DataRow(10, 20, 0)]
        public void calculateDivTest_ThrowsException_UsingTryCatch(double expectedValue, double firstValue, double secondValue)
        {
            try
            {
                //Arange 
                Calculator calc = new Calculator();
                double result;

                //Action 
                result = calc.calculateDiv(firstValue, secondValue);
                TestContext.WriteLine($"Expected value: {expectedValue}");
                TestContext.WriteLine($"{firstValue} / {secondValue} = {result}");
                 
            } 
            catch (Exception)
            {
                //Isso foi um sucesso!
                return;
            }

            //Assert 
            Assert.Fail("Fail expected");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        [Owner("Douglas")]
        [Priority(0)]
        [TestCategory("Exception")]
        [DataRow(10, 20, 0)]
        public void calculateDivTest_ThrowsArgumentNullException(double expectedValue, double firstValue, double secondValue)
        {
            //Exception Handling

            //Arange 
            Calculator calc = new Calculator();
            double result;

            //Action 
            result = calc.calculateDiv(firstValue, secondValue);
        }

    }
}
