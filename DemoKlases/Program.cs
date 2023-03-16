using System;

namespace DemoKlases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zmogus zmogusPetras = new Zmogus("Petras", 45, 1.80);
            Zmogus zmogusSaulius = new Zmogus("Saulius");
            Zmogus zmogusAnonimas = new Zmogus();

            Console.WriteLine(zmogusPetras.vardas);
            Console.WriteLine(zmogusPetras.ugis);
            Console.WriteLine(zmogusPetras.amzius);
            zmogusPetras.Prisistatymas();
            zmogusPetras.Prisistatymas();
            
            Console.WriteLine();

            Console.WriteLine(zmogusSaulius.vardas);
            Console.WriteLine(zmogusSaulius.ugis);
            Console.WriteLine(zmogusSaulius.amzius);
            zmogusSaulius.Prisistatymas();
            zmogusSaulius.Atsisveikinimas(zmogusPetras);

            Console.WriteLine();
            zmogusAnonimas.Prisistatymas();
        }
    }
}
