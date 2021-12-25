namespace DelegatesDemo
{
    public class Program
    {
        public static void Main()
    {
            var l = new List:ist<int>
                {1,
                2,
                3,
                4
                };
            PrintNumbers(new List<int> { 1, 2 , 3 });
            public static void PrintNumbers(List<int> numbers,)
            {
                Console.Write("[");
                foreach (int nunm in numbers)
                {
                    Console.Write($"{num}, " );
                }
                Console.Write("]");
            }
    }
    }
}