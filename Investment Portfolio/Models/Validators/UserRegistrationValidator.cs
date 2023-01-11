using FluentValidation;
using Investment_Portfolio.Configuration;
using Investment_Portfolio.Repository;

namespace Investment_Portfolio.Models.Validators
{
    public class UserRegistrationValidator : AbstractValidator<UserRegistrationDto>
    {
        public UserRegistrationValidator(ApplicationContext applicationContext)
        {
            RuleFor(x => x.FirstName).NotEmpty();

            RuleFor(x => x.LastName).NotEmpty();

            RuleFor(x => x.Email).NotEmpty()
                .EmailAddress()
                .Custom((value, context) =>
                {
                    bool isValid = applicationContext.Users.Any(e => e.Email == value);

                    if (isValid)
                    {
                        context.AddFailure("Email", "This email has been already used during another registration");
                    }
                });

            RuleFor(x => x.DateOfBirth).NotEmpty()
                .Must(DateOfBirthHelper.IsDateInRightRange);

            RuleFor(x => x.Password).NotEmpty()
                .MinimumLength(6)
                .Must(PasswordHelper.HasNumber).WithMessage("1")
                .Must(PasswordHelper.HasCapitalLetter).WithMessage("2")
                .Must(PasswordHelper.HasSmallLetter).WithMessage("3")
                .Must(PasswordHelper.HasSpecialCharacters).WithMessage("4");

            RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(e => e.Password);

            RuleFor(x => x.Country).NotEmpty();


        }

    }
}
