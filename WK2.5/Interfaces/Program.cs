//Interfaces are VERY similar to an abstract class.
//cannot be implimented on its own.
//must be inherited/extended.



// abstract class Abstract
// {
//     private string AbstractString = "I am a string.";
// }

        //Interface\\
interface IAnimal
{
    void animalSound();
}
interface IMammal
{
    void warmblooded();
}

class Pig : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("Oink!");
    }
}


class Program
{
    public static void Main()
    {
        Pig myPig = new Pig();
        myPig.animalSound();
    }
    
    public void warmblooded()
    {
        Console.WriteLine("Toasty!");
    }
}