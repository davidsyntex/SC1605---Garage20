namespace SC1605___Garage20.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "ParkedDate", c => c.DateTime());
            AddColumn("dbo.Vehicles", "EndParkedDate", c => c.DateTime());
            AlterColumn("dbo.Vehicles", "Owner", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "RegistrationNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "Color", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Color", c => c.String());
            AlterColumn("dbo.Vehicles", "RegistrationNumber", c => c.String());
            AlterColumn("dbo.Vehicles", "Owner", c => c.String());
            DropColumn("dbo.Vehicles", "EndParkedDate");
            DropColumn("dbo.Vehicles", "ParkedDate");
        }
    }
}
