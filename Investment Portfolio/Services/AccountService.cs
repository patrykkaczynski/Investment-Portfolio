using Investment_Portfolio.Entities;
using Investment_Portfolio.Models;
using Investment_Portfolio.Repository;
using Microsoft.AspNetCore.Identity;

namespace Investment_Portfolio.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IPasswordHasher<User> _passwordHasher;


        public AccountService(ApplicationContext applicationContext, IPasswordHasher<User> passwordHasher)
        {
            _applicationContext = applicationContext;
            _passwordHasher = passwordHasher;
        }
        public async Task RegisterUserAsync(UserRegistrationDto userRegistrationDto)
        {
            var newUser = new User
            {
                FirstName = userRegistrationDto.FirstName,
                LastName = userRegistrationDto.LastName,
                Email = userRegistrationDto.Email,
                DateOfBirth = userRegistrationDto.DateOfBirth,
                Country = userRegistrationDto.Country,
            };

            var hashedPassword = _passwordHasher.HashPassword(newUser, userRegistrationDto.Password);

            newUser.PasswordHash = hashedPassword;
            await _applicationContext.Users.AddAsync(newUser);
            await _applicationContext.SaveChangesAsync();
        }
    }
}
