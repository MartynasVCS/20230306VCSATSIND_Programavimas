using System;

namespace DemoIvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Įveskite savo vardą:");
            string ivedimas = Console.ReadLine(); // Read() bei ReadLine() rezultatą galime išsaugoti
            Console.WriteLine($"Įvedei tai: {ivedimas}");

            Console.WriteLine("Įveskite dar ką nors:");
            Console.WriteLine($"Įvedei tai: {Console.ReadLine()}"); // Galime Read() bei ReaLine() iškviesti ten kur norėsime panaudoti rezultatą

            // Simbolio įvedimas
            Console.WriteLine("Įveskite simbolį: ");
            int symbolAsciiCode = Console.Read();
            Console.WriteLine($"Įvedėte simbolį: {symbolAsciiCode}");
            Console.WriteLine($"Įvedėte simbolį: {(char)symbolAsciiCode}");
            Console.WriteLine($"Įvedėte simbolį: {Convert.ToChar(symbolAsciiCode)}");
            Console.WriteLine();

            // Read() komanda įvedus vieną simbolį į atmintį dar gauna Enter bei newline simbolius
            // Apsauga nuo to: po Read() panaudoti ReadLine()
            Console.WriteLine("Įveskite kitą simbolį: ");
            symbolAsciiCode = Console.Read();
            Console.WriteLine($"Įvedėte simbolį: {symbolAsciiCode}");
            symbolAsciiCode = Console.Read();
            Console.WriteLine($"Įvedėte simbolį: {symbolAsciiCode}");
            symbolAsciiCode = Console.Read();
            Console.WriteLine($"Įvedėte simbolį: {symbolAsciiCode}");
            Console.ReadLine();
            Console.WriteLine();

            // Įvedimo į console problemos
            // Kas bus jeigu vartotojas įves ne skaičių?
            Console.WriteLine("Įveskite sveikąjį skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Įvedėte tokį skaičių: {skaicius}");
        }
    }
}
