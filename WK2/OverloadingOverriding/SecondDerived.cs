namespace OverrideOverload
{
    public class SecondDerived : Derived
    {

        public string secondDerivedString;

        public SecondDerived()
        {
            this.secondDerivedString = "Derived";
        }

        //Method overriding is a techi=nique that allows the invoking of function from another class
        //in the derived class. Creating a method in the derived class with the same 




        //AccesModifire Modifier ReturnType MethodName(Parameters)
        public override void newMethod()     //"override" is REQUIRED to extend or modify the virtual implementation of an 
                                            //inherited method, propert, indexer, or event.
        {
            Console.WriteLine("Running newMethod() from SecondDerived.");
        }
    }
}