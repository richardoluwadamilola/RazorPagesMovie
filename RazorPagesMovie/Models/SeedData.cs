#define Rating
#if Rating
#region snippet_1
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // look for new movies.
                if (context.Movie.Any())
                {
                    return;   //DB has been seeded
                }

                #region snippet1
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry met Sally",
                        RealeaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99m,
                        Rating = "R"
                    },
                #endregion
                    new Movie
                    {
                        Title = "Ghostbusters",
                        RealeaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99m,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        RealeaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99m,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        RealeaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99m,
                        Rating = "NA"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
#endregion
#endif

