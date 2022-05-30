namespace TaxiWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Entity_Order : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        FromAddress = c.String(nullable: false),
                        ToAddress = c.String(nullable: false),
                        ClientID = c.String(nullable: false),
                        OrderDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
