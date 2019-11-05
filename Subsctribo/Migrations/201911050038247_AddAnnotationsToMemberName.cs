﻿namespace Subsctribo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsToMemberName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "Name", c => c.String());
        }
    }
}
