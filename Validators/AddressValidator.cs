using FluentValidation;
using ValidotPOC.Models;

namespace ValidotPOC.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a.Street).NotEmpty();
        }
    }
}
