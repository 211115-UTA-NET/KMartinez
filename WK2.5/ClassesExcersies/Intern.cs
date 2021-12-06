namespace SampleNamespace
{
    public class Intern : Person
    {
        public int coffeeMade = 10;
        
        public Intern(int coffeeMade, string firstName, string lastName) : base(firstName, lastName)
        {
            this.coffeeMade = coffeeMade;
        }

    }
}