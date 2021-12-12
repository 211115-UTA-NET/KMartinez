


int test;
Console.WriteLine("[1] - condition 1");
Console.WriteLine("[2] - condition 2");
Console.WriteLine("[2] - condition 3");
Console.WriteLine("[2] - condition 4");

test = int.Parse(Console.ReadLine());

switch (test)
{
    case 1:
    Console.WriteLine("Condition 1");
    break;
    
    case 2:
    Console.WriteLine("Condition 2");
    break;

    case 3:
    Console.WriteLine("Condition 3");
    break;
    
    case 4:
    Console.WriteLine("Condition 4");
    break;

    default:
        Console.WriteLine("Not a vaild condition");
}

//While loop
Console.WriteLine("##While##");

bool newTest = false;

Console.WriteLine("this happends before the loop");
while (newTest == true)
{
    Console.WriteLine("your test was true");
    newTest = false;
}
Console.WriteLine("This happens after the loop");

//Do while loop
Console.WriteLine("##Do While##");

int j = 5;
//first example
do
{
    Console.WriteLine(j);
    Console.WriteLine("your do-while is running");
    j++;
}
while(j<5)

Console.WriteLine("##While##");
//other example
j =5;
while (j<5)
{
    Console.WriteLine(j);
    j++;
}

