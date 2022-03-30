using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TigerTix.Web.Data;
using System;
using System.Linq;
using TigerTix.Web.Models;

namespace TigerTix.Web.Models
{/*
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TigerTixWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TigerTixWebContext>>()))
            {
                // Look for any movies.
                if (context.User.Any() && context.Event.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        FirstName = "Tom",
                        LastName = "Johnson",
                        Email = "tj@test.com",
                        PhoneNumber = "0123456789",
                        Password = "Password",
                        CreditCard = "1234567890123456",
                        AccountType = "User"
                    },

                    new User
                    {
                        FirstName = "Ted",
                        LastName = "Branson",
                        Email = "tb@test.com",
                        PhoneNumber = "0123456789",
                        Password = "Password",
                        CreditCard = "1234567890123456",
                        AccountType = "User"
                    },

                    new User
                    {
                        FirstName = "Todd",
                        LastName = "Fitzgerald",
                        Email = "tf@test.com",
                        PhoneNumber = "0123456789",
                        Password = "Password",
                        CreditCard = "1234567890123456",
                        AccountType = "User"
                    },

                    new User
                    {
                        FirstName = "Mitch",
                        LastName = "Talcom",
                        Email = "mt@test.com",
                        PhoneNumber = "0123456789",
                        Password = "Password",
                        CreditCard = "1234567890123456",
                        AccountType = "User"
                    }
                );

                context.Event.AddRange(
                    new Event
                    {
                        EventType = "Football",
                        EventName = "Clemson University Vs. Colorado",
                        EventDescription = "Football Game at Clemson University",
                        EventLocation = "Death Valley, Clemson University",
                        EventDateTime = "2022-6-8",
                    },

                    new Event
                    {
                        EventType = "Lecture Series",
                        EventName = "Important person Ted Talk",
                        EventDescription = "Ted Talk",
                        EventLocation = "Watt Building, Clemson University",
                        EventDateTime = "2022-9-4",
                    },

                    new Event
                    {
                        EventType = "Concert",
                        EventName = "Clemson Barbershop Quartet",
                        EventDescription = "Clemsons local Barbershop Quartet ",
                        EventLocation = "Brooks Hall, Clemson University",
                        EventDateTime = "2022-5-7",
                    },

                    new Event
                    {
                        EventType = "Baseball",
                        EventName = "Clemson University Vs. Utah",
                        EventDescription = "Baseball Game at Clemson University",
                        EventLocation = "Clemson University baseball field",
                        EventDateTime = "2022-6-9",
                    }
                );
                context.SaveChanges();
            }
        }
            
    }*/
}