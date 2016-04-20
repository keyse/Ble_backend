namespace WebAPIs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transferes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SendAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SenderName = c.String(),
                        RecieverName = c.String(),
                        CollectionDestination = c.String(),
                        CollectionPassCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transferes");
        }
    }
}
