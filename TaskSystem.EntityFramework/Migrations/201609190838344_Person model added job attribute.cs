namespace TaskSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Personmodeladdedjobattribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Job", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Job");
        }
    }
}
