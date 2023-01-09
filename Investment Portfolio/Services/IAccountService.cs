using Investment_Portfolio.Models;

namespace Investment_Portfolio.Services
{
    public interface IAccountService
    {
        Task RegisterUserAsync(UserRegistrationDto userRegistrationDto);
    }
}
