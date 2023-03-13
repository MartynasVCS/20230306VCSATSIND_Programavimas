using System;

namespace DemoMasyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Masyvas iš konkrečių reikšmių
            int[] skaiciaiKonkretus = { 7, 15, 2, 9, 28, 2, 28, 35, 7, 35, 4 };
            
            // Konkretaus dydžio masyvas (su default pagal tipą reikšmėmis)
            int[] skaiciaiTusti = new int[5];
            string[] zodziaiTusti = new string[3];

            // Spausdiname visas masyvo reikšmes
            foreach (int skaicius in skaiciaiTusti)
            {
                Console.WriteLine(skaicius);
            }

            // Spausdiname visas masyvo reikšmes
            foreach (string zodis in zodziaiTusti)
            {
                Console.WriteLine(zodis);
            }

            // Spausdiname masyvo reikšmes pagal indeksą
            Console.WriteLine(skaiciaiTusti[0]);
            Console.WriteLine(skaiciaiTusti[1]);
            Console.WriteLine(skaiciaiTusti[4]);
            Console.WriteLine();

            // Įrašome masyvo reikšmes pagal indeksą
            skaiciaiTusti[0] = 5;
            skaiciaiTusti[1] = 18;
            //skaiciaiTusti[5] = 42; // Negalimas veiksmas nes masyvas yra fiksuoto dydžio

            // Perraršome visas masyvo reikšmes cikle
            foreach (int skaicius in skaiciaiTusti)
            {
                // skaicius = 7; // Su foreach to padaryti neįmanoma
            }

            for (int i = 0; i < skaiciaiTusti.Length; i++)
            {
                skaiciaiTusti[i] = i * 2;
            }

            // Spausdiname visas masyvo reikšmes
            foreach (int skaicius in skaiciaiTusti)
            {
                Console.WriteLine(skaicius);
            }

            // Min/Max algoritmas
            int min = int.MaxValue;
            for (int i = 0; i < skaiciaiKonkretus.Length; i++)
            {
                if (skaiciaiKonkretus[i] < min)
                {
                    min = skaiciaiKonkretus[i];
                }
            }

            if (min != int.MaxValue)
            {
                // Viskas gerai, min algoritmas įvyko
            } 
            else
            {
                // Liko numatytoji negalima reikšmė, kažkas kažkur įvyko blogai
            }

            // Spausdiname visas masyvo reikšmes
            Console.Write($"Masyvo reikšmės: ");
            foreach (int skaicius in skaiciaiKonkretus)
            {
                Console.Write($"{skaicius}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Mažiausia reikšmė: {min}");
        }
    }
}
