using FluentValidation;
using FluentValidation.AspNetCore;

namespace Investment_Portfolio.Extensions
{
    public static class FluentValidationExtension
    {
        public static void ConfigureFluentValidation(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

            ValidatorOptions.Global.LanguageManager.Enabled = false;
            ValidatorOptions.Global.DefaultRuleLevelCascadeMode = CascadeMode.Stop;
        }
    }
}
