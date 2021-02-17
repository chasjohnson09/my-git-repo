using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTutorial
{
    class Quad
    {

        private string About { get; set; } = "about Quad Class";
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public int side4 { get; set; }
        
        public virtual string Print()   // "virtual" is how polymorphic happens
        {
            return "Quad";
        }

        public int Perimeter()
        {
            return side1 + side2 + side3 + side4;
        }
        

        public Quad() { }
        public Quad(int s1, int s2, int s3, int s4)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
            side4 = s4;
        }


    }
}
