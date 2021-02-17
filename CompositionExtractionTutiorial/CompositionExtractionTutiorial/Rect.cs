using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionExtractionTutiorial
{
    class Rect
    {
        public Quad quad { get; set; }  // setting up composition/abstrction for quad to rect

        public Rect() { }  
        public Rect(int s1, int s2) // creating method for rectangle
        {
            this.quad = new Quad(s1, s2, s1, s2);   // this is referring to the rect inside of the quad class and setting up parameters
        }

        public int Perimeter()  // setting perimeter method
        {
            var p = quad.Perimeter();    // calling perimeter of the quad perimeter method
            var pi = Convert.ToInt32(p);    //changing from double to int
            return pi;

        }
        public double PerimeterAsDouble()
        {
            return quad.Perimeter();
        }
        public int Area()
        {
            var a = quad.side1 * quad.side2;
            var ai = Convert.ToInt32(a);    // changing doule to int 
            return ai;
        }
    }
}
