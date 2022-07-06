using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Division : CalculatorOperations
    {
        public Division(double firstNum, double secondNum) : base(firstNum, secondNum)
        {
        }

        public static double DivisionMethod(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
