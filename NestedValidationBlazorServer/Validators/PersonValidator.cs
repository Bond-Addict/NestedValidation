using FluentValidation;
using NestedValidation.Models;

namespace NestedValidation.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.Address).SetValidator(new AddressValidator());
        }
    }
}
