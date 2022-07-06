using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Multiplication : CalculatorOperations
    {
        public Multiplication(double firstNum, double secondNum) : base(firstNum, secondNum)
        {
        }

        public static double MultiplicationMethod(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
    }
}
