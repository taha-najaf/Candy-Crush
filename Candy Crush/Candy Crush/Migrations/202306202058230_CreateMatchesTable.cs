namespace Candy_Crush.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMatchesTable : DbMigration
    {
       
        public override void Up()
        {
            CreateTable(
                "dbo.ContestApplications",
                c => new
                {
                    ApplicantId = c.Int(nullable: false, identity: true),
                    FriendId = c.Int(nullable: false),
                    UserId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ApplicantId);
        }

        public override void Down()
        {
            DropTable("dbo.ContestApplications");
        }
    }
}
