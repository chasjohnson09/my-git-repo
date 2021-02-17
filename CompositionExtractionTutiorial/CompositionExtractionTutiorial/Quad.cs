using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionExtractionTutiorial
{
    class Quad
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        public double side4 { get; set; }
        
        public string Print()
        {
            return "Quad";
        }

        public double Perimeter()
        {
            return side1 + side2 + side3 + side4;
        }
        

        public Quad() { }
        public Quad(double s1, double s2, double s3, double s4)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
            side4 = s4;
        }


    }
}
