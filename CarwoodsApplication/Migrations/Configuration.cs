using System.Data.Entity.Migrations;
using System.Linq;
using CarwoodsApplication.Models;

namespace CarwoodsApplication.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CarwoodsApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CarwoodsApplicationContext context)
        {
            if (!context.Options.Any()

                && !context.Countries.Any()
                && !context.Makers.Any()
                && !context.Automobiles.Any()
                && !context.Reviews.Any())
            {
                // Options
                var tintedGlass = new Option {Name = "Tinted Glass"};
                var activeCruiseControl = new Option {Name = "Active Cruise Control"};
                var activeSuspension = new Option {Name = "Active Suspension"};
                var abs = new Option {Name = "ABS"};
                context.Options.AddOrUpdate(tintedGlass, activeCruiseControl, activeSuspension, abs);


                // Countries
                var japan = new Country {CountryCode = "JPN", Title = "Japan"};
                var germany = new Country {CountryCode = "GRM", Title = "Germany"};
                var usa = new Country {CountryCode = "US", Title = "United States of America"};
                var uk = new Country {CountryCode = "UK", Title = "United Kingdom"};
                context.Countries.AddOrUpdate(japan, germany, usa, uk);

                // Makers
                var honda = new Maker {Title = "Honda", Country = japan};
                var toyota = new Maker {Title = "Toyota", Country = japan};
                var bmw = new Maker {Title = "BMW", Country = germany};
                var landRover = new Maker {Title = "Land Rover", Country = uk};
                context.Makers.AddOrUpdate(honda, toyota, bmw, landRover);

                // Automobiles
                var accord = new Automobile {Maker = honda, Model = "Accord", MsrpPrice = 22000, Year = 2015};
                var civic = new Automobile {Maker = honda, Model = "Civic", MsrpPrice = 15000, Year = 2015};
                var corola = new Automobile {Maker = toyota, Model = "Corola", MsrpPrice = 15500, Year = 2015};
                var bmw545I = new Automobile {Maker = bmw, Model = "545i", MsrpPrice = 55000, Year = 2015};
                context.Automobiles.AddOrUpdate();

                // Reviews
                context.Reviews.AddOrUpdate(
                    new Review
                    {
                        Automobile = accord,
                        ReviewerEmail = "Dennis@carwoods.com",
                        Contents = "Like it a little"
                    },
                    new Review
                    {
                        Automobile = accord,
                        ReviewerEmail = "Dennis2@carwoods.com",
                        Contents = "Like it a little more"
                    },
                    new Review {Automobile = civic, ReviewerEmail = "Dennis3@carwoods.com", Contents = "Hate it"},
                    new Review
                    {
                        Automobile = bmw545I,
                        ReviewerEmail = "Dennis4@carwoods.com",
                        Contents = "In love with it"
                    },
                    new Review
                    {
                        Automobile = corola,
                        ReviewerEmail = "Dennis5@carwoods.com",
                        Contents = "Most reliable cars in the world"
                    }
                    );
            }
        }
    }
}
