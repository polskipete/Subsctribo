namespace Subsctribo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsPremiumToMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "IsPremium", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "IsPremium");
        }
    }
}
