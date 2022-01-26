using System;

namespace EmployeeManagementSystem.Models
{
    public class EmailAddress
    {
        public string Current { get; private set; }
        public string[] EmailAddresses { get; private set; }

        public EmailAddress(string email)
        {
            this.EmailAddresses = new string[] { email };
            this.Current = email;
        }
    }
}

