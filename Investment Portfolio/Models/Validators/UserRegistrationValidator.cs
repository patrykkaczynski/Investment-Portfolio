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

            RuleFor(x => x.Email).EmailAddress()
                .Custom((value, context) =>
                {
                    bool isValid = applicationContext.Users.Any(e => e.Email == value);

                    if (isValid)
                    {
                        context.AddFailure("Email", "This email has been already used during another registration");
                    }
                });

            RuleFor(x => x.DateOfBirth).
                Must(DateOfBirthHelper.);

            RuleFor(x => x.Password).MinimumLength(6)
                .Must(PasswordHelper.HasSpecialSign)
                .Must(PasswordHelper.HasNumber)
                .Must(PasswordHelper.HasCapitalLetter)
                .Must(PasswordHelper.HasSmallLetter);

            RuleFor(x => x.ConfirmPassword).Equal(e => e.Password);


        }

    }
}
