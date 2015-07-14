using System.Data.Entity;

namespace CarwoodsApplication.Models
{
    public class CarwoodsApplicationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CarwoodsApplicationContext() : base("name=CarwoodsApplicationContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CarwoodsApplicationContext>());
        }

        public DbSet<Maker> Makers { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<Automobile> Automobiles { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Country> Countries { get; set; }
    }
}
