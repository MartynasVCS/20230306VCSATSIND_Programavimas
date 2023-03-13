using System;

namespace DemoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Gana dažnas while panaudojimas
            while (true)
            {
                // Veiksmai
                if (true == true) // Kažkokia sąlyga
                {
                    break;
                }
            }

            // Įvedimas su duomenų tipo apsauga
            int skaicius = int.MinValue;

            while (skaicius == int.MinValue)
            {
                try
                {
                    Console.Write("Įveskite teigiamą sveikąjį skaičių: ");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                    //break; // Šiuo atveju nereikalingas, nes iš while išeisim pasikeitus 'skaicius' reikšmei
                    // break reikalingas jei mūsų ciklas būtų 'while (true)'
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Įvedėte ne sveikąjį skaičių, bandykite dar kartą.");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            Console.WriteLine($"Įvedėte skaičių '{skaicius}'");
        }
    }
}
