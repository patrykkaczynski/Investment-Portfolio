using Investment_Portfolio.Repository;
using Microsoft.EntityFrameworkCore;

namespace Investment_Portfolio.Extensions
{
    public static class DbContextExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(Environment.GetEnvironmentVariable("SQLConnectionString")));
        }
    }
}
