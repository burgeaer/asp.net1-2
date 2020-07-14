namespace AtTheMovies.Migrations
{
    using AtTheMovies.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AtTheMovies.Models.MovieDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AtTheMovies.Models.MovieDb context)
        {
            context.Movies.AddOrUpdate(m => m.Title,
new Movie
{
    Title = "Star Wars",
    ReleaseYear = 1977,
    Runtime = 121
},
new Movie
{
    Title = "Inception",
    ReleaseYear = 2010,
    Runtime = 148
},
new Movie
{
    Title = "Toy Story",
    ReleaseYear = 1995,
    Runtime = 81
}
);
        }
    }
}
