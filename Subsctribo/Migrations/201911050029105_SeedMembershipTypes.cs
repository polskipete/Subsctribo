namespace Subsctribo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (1, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (2, 15, 1)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (3, 40, 4)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths) VALUES (4, 60, 12)");
        }
        
        public override void Down()
        {
        }
    }
}
