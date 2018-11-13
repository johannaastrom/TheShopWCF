namespace TheShop.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using TheShop.Model;

	internal sealed class Configuration : DbMigrationsConfiguration<TheShop.Client.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TheShop.Client.ProductDbContext context)
        {
			context.Products.AddOrUpdate(
				p => p.Name,
				new Product { Name = "Buster" },
				new Product { Name = "Kalle" },
				new Product { Name = "Pelle" },
				new Product { Name = "Bella" }
				);
		}
    }
}
