using Xunit;
using FluentAssertions;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Test
{
    public class ModelCreationTest
    {
        public string TestName;
        public string TestPersonalNumber;
        public string TestPhoneNumber;
        public string TestEmail;
        public string TestBankAccount;
        public string TestSalary;

        public ModelCreationTest()
        {
            // Arrange
            this.TestName = "Abel";
            this.TestPersonalNumber = "19800515-1385";
            this.TestPhoneNumber = "+467000000";
            this.TestEmail = "abel@test.test";
            this.TestBankAccount = "100008005151385";
            this.TestSalary = "30000";
        }
        [Fact]
        public void should_be_able_to_create_email_instance()
        {
            // Act
            var emailAddress = new EmailAddress(this.TestEmail);

            // Assert
            emailAddress.Current.Should().Be(this.TestEmail);

        }

        [Fact]
        public void should_be_able_to_create_person_instance()
        {
            // Arrange
            var emailAddress = new EmailAddress(this.TestEmail);
            // Act
            var person = new Person(
                this.TestName,
                this.TestPersonalNumber,
                emailAddress,
                this.TestPhoneNumber
                );

            // Assert
            person.Name.Should().Be(this.TestName);
            person.PersonalNumber.Should().Be(this.TestPersonalNumber);
            person.Email.Current.Should().Be(this.TestEmail);
            person.PhoneNumber.Should().Be(this.TestPhoneNumber);
        }

        [Fact]
        public void should_be_able_to_create_employee_instance()
        {
            // Arrange
            var emailAddress = new EmailAddress(this.TestEmail);

            // Act
            var employee = new Employee(
                    this.TestName,
                    this.TestPersonalNumber,
                    emailAddress,
                    this.TestPhoneNumber,
                    this.TestBankAccount,
                    this.TestSalary);

            // Assert
            employee.BanAccount.Should().Be(this.TestBankAccount);
            employee.Salary.Should().Be(this.TestSalary);
        }
    }
}

