using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad28
{
    public class Coach : ClubMember
    {
        public string CoachType { get; set; }
        public int ContractLength { get; set; }

        public Coach(double salary, int age, string firstName, string lastName, string coachType, int contractLength)
            : base(salary, age, lastName, firstName)
        {
            CoachType = coachType;
            ContractLength = contractLength;
        }

        public override void Info()
        {
            Console.WriteLine($"{CoachType} coach: {FirstName} {LastName}");
            Console.WriteLine($"salary: {Salary:F2} lv");
            Console.WriteLine($"age: {Age} years");
        }
    }

}
