using Xunit;
using FluentAssertions;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Test
{
    public class ModelTestPerson
    {
        [Theory]
        [InlineData("Abel",
                    "19800515-1385",
                    "+467000000",
                    "abel@test.test")]
        public void should_be_able_to_create_person_instance(string name, string personalNumber, string phoneNumber, string email)
        {
            // Arrange
            var emailAddress = new EmailAddress(email);
            // Act
            var person = new Person(name, personalNumber, emailAddress, phoneNumber);

            // Assert
            person.Name.Should().Be(name);
            person.PersonalNumber.Should().Be(personalNumber);
            person.Email.Current.Should().Be(email);
            person.PhoneNumber.Should().Be(phoneNumber);
        }

        [Theory]
        [InlineData("Abel",
                    "19800515-1385",
                    "+467000000",
                    "abel@test.test",
                    "100008005151385",
                    "30000")]
        public void should_be_able_to_create_employee_instance(
            string name,
            string personalNumber,
            string phoneNumber,
            string email,
            string bankAccount,
            string salary)
        {
            // Arrange
            var emailAddress = new EmailAddress(email);

            // Act
            var employee = new Employee(
                            name,
                            personalNumber,
                            emailAddress,
                            phoneNumber,
                            bankAccount,
                            salary);

            // Assert
            employee.BanAccount.Should().Be(bankAccount);
            employee.Salary.Should().Be(salary);
        }

        [Theory]
        [InlineData("abel@test.test")]
        public void should_be_able_to_create_email_instance(string email)
        {
            // Arrange

            // Act
            var employee = new EmailAddress(email);

            // Assert
            employee.Current.Should().Be(email);

        }
    }
}

