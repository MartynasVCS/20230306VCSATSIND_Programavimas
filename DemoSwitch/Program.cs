using System;

namespace DemoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Norint ĮVESTI lietuviškas raides reikia pasikeisti koduotę
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Įveskite gyvūno pavadinimą: ");
            string gyvunas = Console.ReadLine();

            switch (gyvunas)
            {
                case "katė":
                    Console.WriteLine("Įvedėte gyvūną 'katė'");
                    break;
                case "šuo":
                    Console.WriteLine("Įvedėte gyvūną 'šuo'");
                    break;
                case "pelė":
                    Console.WriteLine("Įvedėte gyvūną 'pelė'");
                    break;
                default:
                    Console.WriteLine($"Nežinau gyvūno '{gyvunas}'");
                    break;
            }


        }
    }
}
