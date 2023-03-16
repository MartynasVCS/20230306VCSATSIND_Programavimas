using System;

namespace DemoKlases
{
    internal class Zmogus
    {
        internal string vardas { get; }
        internal int amzius { get; }
        internal double ugis { get; }

        public Zmogus(string vardas, int amzius, double ugis)
        {
            this.vardas = vardas;
            this.amzius = amzius;
            this.ugis = ugis;
        }

        public Zmogus(string vardas)
        {
            this.vardas = vardas;
        }

        public Zmogus()
        {

        }

        internal void Prisistatymas()
        {
            if (vardas != null)
            {
                Console.WriteLine($"Sveiki, mano vardas yra {vardas}.");
            }
            else
            {
                Console.WriteLine("I was never given a name :(");
            }
        }

        internal void Atsisveikinimas()
        {
            Console.WriteLine("Viso gero.");
        }

        internal void Atsisveikinimas(Zmogus kitasZmogus)
        {
            Console.WriteLine($"Ate {kitasZmogus.vardas}");
        }
    }
}
