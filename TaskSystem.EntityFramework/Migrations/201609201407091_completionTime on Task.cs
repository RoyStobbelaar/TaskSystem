namespace TaskSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class completionTimeonTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "CompletionTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "CompletionTime");
        }
    }
}
