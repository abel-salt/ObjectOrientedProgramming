using System;

namespace EmployeeManagementSystem.Models
{
    public class Person
    {

        public string Name { get; private set; }
        public string PersonalNumber { get; private set; }
        public string PhoneNumber { get; private set; }
        public EmailAddress Email { get; private set; }

        public Person(string name, string personalNumber, EmailAddress email, string phoneNumber)
        {
            this.Name = name;
            this.PersonalNumber = personalNumber;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
    }
}

