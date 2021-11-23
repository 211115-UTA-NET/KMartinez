using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
      public static void Main(string[] args)
      {

          Console.WriteLine("Byte Example");
          byte myByte = 123;
          Console.WriteLine("The value of Byte:" + myByte + "\n");


          Console.WriteLine("Sbyte Example");
          sbyte mySbyte = -123;
          Console.WriteLine("The value of sbyte:" + mySbyte + "\n");


          Console.WriteLine("Int Example");
           int myInt = 1;
           Console.WriteLine("The value of Int:" + myInt + "\n");


          Console.WriteLine("Uint Example");
           uint myUint = 12345679;
           Console.WriteLine("The value of Unint:" + myUint + "\n");


          Console.WriteLine("Short Example");
           short myShort = -3284;
           Console.WriteLine("The value of Short:" + myShort +"\n");


          Console.WriteLine("ushort Example");
           ushort myUShort = 0;
           Console.WriteLine("The value of Ushort:" + myUShort + "\n");


          Console.WriteLine("Float Example");
           float myFloat = 16f;
          Console.WriteLine("The value of Float:" + myFloat +"\n");


          Console.WriteLine("Double Example");
           double myDouble = -1.797639215;
           Console.WriteLine("The value of Double:" + myDouble + "\n");


          Console.WriteLine("Char Example");
           char myCharacter = '!';
           Console.WriteLine("Character:" + myCharacter + "\n");

          Console.WriteLine("Bool Example");
           bool myBool = true;
           Console.WriteLine(myBool ? "Checked:" : "Not Checked:" + myBool);
           Console.WriteLine(false ? "Checked:" : "Not Checked:" + myBool + "\n");


          Console.WriteLine("1st String Example");
           string myText1 = "This is the 1st String, I hope.";
           Console.WriteLine("" + myText1 + "\n");

          Console.WriteLine("2nd String  Example");
           string numText2 = "This should be the 2nd String 0010, hopefully.";
           Console.WriteLine("" + numText2);
      }

      public static int Text2Num(string numText)
      {
        throw new NotImplementedException();
      }
    }
}
