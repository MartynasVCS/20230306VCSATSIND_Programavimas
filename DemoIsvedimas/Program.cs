using System;

namespace DemoIsvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            

            // WriteLine išveda informaciją ir perkelia žymeklį į naują eilutę
            Console.WriteLine("Labas");

            // Write išveda informaciją ir palieka žymeklį
            Console.Write("Labas ");
            Console.Write("rytas");
            Console.WriteLine();

            // Kintamųjų išvedimas
            int amzius = 25;
            Console.WriteLine(amzius);

            // 1 Būdas išvesti tekstą ir kintamąjį
            Console.WriteLine("Mano amžius: " + amzius);

            // 2 Būdas išvesti tekstą ir kintamąjį
            string vardas = "Martynas";
            Console.WriteLine("Mano amžius: {0}", amzius);
            Console.WriteLine("Mano amžius: {0}, mano vardas: {1}", amzius, vardas);

            // 3 Būdas išvesti tekstą ir kintamąjį
            Console.WriteLine($"Mano amžius: {amzius}");
            Console.WriteLine($"Mano amžius: {amzius}, mano vardas: {vardas}");

            // Vietoj kintamųjų galime išvesti operacijos rezultatą
            Console.WriteLine("Mano amžius: {0}", (5 + 5 + 10 - 8) * 3);
            Console.WriteLine($"Mano amžius: {(5 + 5 + 10 - 8) * 3}");
        }
    }
}
