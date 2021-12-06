using System;

namespace OverrideOverload
{
    class Program
    {
        public static void Main()
        {
            // Base MyBase = new Base();
            // Derived MyDerived = new Derived();
            // SecondDerived MySecondDerived = new SecondDerived();

            // Console.WriteLine(MyBase.baseString);
            // Console.WriteLine(MyDerived.derivedString);

            // Console.WriteLine(MyDerived.baseString);
            

            // MyBase.speak();
            // MyBase.speak("I'm Different!");
            // Console.WriteLine(value);

            // MyBase.newMethod();
            // MyDerived.newMethod();

            Base thing;
            thing = new Base();
            thing.newMethod();
            
            thing = new Derived();
            thing.newMethod();

            thing = new SecondDerived();
            thing.newMethod();

            // MySecondDerived.newMethod();
        }
    }
}