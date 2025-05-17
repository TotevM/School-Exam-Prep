namespace zad26
{
    public class Student : Human
    {
        private double mark;
        public Student(string firstName, string lastName, int
       age, double mark) : base(firstName, lastName, age)
        {
            this.mark =
       mark;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, grade: {this.mark:f2}";
        }
    }
}
