using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTutorial
{   

    class Rect : Quad   // copies all of the properties from the quad class
                        // doesnt make youu repeat code and make more efficient
    {
        public override string Print()  // "override" is part of the polymorphism
        {
            return "Rectangle";
        }

        public int Area()
        {
            return side1 * side2;
        }

        public Rect() { }
        public Rect(int s1, int s2) : base (s1, s2, s1, s2) // pulling constructer from quad class to make easier 
        {
            
        }
    }
}
