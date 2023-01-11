namespace Investment_Portfolio.Models
{
    public class UserRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
