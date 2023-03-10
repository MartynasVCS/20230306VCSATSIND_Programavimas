using System;

namespace DemoIfSalyga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Programos pradžia");

            Console.WriteLine("Įveskite sveikąjį skaičių:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            // Paprasta if sąlyga
            if (skaicius > 5)
            {
                Console.WriteLine($"Skaičius '{skaicius}' yra didesnis už 5");
            }

            // If sąlyga su else if dalimis
            // Tinkrinama iš eilės nuo viršaus
            // Jei kažkuri tenkinama, kitos nebetikrinamos
            if (skaicius > 10)
            {
                Console.WriteLine($"Skaičius '{skaicius}' yra didesnis už 10");
            }
            else if (skaicius > 8)
            {
                Console.WriteLine($"Skaičius '{skaicius}' yra didesnis už 8");
            }
            else if (skaicius > 6)
            {
                Console.WriteLine($"Skaičius '{skaicius}' yra didesnis už 6");
            }

            // If sąlyga su else dalimi
            if (skaicius >= 0)
            {
                Console.WriteLine($"Skaičius '{skaicius}' teigiamas");
            }
            else
            {
                Console.WriteLine($"Skaičius '{skaicius}' neigiamas");
            }

            // Trumpesnė bool kintamojo palyginimo sąlyga
            bool arPenktadienis = true;
            if (arPenktadienis) // if (arPenktadienis == true)
            {
                Console.WriteLine("Šiandien yra penktadienis");
            }
            else
            {
                Console.WriteLine("Šiandien nėra penktadienis");
            }

            // && atveju nustojame tikrinti kai bent viena sąlygos dalis nebetenkinama ir sąlygos veiksmų nevykdome
            // || atveju nustojame tikrinti kai bent viena sąlygos dalis tenkinama ir atliekame sąlygos veiksmus
            bool arKovas = true;
            if (arPenktadienis && arKovas)
            {
                Console.WriteLine("Kovas ir penktadienis");
            } 
            else if (!arKovas && arPenktadienis)
            {
                Console.WriteLine("Ne kovo penktadienis");
            }
            else if (arKovas || arPenktadienis)
            {
                Console.WriteLine("Gal kovas, gal penktadienis, gal abu");
            }

            Console.WriteLine("Programos pabaiga");
        }
    }
}
