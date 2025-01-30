using FluentValidation;
using Validot;
using ValidotPOC.Models;

namespace ValidotPOC.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
        }
    }
}
