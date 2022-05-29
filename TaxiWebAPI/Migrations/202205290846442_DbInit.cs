namespace TaxiWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        PhoneNumber = c.String(nullable: false),
                        ClientAddress = c.String(),
                        ClientDateOfBirth = c.DateTime(),
                    })
                .PrimaryKey(t => t.ClientID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
