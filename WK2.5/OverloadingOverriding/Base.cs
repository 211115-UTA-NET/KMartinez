namespace OverrideOverload
{

    public class Base
    {

        public string baseString;

        public Base()
        {
            this.baseString = "Base";
        }

        public Base(string baseString)
        {
            this.baseString = baseString;
        }

        //Overloading - creating multipleversions of a method or constructor that accept different 
        //parameters(#of parameters, types, ets) and accomplish the same task.
        //share the same name, but different parameters.

        public void speak()
        {
            Console.WriteLine("Hello, I am a Base class object.");
        }

        
        public void speak(string type)
        {
            Console.WriteLine($"Hello, I am a {type} object.");
        }



        //use descriptive names for methods, but the methods to be overloaded MUST have the same name.
        //use descriptive names for parameters. use the same name for the same parameters for each instance
        //of an oveloaded method.
        //Semd parameters in consistent order.
        //DO NOT have overloads with parameters at the same position and similiar types, ye with different semantics.
        public virtual void newMethod()      //"virtual" keyword is used to ID a method to allow it to be overrided.
        {
            Console.WriteLine("Running newMethod() from Derived.");
        }
    }
}