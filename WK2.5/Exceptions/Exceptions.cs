
Console.WriteLine("Exceptions");
            //Exceptions\\
// int [] numbers = {0,1,2,3,4,5,6};
// Console.WriteLine("nter and index betwee 0 and 6");
// int index = int.Parse(Console.ReadLine()); //reader inputs number


// try
// {
//  Console.WriteLine(numbers[index]);  //writes number

// }
// catch (IndexOutOfRangeException e)
// {
//    Console.WriteLine("Requested index not in array");
//    Console.WriteLine($"{e.GetType().Name}: {index} is outside the range of the array"); //if its out of range this gets output
   

// }

// throw new IndexOutOfRangeException(); 




        //With String\\

bool loop = false;
string? myString;

do
{
    Console.WriteLine("Enter a string:");
    myString = Console.ReadLine();

    try
    {
        Console.WriteLine(myString[0]);
        // loop = false;
    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine("Uh oh, you enterd no string!");
        // loop = true;
     }
    finally
    {
        Console.WriteLine("Yup, it's saved");
    }


    // bool testOne = (myString == null);
    // bool testTwo = (a != b);
    // bool result = testOne || testTwo;
}
// while( loop );
while(myString == null);