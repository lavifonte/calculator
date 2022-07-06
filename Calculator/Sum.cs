namespace Calculator
{
    internal class Sum : CalculatorOperations
    {
        public Sum(double firstNum, double secondNum) : base(firstNum, secondNum)
        {
        }

        public static double SumMethod(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

    }
}
