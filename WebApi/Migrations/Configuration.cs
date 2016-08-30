namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApi.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi.Models.WebApiServicesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApi.Models.WebApiServicesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Heroes.AddOrUpdate(
                x => x.Id,
                new Hero() { Id = 1, Name = "Link", Species = "Hylian", Type = "Paladin", World = "Hyrule" },
                new Hero() { Id = 2, Name = "korrina", Species = "Human", Type = "Lord/Dragon", World = "FE: Fates" },
                new Hero() { Id = 3, Name = "Celestia", Species = "Alicorn", Type = "Alicorn", World = "Equestria" }
                );
        }
    }
}
