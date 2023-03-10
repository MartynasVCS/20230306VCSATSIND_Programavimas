using System;

namespace DemoForCiklas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Standartinis for ciklas, vidinis iteratorius pavadinimu i, pradedame nuo 0, didiname po vieną
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Vidinis iteratorius nebūtinai turi būti integer
            for (string i = "a"; i != "aaaaaaaa"; i += "a")
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Vidinio kintamojo kitimo veiksmas nebūtinai turi būti aprašytas for sąlygoje
            // Amžinas ciklas
            //for (int i = 0; i <= 5;)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            // Vidinio kintamojo keitimo veiksmas ciklo viduje
            for (int i = 0; i <= 5;)
            {
                i++;
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Vidinio kintamojo keitimo ne vienetu
            for (int i = 0; i <= 50; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
