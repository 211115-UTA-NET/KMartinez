using System;

class loopNskip
{
    static void Main()
    {
        for (int i=0; i<=99; i++)
        {
            if (IsOdd(i))
            {
                Console.WriteLine(i);
            }
        }
    }
public static bool IsOdd(int value)
    {
        return value % 2 != 0;
    }
}
