namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Address", "CreditsEarned", c => c.Int());
            AddColumn("dbo.Address", "Gpa", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Address", "Gpa");
            DropColumn("dbo.Address", "CreditsEarned");
        }
    }
}
