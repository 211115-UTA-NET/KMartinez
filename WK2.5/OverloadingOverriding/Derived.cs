namespace OverrideOverload
{
    public class Derived : Base
    {

        public string derivedString;

        public Derived()
        {
            this.derivedString = "Derived";
        }

        /*Method overriding is a technique that allows the invoking of function from another
        class in the derived class. Creating a method in the derived class with the same*/




        /*AccesModifire Modifier ReturnType MethodName(Parameters)*/
        public override void newMethod()     /*"overriding" is REQUIRED to extend or modify the virtual implementation of an inherited method, propert, indexer, or event.*/
        {
            Console.WriteLine("Running newMethod() from Derived.");
        }
    }
}