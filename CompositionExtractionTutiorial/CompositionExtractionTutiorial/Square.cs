using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionExtractionTutiorial
{
    class Square
    {
        public Rect rect { get; set; }

        public Square() { }
        public Square(int s1)
        {
            this.rect = new Rect(s1, s1);
        }

        public int Perimeter()
        {
            return rect.Perimeter();
        }

        public int Area()
        {
            return rect.Area();
        }

    }
}
