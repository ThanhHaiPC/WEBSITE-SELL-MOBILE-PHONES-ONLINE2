﻿namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecomment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Comment", "Rate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Comment", "Rate");
        }
    }
}
