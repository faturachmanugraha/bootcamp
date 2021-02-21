namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tb_M_Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nama = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Tb_M_Supplier",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tb_M_Item", "SupplierId", "dbo.Tb_M_Supplier");
            DropIndex("dbo.Tb_M_Item", new[] { "SupplierId" });
            DropTable("dbo.Tb_M_Supplier");
            DropTable("dbo.Tb_M_Item");
        }
    }
}
