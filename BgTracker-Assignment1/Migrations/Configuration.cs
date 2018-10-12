namespace BgTracker_Assignment1.Migrations
{
    using System;
    using System.Data.Entity;
    using BgTracker_Assignment1.Models;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BgTracker_Assignment1.Models.ApplicationDbContext>
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BgTracker_Assignment1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

        context.Sales.AddOrUpdate(i => i.Id, 
                new Models.Sale() {
                    Id = 1,
                    Date = DateTime.Now,
                    Customer = new Customer(),
                    Employee = new Employee(),
                    });

            context.Customers.AddOrUpdate(i => i.Id,
                new Models.Customer() {
                    Id = 1,
                    });

            context.Employees.AddOrUpdate(i => i.Id,
            new Models.Employee()
            {
                Id = 1,
            });
           

        }
    }
}
