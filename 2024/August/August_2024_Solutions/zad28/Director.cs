namespace zad28
{
    public class Director : ClubMember
    {
        private string directorType;

        public Director(string directorType, double salary, int age, string lastName, string firstName) : base(salary, age, lastName, firstName)
        {
            DirectorType = directorType;
        }

        public string DirectorType
        {
            get { return directorType; }
            set { directorType = value; }
        }


        public override void Info()
        {
            Console.WriteLine($"{directorType} director: {FirstName} {LastName}");
            Console.WriteLine($"salary; {Salary:F2}lv");
            Console.WriteLine($"age: {Age} years");
        }
    }
}
