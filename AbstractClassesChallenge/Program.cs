using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        public static void Main()
        {
            Rectangle newRectangle = new Rectangle("Rectangle", 4, 2, 3);
            newRectangle.GetInfo();
            //newRectangle.caculateR();
            newRectangle.GetArea();
            Console.WriteLine();




                Triangle newTriangle = new Triangle ("Triangle", 3, 5, 4, 2);
                newTriangle.GetInfo();
                newTriangle.GetArea();
                //Console.WriteLine(newTriangle.GetInfo + newTriangle.GetArea); //Error Cs0019


                Square newSquare = new Square ("Square", 4, 5);
                newSquare.GetInfo();
                newSquare.GetArea();
        

        }

    
    }
}
