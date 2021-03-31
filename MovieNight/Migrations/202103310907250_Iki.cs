namespace MovieNight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Iki : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Actors", c => c.String());
            DropColumn("dbo.Movies", "Actor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Actor", c => c.String());
            DropColumn("dbo.Movies", "Actors");
        }
    }
}
