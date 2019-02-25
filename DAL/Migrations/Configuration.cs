using System;
using System.Linq;
using DAL.Models;

namespace DAL.Migrations
{
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.ApplicationDbContext context)
        {
	        if (!context.Clasifications.Any())
	        {
		        context.Clasifications.AddOrUpdate(x => x.Id,

			        new Clasification() { Id = Guid.NewGuid(), Title = "G", Description = "General Audience" },

			        new Clasification() { Id = Guid.NewGuid(), Title = "PG", Description = "Parental Guidance" },

			        new Clasification() { Id = Guid.NewGuid(), Title = "M", Description = "Mature age 15 and over" },

			        new Clasification() { Id = Guid.NewGuid(), Title = "MA15+", Description = "Mature Accompanied under 15s" },

			        new Clasification() { Id = Guid.NewGuid(), Title = "R18+", Description = "Restricted to 18 and over" }

		        );
			}

	        if (!context.MovieFormats.Any())
	        {
		        context.MovieFormats.AddOrUpdate(x => x.Id,

			        new MovieFormat() { Id = Guid.NewGuid(), FormatType = "2D" },

			        new MovieFormat() { Id = Guid.NewGuid(), FormatType = "3D" });
			}
	    




        }
	}
}
