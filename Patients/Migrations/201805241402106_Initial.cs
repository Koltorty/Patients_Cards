namespace Patients.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VisitDate = c.DateTime(nullable: false),
                        Diagnosis = c.String(nullable: false),
                        VisitType = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visits", "PatientId", "dbo.Patients");
            DropIndex("dbo.Visits", new[] { "PatientId" });
            DropTable("dbo.Visits");
            DropTable("dbo.Patients");
        }
    }
}
