using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Calculator
    {
        public double calculateSum(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        public double calculateSub(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }

        public double calculateMult(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        public double calculateDiv(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception();
            }

            return firstValue / secondValue;
        }

    }
}
