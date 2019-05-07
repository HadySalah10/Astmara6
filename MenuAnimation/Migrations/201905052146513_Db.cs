namespace Astmara6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Db : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Subjects", "Academic", c => c.Int());
            AlterColumn("dbo.Subjects", "Virtual", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subjects", "Virtual", c => c.Int(nullable: false));
            AlterColumn("dbo.Subjects", "Academic", c => c.Int(nullable: false));
        }
    }
}
