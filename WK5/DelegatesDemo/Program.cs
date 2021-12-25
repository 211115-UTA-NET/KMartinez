namespace DelegatesDemo
{

    public delegate string NumberFormatter(int num);
    public class Program
    {
        public static void Main()
    {
            {
                NumberFormatter formatter = CommaFormat;
                PrintNumbers(new List<int> { 1, 2, 3, 4,}, formatter);
            }
          //  var l = (new List:ist<int> { 1, 2, 3, 4 });
               
          //  PrintNumbers(new List<int> { 1, 2 , 3 });


            public static void PrintNumbers(List<int> numbers, NumberFormatter formatter)
            {
                Console.Write("[");
                foreach (int nunm in numbers)
                {
                    string formatted = formatter(num);
                    Console.Write(formatted );
                }
                Console.Write("]");
            }

            public static string CommaFormat(int num)
            {
                return $"{num}";
            }
            public static void BadMethod(int num)
            {

            }
    }
    }
}