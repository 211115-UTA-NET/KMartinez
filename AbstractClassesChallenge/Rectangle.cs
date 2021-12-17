using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.
        //lengt and width 
        protected int l =0;
        protected int w = 0;
        
        public Rectangle(string Name, int NumSides, int l, int w) : base (Name, NumSides)
        {
            this.Name = Name;
            this.NumSides = NumSides;
            this.l = l;
            this.w = w;
            
        
        }
        protected override void SetArea()
        {
            base.Area = l * w;
            // return SetArea;  //does not like this
        }
    }


}