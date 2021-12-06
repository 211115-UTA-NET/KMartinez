using System;

namespace ParameterSamples
{
    class Program
    {
        public static void Main()
        {
            //VALUE PARAMETER\\
            int i = 0;
            SimpleMethod(i);
            Console.WriteLine(i);
            
           //REF PARAMETER\\
           int a =0;
            SimpleMethod(ref a);
            Console.WriteLine(a);

                
                //OUT PARAMETER\\
            int Total = 0;
            int Product = 0;
            Calculate(10,20, out Total, out Product);
            Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);

            //ARRAY PARAMETER\\
            int [] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            ParamsMethod(Numbers);
          }
        //VALUE PARAMETER\\
        public static void SimpleMethod(int j)
        {
            j = 101;
        }

           //REF PARAMETER\\
        public static void SimpleMethod(ref int j) 
        {
            j = 101;
        }
            
           //OUT PARAMETER
        public static void Calculate (int FN, int SN, out int Sum, out int Product)
        {
            Sum =  FN + SN;
            Product = FN * SN;
        }
        
           //ARRAY PARAMETER\\
          public static void ParamsMethod(params int[] Numbers)
          {
              Console.WriteLine("There are {0} elements", Numbers.Length);
          
            foreach (int i in Numbers)
            {
              Console.WriteLine(i);
            }
          }


    }
}
