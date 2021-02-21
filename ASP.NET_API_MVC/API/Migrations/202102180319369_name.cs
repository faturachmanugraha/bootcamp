namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tb_M_Item", "Name", c => c.String());
            DropColumn("dbo.Tb_M_Item", "Nama");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tb_M_Item", "Nama", c => c.String());
            DropColumn("dbo.Tb_M_Item", "Name");
        }
    }
}
