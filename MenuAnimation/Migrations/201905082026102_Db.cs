namespace Astmara6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdSection = c.Int(),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.IdSection)
                .Index(t => t.IdSection);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfSection = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentStatments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdLevel = c.Int(),
                        IdBranch = c.Int(),
                        IdSubject = c.Int(),
                        NumberOfStudent = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.IdBranch)
                .ForeignKey("dbo.Levels", t => t.IdLevel)
                .ForeignKey("dbo.Subjects", t => t.IdSubject)
                .Index(t => t.IdLevel)
                .Index(t => t.IdBranch)
                .Index(t => t.IdSubject);
            
            CreateTable(
                "dbo.Levels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 100),
                        Academic = c.Int(),
                        Virtual = c.Int(),
                        Exprement = c.Int(),
                        TotalHours = c.Int(),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubjectTeachers",
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
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NickName = c.String(maxLength: 100),
                        IdWorkHours = c.Int(),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WorkHours", t => t.IdWorkHours)
                .Index(t => t.IdWorkHours);
            
            CreateTable(
                "dbo.WorkHours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rank = c.String(maxLength: 100),
                        HoursOfQuorum = c.Int(),
                        AcademicOrVirtual = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(nullable: false, maxLength: 50),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentStatments", "IdSubject", "dbo.Subjects");
            DropForeignKey("dbo.SubjectTeachers", "IdTeacher", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "IdWorkHours", "dbo.WorkHours");
            DropForeignKey("dbo.SubjectTeachers", "IdSubject", "dbo.Subjects");
            DropForeignKey("dbo.SubjectTeachers", "IdBranch", "dbo.Branches");
            DropForeignKey("dbo.StudentStatments", "IdLevel", "dbo.Levels");
            DropForeignKey("dbo.StudentStatments", "IdBranch", "dbo.Branches");
            DropForeignKey("dbo.Branches", "IdSection", "dbo.Sections");
            DropIndex("dbo.Teachers", new[] { "IdWorkHours" });
            DropIndex("dbo.SubjectTeachers", new[] { "IdTeacher" });
            DropIndex("dbo.SubjectTeachers", new[] { "IdSubject" });
            DropIndex("dbo.SubjectTeachers", new[] { "IdBranch" });
            DropIndex("dbo.StudentStatments", new[] { "IdSubject" });
            DropIndex("dbo.StudentStatments", new[] { "IdBranch" });
            DropIndex("dbo.StudentStatments", new[] { "IdLevel" });
            DropIndex("dbo.Branches", new[] { "IdSection" });
            DropTable("dbo.Users");
            DropTable("dbo.WorkHours");
            DropTable("dbo.Teachers");
            DropTable("dbo.SubjectTeachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Levels");
            DropTable("dbo.StudentStatments");
            DropTable("dbo.Sections");
            DropTable("dbo.Branches");
        }
    }
}
