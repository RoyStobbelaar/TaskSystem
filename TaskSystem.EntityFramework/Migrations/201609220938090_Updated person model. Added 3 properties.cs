namespace TaskSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedpersonmodelAdded3properties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "FirstName", c => c.String());
            AddColumn("dbo.People", "LastName", c => c.String());
            AddColumn("dbo.People", "EmailAddress", c => c.String());
            AddColumn("dbo.People", "Gender", c => c.String());
            DropColumn("dbo.People", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Name", c => c.String());
            DropColumn("dbo.People", "Gender");
            DropColumn("dbo.People", "EmailAddress");
            DropColumn("dbo.People", "LastName");
            DropColumn("dbo.People", "FirstName");
        }
    }
}
