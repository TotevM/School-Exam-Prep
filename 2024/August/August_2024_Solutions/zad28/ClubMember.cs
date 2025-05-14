namespace zad28
{
    public abstract class ClubMember
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        protected ClubMember(double salary, int age, string lastName, string firstName)
        {
            Salary = salary;
            Age = age;
            LastName = lastName;
            FirstName = firstName;
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value <=0)
                {
                    throw new Exception("Salary must be a positive number!");
                }
                salary = value;
            }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (value<17)
                {
                    throw new Exception("Age must be greater than 17 years!");
                }
                age = value;
            }
        }


        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The name can’t be an empty string!");
                }
                lastName = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The name can’t be an empty string!");
                }
                firstName = value;
            }
        }

        public abstract void Info();
    }
}
