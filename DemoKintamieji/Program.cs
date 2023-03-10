using System;

namespace DemoKintamieji
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Žemėlapis!");

            // Vienos eilutės komentaras

            /* Komentaras
             * per
             * kelias
             * eilutes
             */

            // Deklaracija ir inicializacija vienu veiksmu
            int amzius = 7;

            // Deklaracija ir inicializacija atskirais veiksmais
            string tekstoKintamasis;
            tekstoKintamasis = "Labas";

            // Paprastiems tipams nerekomenduojama naudoti var
            var tekstas = "Sveiki";
            tekstas = "Labas";

            // var naudojame kažkokieks sudėtingiems/ilgiems tipams
            var encoding = System.Text.Encoding.UTF8;

            char simbolis1 = '@';
            char simbolis2 = '#';
            // char suma yra jų ascii kodų suma
            Console.WriteLine(simbolis1 + simbolis2);

            // trupmeniniai skaičiai
            float skaicius0 = 0;
            float skaicius1 = 0.0f; // float reikšmei privalomas simbolis 'f' pabaigoje
            double skaicius2 = 0.0;
            double skaicius3 = 0.0d;
            decimal skaicius4 = 0;
            decimal skaicius5 = 0.0m; // decimal reikšmei privalomas simbolis 'm' pabaigoje
        }
    }
}
