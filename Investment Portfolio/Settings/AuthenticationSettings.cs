namespace Investment_Portfolio.Settings
{
    public class AuthenticationSettings
    {
        public const string AuthenticationSectionName = "Authentication";
        public string JwtIssuer { get; set; }
        public string JwtAudience { get; set; }
        public string JwtKey { get; set; } = Environment.GetEnvironmentVariable("SECRET");
    }
}
