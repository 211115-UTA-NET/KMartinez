using System;

namespace AbstractClassesChallenge
{
    abstract public class Triangle : Shape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area. 
            private double Sidea, Sideb , Sidec = 0;

            public Triangle(string Name, int NumSides,  double Sidea, double Sideb, double Sidec) : base (Name, NumSides)
            {
            this.Name = Name;
            this.NumSides = NumSides;
            this.Sidea = Sidea;
            this.Sideb = Sideb;
            this.Sidec = Sidec;
            }
            
            protected override void SetArea()
            {
            double total = (Sidea + Sideb + Sidec)/2;
            base.Area = Math.Sqrt(total * ( total - Sidea) * (total - Sideb) * (total - Sidec)); 
            // return SetArea;  //does not like this
            }



    }
}