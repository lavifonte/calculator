using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Subtract : CalculatorOperations
    {
        public Subtract(double firstNum, double secondNum) : base(firstNum, secondNum)
        {
        }

        public static double SubtractMethod(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
    }
}
