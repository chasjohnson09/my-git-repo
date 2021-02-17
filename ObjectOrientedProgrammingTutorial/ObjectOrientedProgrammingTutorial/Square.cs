using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTutorial
{
    class Square : Rect    // copies all of the properties from the rectangle class and copies them to use for this class
    {

        public override string Print()  // "override" is making polymorphism work
        {
            return "Square";
        }

        public Square() { } // inserting data into the propertis
        public Square(int s1) : base (s1, s1) // pulling constructer from quad class to make easier 
        {

        }
    }
}
