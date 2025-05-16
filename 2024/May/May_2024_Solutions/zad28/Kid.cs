namespace zad28
{
    class Kid : Person
    {
        private int age;
        public string Group { get; set; }
        public string ParentLastName { get; set; }
        public string ParentGSM { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 3 || value > 6)
                {
                    throw new Exception($"The child {FirstName} {LastName} age is invalid - {value}");
                }
                age = value;
            }
        }

        public Kid(string firstName, string lastName, string id, int age, string
parentLastName, string parentGSM)
: base(firstName, lastName, id)
        {
            Age = age;
            switch (age)
            {
                case 3:
                    Group = "I";
                    break;
                case 4:
                    Group = "II";
                    break;
                case 5:
                    Group = "III";
                    break;
                case 6:
                    Group = "IV";
                    break;
            }
            ParentLastName = parentLastName;
            ParentGSM = parentGSM;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age}г., {ParentGSM}({ParentLastName})";
        }
    }
}
