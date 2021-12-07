using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        public static void Main()
        {
            Rectangle newRectangle = new Rectangle(2,3, "Rectangle");
            newRectangle.GetInfo();
            newRectangle.caculateR();
            newRectangle.GetArea();
            Console.WriteLine();




            //     Triangle newTriangle = new Triangle (3, 5);
            //     newTriangle.GetInfo();
            //     Console.WriteLine(newTriangle.GetInfo + newTriangle.GetArea);


            //     Square newSquare = new Square (2, 2);
        

        }

    
    }
}
