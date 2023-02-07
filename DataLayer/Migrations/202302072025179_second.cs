namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facilities", "FuseValue", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Facilities", "FuseValue");
        }
    }
}
