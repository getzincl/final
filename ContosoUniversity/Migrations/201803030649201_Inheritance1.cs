namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inheritance1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Person", newName: "Address");
            AlterColumn("dbo.Address", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Address", "FirstName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Address", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Address", "LastName", c => c.String(nullable: false, maxLength: 50));
            RenameTable(name: "dbo.Address", newName: "Person");
        }
    }
}
