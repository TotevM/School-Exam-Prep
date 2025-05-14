using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad28
{
    public class FootballPlayer : ClubMember
    {
        public string Position { get; set; }
        public int ContractLength { get; set; }
        public int Matches { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }

        public FootballPlayer(string firstName, string lastName, double salary, int age,
                              string position, int contractLength, int matches, int goals, int assists)
            : base(salary, age, lastName, firstName)
        {
            Position = position;
            ContractLength = contractLength;
            Matches = matches;
            Goals = goals;
            Assists = assists;
        }

        public override void Info()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Position}");
            Console.WriteLine($"salary: {Salary:F2} lv");
            Console.WriteLine($"age: {Age} years");
            Console.WriteLine($"{Goals} goals and {Assists} assists in {Matches} matches");
        }
    }

}
