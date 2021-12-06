namespace SampleNamespace
{
    public class Employee : Person
    {
        public int HoursWorked;
        public double PayRate;

        //Constructor

        public Employee()
        {
            HoursWorked = 40;
            PayRate = 10.00;
        }
        
        public Employee(int HoursWorked, double PayRate, string firstName, string lastName) : base(firstName, lastName)
        {
            this.HoursWorked = HoursWorked;
            this.PayRate = PayRate;
        }

        public double getPayRate()
        {
            return PayRate;
        }

        public Employee(int HoursWorked, double PayRate)
        {

        }


        public void doWork()
        {
            Console.WriteLine($"I've worked {HoursWorked} hours.");
        }
    }
}