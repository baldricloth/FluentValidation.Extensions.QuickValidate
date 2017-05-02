using System;
using FluentAssertions;
using FluentValidation.Extensions.QuickValidate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentValidation.ValidateExtension.Test
{
    [TestClass]
    public class QuickValidateTest
    {
        [TestMethod]
        public void ObjectValidatedSuccessFully()
        {
            var person = new PersonInfo
            {
                FirstName = "Baldric",
                LastName = "Lothbrok",
                DateOfBirth = new DateTime(1987, 12, 19)
            };

            var personValidation = person.Validate<PersonInfoValidator, PersonInfo>();
            personValidation.IsValid.Should().Be(true);
            personValidation.ValidationFailures.Count.Should().Be(0);
        }

        [TestMethod]
        public void ObjectValidatedShouldFail()
        {
            var person = new PersonInfo
            {
                FirstName = "Ba",
                LastName = "Lo"
            };

            var personValidation = person.Validate<PersonInfoValidator, PersonInfo>();
            personValidation.IsValid.Should().Be(false);
            personValidation.ValidationFailures.Count.Should().Be(3);
        }
    }
}
