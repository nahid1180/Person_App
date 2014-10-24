using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        private string firstName;
        private string middleName;
        private string lastName;

        public string FirstName
        {
            set
            {
                if (value.Length >= 3)
                {
                    firstName = value;
                }
                else
                {
                    firstName = "Please write avove 3 letter";
                }
            }
            get { return firstName; }

        }

        public string MiddleName
        {
            set { middleName = value; }
            get { return middleName; }
        }

        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }

        public string GetFullName()
        {
            return FirstName +" "+ MiddleName +" "+ LastName;
        }

}
    
}
