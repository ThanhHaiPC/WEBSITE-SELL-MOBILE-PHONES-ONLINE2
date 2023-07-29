namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecomment3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Comment", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Comment", "UserId", c => c.Int(nullable: false));
        }
    }
}
