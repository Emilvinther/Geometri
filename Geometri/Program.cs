using System;

namespace Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(4.5);
            Console.WriteLine($"Arealet er {square.Area()} cm");
            Console.WriteLine($"Omkredsen er {square.Perimitor()} cm");

            Square squarea = new Square(12);
            Console.WriteLine($"\nArealet er {squarea.Area()} cm");
            Console.WriteLine($"Omkredsen er {squarea.Perimitor()} cm");

            Square squareb = new Square(10);
            Console.WriteLine($"\nArealet er {squareb.Area()} cm");
            Console.WriteLine($"Omkredsen er {squareb.Perimitor()} cm");


            Console.ReadKey();
        }
    }
}
