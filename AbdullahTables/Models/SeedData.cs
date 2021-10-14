using System;
using AbdullahTables.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace AbdullahTables.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AbdullahTablesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AbdullahTablesContext>>()))
            {
                // Look for any movies.
                if (context.Tables.Any())
                {
                    return;   // DB has been seeded
                }
                // seeding the Databas with initial values that appears if there is no entries currently
                context.Tables.AddRange(
                    new Tables
                    {
                        Name = "Manera",
                        Color = "grey",
                        Type = "Dinning Table",
                        Price = 349.99M ,
                        Review = "3.9",

                    },

                     new Tables
                     {
                         Name = "Deskfit",
                         Color = "White",
                         Type = "Home Desk",
                         Price = 249.99M,
                         Review = "4.1",

                     },

                      new Tables
                      {
                          Name = "Workez",
                          Color = "Brown",
                          Type = "Office Desk",
                          Price = 329.99M,
                          Review = "4.2",

                      },

                       new Tables
                       {
                           Name = "Solonel",
                           Color = "Grey",
                           Type = "Room Desk",
                           Price = 229.99M,
                           Review = "4.7",

                       },

                        new Tables
                        {
                            Name = "Familia",
                            Color = "White",
                            Type = "Dinning Table",
                            Price = 399.99M,
                            Review = "4.5",

                        },

                         new Tables
                         {
                             Name = "Zenit",
                             Color = "Brown",
                             Type = "Room Desk",
                             Price = 349.99M,
                             Review = "4.3",

                         },

                          new Tables
                          {
                              Name = "Flavors",
                              Color = "Brown",
                              Type = "Dinning Room",
                              Price = 449.99M,
                              Review = "4.9",

                          },

                           new Tables
                           {
                               Name = "Boss1",
                               Color = "Brown",
                               Type = "Office Desk",
                               Price = 499.99M,
                               Review = "4.7",

                           },

                            new Tables
                            {
                                Name = "Aurora",
                                Color = "White",
                                Type = "Home Desk",
                                Price = 399.99M,
                                Review = "4.7",

                            },

                             new Tables
                             {
                                 Name = "Luna",
                                 Color = "White",
                                 Type = "Room Desk",
                                 Price = 329.99M,
                                 Review = "4.6",

                             }
                             );
                context.SaveChanges();
            }
        }
    }
}
