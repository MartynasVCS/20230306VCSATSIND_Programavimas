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
        }
    }
}
