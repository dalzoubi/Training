using System.Data.Entity.Migrations;
using CarwoodsApplication.Models;

namespace CarwoodsApplication.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CarwoodsApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CarwoodsApplicationContext context)
        {
            AddCountries(context);
            AddMakers(context);
            AddModels(context);
        }

        private void AddModels(CarwoodsApplicationContext context)
        {
            context.Options.AddOrUpdate(
                new Option { Name = "Tinted Windows" },
                new Option { Name = "Active  Cruise Control" },
                new Option { Name = "Active Suspension" },
                new Option { Name = "ABS" }
                );
        }

        private void AddCountries(CarwoodsApplicationContext context)
        {
            context.Countries.AddOrUpdate(
                new Country { CountryCode = "JPN", Title = "Japan" },
                new Country { CountryCode = "GRM", Title = "Germany" },
                new Country { CountryCode = "US", Title = "United States of America" },
                new Country { CountryCode = "UK", Title = "United Kingdom" }
                );
        }

        private void AddMakers(CarwoodsApplicationContext context)
        {
            context.Makers.AddOrUpdate(
                new Maker { Title = "Honda" },
                new Maker { Title = "Toyota" },
                new Maker { Title = "BMW" },
                new Maker { Title = "Land Rover" });
        }
    }
}
