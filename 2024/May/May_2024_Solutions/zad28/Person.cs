using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad28
{
    class Person
    {
        private string id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID
        {
            get { return id; }
            set
            {
                if (value.Length != 10)
                {
                    throw new Exception($"{FirstName} {LastName} - invalid identifier!");
                }
                id = value;
            }
        }
        public Person(string firstName, string lastName, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
        }
    }

}
