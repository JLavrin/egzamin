using System;

namespace GD63322
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var supermarket1 = new Supermarket("ul. Zielona 34 Gdańsk", 152, "Biedronka");
            var supermarket2 = new Supermarket("ul. Piotrkowska 234 Gdańsk", 152, "Biedronka");

            Console.WriteLine(supermarket1.Promocja(2));
            Console.WriteLine(supermarket2.Promocja(8));

            var sklepMeblowy1 = new SklepMeblowy("ul. Grunwaldzka 32 Gdańsk", 1281, 'A');
            var sklepMeblowy2 = new SklepMeblowy("ul. Grunwaldzka 32 Gdańsk", 12281, 'B');

            
            Console.WriteLine(sklepMeblowy1.Dostepnosc(8) ? "Dostępny" : "Niedostępny");
            Console.WriteLine(sklepMeblowy2.Dostepnosc(13) ? "Dostępny" : "Niedostępny");

            Console.WriteLine(supermarket1.Info());
            Console.WriteLine(supermarket2.Info());
            Console.WriteLine(sklepMeblowy1.Info());
            Console.WriteLine(sklepMeblowy2.Info());

            Console.ReadKey();

        }
    }
}