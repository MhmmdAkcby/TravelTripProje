namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hakkimizdas", "Aciklama", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hakkimizdas", "Aciklama", c => c.Int(nullable: false));
        }
    }
}
