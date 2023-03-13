using System;
using System.Collections.Generic;

namespace DemoSarasai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> zodziai = new List<string>();
            zodziai.Add("Labas");

            Console.WriteLine(zodziai[0]);
            //Console.WriteLine(zodziai[1]); // Nėra reikšmės su indeksu 1
        }
    }
}
