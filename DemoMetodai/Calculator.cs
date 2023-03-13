using System;

namespace DemoMetodai
{
    internal class Calculator
    {
        internal static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        internal int Difference(int num1, int num2)
        {
            return num1 - num2;
        }

        // Rekursinis metodas (kviečia pats save)
        internal static void DivisionByTwoUntilZero(int number)
        {
            Console.WriteLine(number);
            // Svarbu turėti išėjimo sąlyga, kad nebūtų amžinas ciklas
            if (number != 0 )
            {
                int numberDivided = number / 2;
                DivisionByTwoUntilZero(numberDivided);
            }
        }
    }
}
