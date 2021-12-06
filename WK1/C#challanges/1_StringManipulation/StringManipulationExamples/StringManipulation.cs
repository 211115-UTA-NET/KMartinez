string testString = "abcdefghijklmnopqrstuvwxyz";   //String
Console.WriteLine(testString +"\n" + "\n");         //Display String



//Read individual characters
Console.WriteLine("##Individaul Character##");
char myChar = testString[1];    //[] character location in string
Console.WriteLine(myChar);      //Display Character String


//Find the length of a string of characters
Console.WriteLine("##Length of a String##");
Console.WriteLine(testString.Length ); //Display length of string



//Concatenation -n a series of interconnected things or events
//line up or join multiple strings one after another
Console.WriteLine("##ConCat##");
string one = "this is a string";

string two ="this is a different string";

Console.WriteLine( one + " " + two );
Console.WriteLine(one);
Console.WriteLine(two);


//Change cases to upper case, lower case
Console.WriteLine("##Case Change##");
testString = testString.ToUpper();
Console.WriteLine("*UPPER*");
Console.WriteLine(testString );

testString = testString.ToLower();
Console.WriteLine("*lower*");
Console.WriteLine(testString);


//trim end , trim start, teim
Console.WriteLine("##Trim##");
string badSpacing = "     hello     world    ";
Console.WriteLine("start" + badSpacing + "end");                   //Bad Spacing
Console.WriteLine("start" + badSpacing.TrimStart() + "end");    //Trim Start space
Console.WriteLine("start" + badSpacing.TrimEnd() + "end");      //Trim end space
Console.WriteLine("start" + badSpacing.Trim() + "end");         //Trim start and end space (not the inbetween)


//break down a string into component characters
Console.WriteLine("##SubStrings##");
string betterSpacing = "hello world";
Console.WriteLine(betterSpacing);
Console.WriteLine( betterSpacing.Substring(6)); 



//Compare the contents of a string


