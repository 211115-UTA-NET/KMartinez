using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        protected int lenght =0;
        
        
        public Square(string Name, int NumSides, int lenght) : base (Name, NumSides)
        {
            this.Name = Name;
            this.NumSides = NumSides;
            this.lenght = lenght;
           
            
        
        }
        // protected override void SetArea() //should not need this since it should be inherting from rectangle.
        // {
        //     base.Area = l * w;
           
        // }
    }
}