using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.
        //lengt and width 
        int l =0;
        int w = 0;
        double areaR = 0;
        public Rectangle(int l, int w, double areaR, string Name, int NumSides) : base (Name, NumSides)
        {
            this.l = l;
            this.w = w;
            
        
        }
        public double caculateR()
        {
            areaR = l * w;
            return areaR;
        }
    }


}