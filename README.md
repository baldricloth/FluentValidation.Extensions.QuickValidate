# FluentValidation.Extensions.QuickValidate
An easy way to invoke the validator from FluentValidation framework.

# Use
```javascript
            var person = new PersonInfo
            {
                FirstName = "Baldric",
                LastName = "Lothbrok",
                DateOfBirth = new DateTime(1987, 11, 19)
            };

            var personValidation = person.Validate<PersonInfoValidator, PersonInfo>();
            var isValid = personValidation.IsValid;
            var errors = personValidation.ValidationFailures;
            var result = personValidation.ValidationResult;
```

# FluentValidation
An amazing framework that let you easily validate the data in the properties of an object.

Project page: https://github.com/JeremySkinner/FluentValidation

Nuget package: https://www.nuget.org/packages/FluentValidation/
