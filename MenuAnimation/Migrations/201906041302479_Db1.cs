namespace Astmara6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Db1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubjectTeacherLoads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdBranch = c.Int(),
                        IdSubject = c.Int(),
                        IdTeacher = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.IdBranch)
                .ForeignKey("dbo.Subjects", t => t.IdSubject)
                .ForeignKey("dbo.Teachers", t => t.IdTeacher)
                .Index(t => t.IdBranch)
                .Index(t => t.IdSubject)
                .Index(t => t.IdTeacher);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectTeacherLoads", "IdTeacher", "dbo.Teachers");
            DropForeignKey("dbo.SubjectTeacherLoads", "IdSubject", "dbo.Subjects");
            DropForeignKey("dbo.SubjectTeacherLoads", "IdBranch", "dbo.Branches");
            DropIndex("dbo.SubjectTeacherLoads", new[] { "IdTeacher" });
            DropIndex("dbo.SubjectTeacherLoads", new[] { "IdSubject" });
            DropIndex("dbo.SubjectTeacherLoads", new[] { "IdBranch" });
            DropTable("dbo.SubjectTeacherLoads");
        }
    }
}
