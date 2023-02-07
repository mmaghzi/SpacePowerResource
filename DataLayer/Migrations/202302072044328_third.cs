namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Facilities", "FuseValue", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Facilities", "FuseValue", c => c.Short(nullable: false));
        }
    }
}
