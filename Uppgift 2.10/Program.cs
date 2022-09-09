using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är ditt favorit Bilmärke?");
            string Bil = Console.ReadLine();
            Console.WriteLine("märken hetter Mazerati");
            string Märken = Console.ReadLine();

            Console.WriteLine("Hej" + "Jag hoppas du år ditt drömmbil" + Märken + Bil + ".");
        }
    }
}