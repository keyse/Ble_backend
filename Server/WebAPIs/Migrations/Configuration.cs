using DomainModels;

namespace WebAPIs.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPIs.Models.BoleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPIs.Models.BoleDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Transferes.AddOrUpdate(p => p.Id,
              new Transfere() {SenderName = "MO", ReceiverName = "Jamal", ReceiverDestination = "VA", SendAmount = 100.00M, SendDate = DateTime.UtcNow},
              new Transfere() { SenderName = "Sender1", ReceiverName = "Cust1", ReceiverDestination = "ADDIS", SendAmount = 500, SendDate = DateTime.UtcNow.AddDays(-1) },
              new Transfere() { SenderName = "Sender1", ReceiverName = "Cust2", ReceiverDestination = "MAKALE", SendAmount = 1500, SendDate = DateTime.UtcNow.AddDays(-2) },
               new Transfere() { SenderName = "Sender2", ReceiverName = "Cust3", ReceiverDestination = "AXIUM", SendAmount = 2500, SendDate = DateTime.UtcNow }
            );
            //
        }
    }
}
