// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, its me!");

Console.WriteLine("Hello again");


//Casting
Console.WriteLine("##Casting Example### ");

string start = "Begin";
Object 

//Conversion
Console.WriteLine("##### Conversion Example ####" );
int a =7;
byte b = (byte) a;

//double a = 5.5;
int b = (int)a;
Console.WriteLine("The value of a is: " + a);
Console.WriteLine("The value of b is: " + b);



//Parsing
Console.WriteLine("###Parsing Example ###");
bool res;
int parsedString;
string newString = "5isnota83df";
res = int.TryParse(newString, out parsedString);
Console.WriteLine("String could be parsed: " + res);

if (res == true)
{
    parsedString = int.Parse(newString);
    Console.WriteLine("The value of parsedString is: " + parsedString);
}
else
{
    Console.WriteLine("The value of newString could not be parsed");
}