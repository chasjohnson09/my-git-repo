using System;

namespace CompositionExtractionTutiorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var quad1 = new Quad(4, 5, 6, 7);
            Console.WriteLine($"Perimeter of the quad is {quad1.Perimeter()}");
            Console.WriteLine($"        ");

            var rect1 = new Rect(3, 8);
            Console.WriteLine($"Perimeter of the rect is {rect1.Perimeter()}");
            Console.WriteLine($"Area of the rect is {rect1.Area()}");
            Console.WriteLine($"        ");

            var sqr1 = new Square(8);
            Console.WriteLine($"Perimeter of the square is {sqr1.Perimeter()}");
            Console.WriteLine($"Area of the square is {sqr1.Area()}");
            Console.WriteLine($"        ");
        }
    }
}
