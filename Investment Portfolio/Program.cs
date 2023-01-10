using FluentValidation;
using Investment_Portfolio.Entities;
using Investment_Portfolio.Extensions;
using Investment_Portfolio.Models;
using Investment_Portfolio.Models.Validators;
using Investment_Portfolio.Services;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureAuthenticationJwtBearer(builder.Configuration);

builder.Services.ConfigureDbContext();

builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

builder.Services.AddScoped<IValidator<UserRegistrationDto>, UserRegistrationValidator>();

builder.Services.ConfigureApiVersioning();

builder.Services.ConfigureSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseSwaggerDocumentation();

app.MapControllers();

app.Run();
