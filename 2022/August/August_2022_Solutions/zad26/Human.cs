namespace zad26
{
    public class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public override string ToString()
        {
            return this.firstName + " " + this.lastName + ", " +
           this.age + " years old";
        }
    }
}