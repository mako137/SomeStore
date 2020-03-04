namespace SomeStoreDBCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteWrongField : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "StatsId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "StatsId", c => c.Int(nullable: false));
        }
    }
}
