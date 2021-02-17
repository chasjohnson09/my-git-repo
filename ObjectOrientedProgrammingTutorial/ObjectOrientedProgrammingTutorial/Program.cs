using System;

namespace ObjectOrientedProgrammingTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var quad1 = new Quad(3, 4, 5, 6);
            Console.WriteLine($"Perimeter of the Quad is {quad1.Perimeter()}");
            Console.WriteLine($"quad1 is a {quad1.Print()}");
            Console.WriteLine($"        ");

            var rect1 = new Rect(5, 7);

            Console.WriteLine($"Perimeter of the rectangle is {rect1.Perimeter()}");
            // Console.WriteLine($" about is {rect1.About}");       shows that you cannot pull property from a private property in a class
            Console.WriteLine($"Area of the rectangle is {rect1.Area()}");
            Console.WriteLine($"rect1 is a {rect1.Print()}");
            Console.WriteLine($"        ");

            var sqr1 = new Square(7);
            Console.WriteLine($" Area of the square is {sqr1.Area()}");
            Console.WriteLine($"Perimeter of the rectangle is {sqr1.Perimeter()}");
            Console.WriteLine($"sqr1 is a {sqr1.Print()}");
            Console.WriteLine($"        ");
            
            //polymorphic behaivor example!!!!!
            var shapes = new Quad[] { sqr1, rect1, quad1 }; // changing the variables into quads
            foreach (var shape in shapes)   // array for all of the shapes
            {
                Console.WriteLine($"This shape is a {shape.Print()}");  // writing out what the shapes are
                var rect = shape as Rect;
                if(rect != null)    // if the area is not null
                {
                    Console.WriteLine($" area of the shape is {rect.Area()}");  // write the area
                }
                else
                {
                    Console.WriteLine($"The shape is a quad and therefore has no area");    // if area  is null write
                }
            }
        }
    }
}
