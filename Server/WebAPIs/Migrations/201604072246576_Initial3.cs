namespace WebAPIs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transferes", "ReceiverName", c => c.String());
            AddColumn("dbo.Transferes", "ReceiverDestination", c => c.String());
            AddColumn("dbo.Transferes", "ReceiverPassCode", c => c.String());
            DropColumn("dbo.Transferes", "RecieverName");
            DropColumn("dbo.Transferes", "CollectionDestination");
            DropColumn("dbo.Transferes", "CollectionPassCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transferes", "CollectionPassCode", c => c.String());
            AddColumn("dbo.Transferes", "CollectionDestination", c => c.String());
            AddColumn("dbo.Transferes", "RecieverName", c => c.String());
            DropColumn("dbo.Transferes", "ReceiverPassCode");
            DropColumn("dbo.Transferes", "ReceiverDestination");
            DropColumn("dbo.Transferes", "ReceiverName");
        }
    }
}
