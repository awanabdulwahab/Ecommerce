namespace EcommerceDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CatagoryModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProductModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Description = c.String(),
                        Catagory_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CatagoryModels", t => t.Catagory_id)
                .Index(t => t.Catagory_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductModels", "Catagory_id", "dbo.CatagoryModels");
            DropIndex("dbo.ProductModels", new[] { "Catagory_id" });
            DropTable("dbo.ProductModels");
            DropTable("dbo.CatagoryModels");
        }
    }
}
