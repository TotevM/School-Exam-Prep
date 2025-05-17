namespace zad26
{
    public class Worker : Human
    {
        private double wage;
        private double workHours;
        public Worker(string firstName, string lastName, int
       age, double wage, double workHours) : base(firstName, lastName,
       age)
        {
            this.wage = wage;
            this.workHours = workHours;
        }
        public double WagePerHour()
        {
            return this.wage * this.workHours;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, salary: ${WagePerHour
           ():f2}";
        }
    }
}
