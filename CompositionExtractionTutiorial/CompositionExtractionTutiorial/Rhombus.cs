using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionExtractionTutiorial
{
    class Rhombus
    {
        public Rect rect { get; set; }

        public Rhombus()
        {   }
        public Rhombus(int s1, int s2)
        {
            this.rect = new Rect(s1, s2);
        }
        
    }
}
