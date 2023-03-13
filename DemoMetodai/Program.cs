using System;

namespace DemoMetodai
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Pasisveikinimas();
            Console.WriteLine();

            // Statiniai metodai
            Console.WriteLine(Calculator.Sum(5, 5));
            Console.WriteLine(Calculator.Sum(2, 5));
            Console.WriteLine(Calculator.Sum(10, 5));
            Console.WriteLine(Calculator.Sum(100000000, 5));

            // Nestatiniai metodai
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Difference(10, 5));
            Console.WriteLine();

            Calculator.DivisionByTwoUntilZero(10);
            Console.WriteLine();

            Calculator.DivisionByTwoUntilZero(1000);
            Console.WriteLine();
        }

        internal static void Pasisveikinimas()
        {
            Console.WriteLine("Hello World!!!!");
        }
    }
}
