namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSpacePowerDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        FacilityId = c.Int(nullable: false, identity: true),
                        FacilityOwner = c.String(nullable: false, maxLength: 50),
                        CityName = c.String(nullable: false, maxLength: 50),
                        StationName = c.String(nullable: false, maxLength: 50),
                        Geography = c.String(nullable: false, maxLength: 50),
                        FacilityName = c.String(nullable: false, maxLength: 60),
                        FcilityPosition = c.String(nullable: false, maxLength: 50),
                        OccupiedArea = c.Single(nullable: false),
                        CurrentKind = c.String(nullable: false, maxLength: 40),
                        CurrentValue = c.Single(nullable: false),
                        PowerSource = c.String(nullable: false, maxLength: 50),
                        Comments = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.FacilityId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Facilities");
        }
    }
}
