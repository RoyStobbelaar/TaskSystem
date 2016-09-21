namespace TaskSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedtaskmodelwithcompletiondate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "CompletionTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "CompletionTime", c => c.DateTime(nullable: false));
        }
    }
}
