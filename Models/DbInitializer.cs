using Bogus;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication35.Context;

namespace WebApplication35.Models
{
    public static class DbInitializer
    {
        public static void Initialize(RegistryContext context)
        { 
            context.Database.EnsureCreated();
            if (context.Users.Any())
            {
                return;
            }
            context.Users.AddRange(GetSampleData());
            context.SaveChanges();
        }

        public static List<User> GetSampleData()
        {
            var userFaker = new Faker<User>()
                .RuleFor(u => u.Name, f => f.Name.FullName())
                .RuleFor(u => u.DateOfBirth, f => f.Person.DateOfBirth.ToString("yyyy/MM/dd"))
                .RuleFor(u => u.Password, f => f.Internet.Password())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.ZipCode, f => f.Random.Int(10000, 99999).OrNull(f, 0.1f));

            var users = userFaker.Generate(20);

            return users;
        }
    }
}
