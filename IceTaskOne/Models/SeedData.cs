using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IceTaskOne.Data;
using System;
using System.Linq;

namespace IceTaskOne.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new IceTaskOneContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<IceTaskOneContext>>()))
        {
            // Look for any movies.
            if (context.Music.Any())
            {
                return;   // DB has been seeded
            }
            context.Music.AddRange(
                new Music
                {
                    Instrument = "Acoustic Guitar",
                    Year = DateTime.Parse("1894-8-31"),
                    Make = "String",
                    Price = 7.99M
                },
                new Music
                {
                    Instrument = "Electric Drums",
                    Year = DateTime.Parse("1970-1-23"),
                    Make = "Percussion",
                    Price = 8.99M
                },
                new Music
                {
                    Instrument = "Cello",
                    Year = DateTime.Parse("1978-7-10"),
                    Make = "String",
                    Price = 9.99M
                },
                new Music
                {
                    Instrument = "Trumpet",
                    Year = DateTime.Parse("1820-6-20"),
                    Make = "Brass",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}
