using System;

namespace EmployeeManagementSystem.Models
{
    public class Employee : Person
    {

        public string BanAccount { get; private set; }
        public string Salary { get; private set; }

        public Employee(
            string name,
            string personalNumber,
            string email,
            string phoneNumber,
            string bankAccount,
            string salary) : base(name, personalNumber, email, phoneNumber)
        {
            this.BanAccount = bankAccount;
            this.Salary = salary;

        }
    }
}

