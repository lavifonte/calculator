using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal abstract class CalculatorOperations
    {
        public double FirstNum { get; set; }
        public double SecondNum { get; set; }

        public CalculatorOperations()
        {
                
        }

        protected CalculatorOperations(double firstNum, double secondNum)
        {
            FirstNum = firstNum;
            SecondNum = secondNum;
        }
    }
}
