using System;

namespace DemoAritmetiniaiVeiksmai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Artimetinius veiksmus galima naudoti ten kur galime turėti skaitinę reikšmę
            int skaicius1 = 5 + 5 * 2;
            int skaicius2 = (5 + 5) * 2;
            Console.WriteLine(skaicius1);
            Console.WriteLine(skaicius2);
            Console.WriteLine(5 + 5 * 2);
            Console.WriteLine((5 + 5) * 2);
            Console.WriteLine();

            // Dalyba
            int dalmuo1 = 7 / 3; // int reikšmių dalyba grąžina sveikąją dalį
            int dalmuo2 = 7 % 3; // liekanos operacija
            double dalmuo3 = 7.0 / 3; // norėdami realios dalybos turime naudoti trupmeninę reikšmę
            float dalmuo4 = 7.0f / 3; 
            double dalmuo5 = 7.0f / 3; // float dalybos rezultatą galime laikyti kaip duoble reikšmę
            Console.WriteLine(dalmuo1);
            Console.WriteLine(dalmuo2);
            Console.WriteLine(dalmuo3);
            Console.WriteLine(dalmuo4);
            Console.WriteLine(dalmuo5);
            Console.WriteLine();

            // Casting
            int dalinys = 7;
            int daliklis = 3;
            double dalmuo6 = (double)dalinys / daliklis;
            double dalmuo7 = (double)7 / 3;
            Console.WriteLine(dalmuo6);
            Console.WriteLine(dalmuo7);
            Console.WriteLine();

            // Machinacijos
            Console.WriteLine(dalinys / daliklis * 1.0);
            Console.WriteLine(dalinys * 1.0 / daliklis);
            Console.WriteLine(dalinys * 1 / daliklis);
            Console.WriteLine(10 / -0.0); // ???
            Console.WriteLine(10 / 0.0); // ???
            Console.WriteLine();

            // Math biblioteka
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Pow(9, 0.5));
            Console.WriteLine();

            // Kintamojo reikšmės didinimas, mažinimas, dalinimas, dauginimas
            int skaicius3 = 7;
            skaicius3 = skaicius3 + 5;
            skaicius3 += 5; // trumpesnė ankstesnio veiksmo išraiška
            // Tas pats galioja skirtumui, sandaugai, dalybai

            // Kintamojo reikšmės didinimas/mažinimas vienetu
            int skaicius4 = 10;
            Console.WriteLine(skaicius4++); // panaudojam o po to padidinam
            Console.WriteLine(skaicius4);
            Console.WriteLine();

            skaicius4 = 10;
            Console.WriteLine(++skaicius4); // pirma padidinam ir tada naudojam
            Console.WriteLine(skaicius4);
        }
    }
}
