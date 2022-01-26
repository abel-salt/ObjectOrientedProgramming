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

            // Act
            var person = new Person(name, personalNumber, email, phoneNumber);

            // Assert
            person.Name.Should().Be(name);
            person.PersonalNumber.Should().Be(personalNumber);
            person.Email.Should().Be(email);
            person.PhoneNumber.Should().Be(phoneNumber);
        }
    }
}

