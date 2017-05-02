using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidation.ValidateExtension.Test
{
    public class PersonInfoValidator : AbstractValidator<PersonInfo>
    {
        public PersonInfoValidator()
        {
            RuleFor(t => t.FirstName).NotEmpty().Length(3, 100);
            RuleFor(t => t.LastName).NotEmpty().Length(3, 200);
            RuleFor(t => t.DateOfBirth).NotEmpty();
        }
    }
}
