namespace Candy_Crush.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        FriendshipId = c.Int(nullable: false, identity: true),
                        PlayerId = c.Int(nullable: false),
                        FriendId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FriendshipId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Friends");
        }
    }
}
