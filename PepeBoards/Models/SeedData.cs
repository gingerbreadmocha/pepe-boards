using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PepeBoards.Data;

namespace PepeBoards.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                Console.Write("???? go here");
                // Look for any movies.
                if (context.Forum.Any())
                {
                    return;   // DB has been seeded
                }
            
                context.Forum.AddRange(
                     new Forum
                     {
                         Name = "General"
                     },

                     new Forum
                     {
                         Name = "Games"
                     },

                     new Forum
                     {
                         Name = "Off-Topic"
                     },

                     new Forum
                     {
                         Name = "Pepe"
                     }
                );

                context.SaveChanges();

                var general = context.Forum
                    .Where(c => c.Name == "General")
                    .First();

                var games = context.Forum
                    .Where(c => c.Name == "Games")
                    .First();

                var offt = context.Forum
                    .Where(c => c.Name == "Off-Topic")
                    .First();

                var pepe = context.Forum
                    .Where(c => c.Name == "Pepe")
                    .First();

                context.Subforum.AddRange(
                    new Subforum
                    {
                        ForumID = general.ID,
                        Name = "Welcome"
                    },
                    new Subforum
                    {
                        ForumID = general.ID,
                        Name = "News"
                    },
                    new Subforum
                    {
                        ForumID = general.ID,
                        Name = "General Discussion"
                    },
                    new Subforum
                    {
                        ForumID = general.ID,
                        Name = "Help"
                    },
                    new Subforum
                    {
                        ForumID = games.ID,
                        Name = "Wire.IO"
                    },
                    new Subforum
                    {
                        ForumID = games.ID,
                        Name = "Cat.IO"
                    },
                    new Subforum
                    {
                        ForumID = games.ID,
                        Name = "Alpaca Adventure"
                    },
                    new Subforum
                    {
                        ForumID = offt.ID,
                        Name = "Anime"
                    },
                    new Subforum
                    {
                        ForumID = offt.ID,
                        Name = "Food"
                    },
                    new Subforum
                    {
                        ForumID = offt.ID,
                        Name = "Books"
                    },
                    new Subforum
                    {
                        ForumID = offt.ID,
                        Name = "Travel"
                    },
                    new Subforum
                    {
                        ForumID = pepe.ID,
                        Name = "Sad Pepe"
                    },
                    new Subforum
                    {
                        ForumID = pepe.ID,
                        Name = "Happy Pepe"
                    },
                    new Subforum
                    {
                        ForumID = pepe.ID,
                        Name = "WHY?"
                    }
                 );
                context.SaveChanges();
            }
        }
    }
}
