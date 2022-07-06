using System.Globalization;

namespace Calculator
{
    internal class Screen
    {

        public static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Hey! What would you like to do today? Pick a number (:");
            Console.WriteLine();
            Console.WriteLine("#1: sum");
            Console.WriteLine("#2: subtract");
            Console.WriteLine("#3: divide");
            Console.WriteLine("#4: multiply");
            Console.WriteLine("#5: exit");
            Console.WriteLine();

            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1: PrintSum(); break;
                case 2: PrintSubtract(); break;
                case 3: PrintDivision(); break;
                case 4: PrintMultiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }
        public static void PrintSum()
        {
            Console.Clear();
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double result = Sum.SumMethod(firstNum, secondNum);
            Console.WriteLine($"Nice! Your result is: {result.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine("Press enter to return to menu.");
            Console.ReadKey();
            Menu();
        }

        public static void PrintSubtract()
        {
            Console.Clear();
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double result = Subtract.SubtractMethod(firstNum, secondNum);
            Console.WriteLine($"Nice! Your result is: {result.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Press enter to return to menu.");
            Console.ReadKey();
            Menu();
        }

        public static void PrintDivision()
        {
            Console.Clear();
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double result = Division.DivisionMethod(firstNum, secondNum);
            Console.WriteLine($"Nice! Your result is: {result.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Press enter to return to menu.");
            Console.ReadKey();
            Menu();
        }

        public static void PrintMultiplication()
        {
            Console.Clear();
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double result = Multiplication.MultiplicationMethod(firstNum, secondNum);
            Console.WriteLine($"Nice! Your result is: {result.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Press enter to return to menu.");
            Console.ReadKey();
            Menu();
        }
    }
}
