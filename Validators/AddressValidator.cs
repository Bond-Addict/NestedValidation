using FluentValidation;
using NestedValidation.Models;

namespace NestedValidation.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a.Street).NotEmpty();
        }
    }
}
