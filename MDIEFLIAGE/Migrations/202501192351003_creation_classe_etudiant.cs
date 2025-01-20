namespace MDIEFLIAGE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creation_classe_etudiant : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prenom = c.String(),
                        Nom = c.String(),
                        IdClasse = c.Int(nullable: false),
                        classe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.classe_Id)
                .Index(t => t.classe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Etudiants", "classe_Id", "dbo.Classes");
            DropIndex("dbo.Etudiants", new[] { "classe_Id" });
            DropTable("dbo.Etudiants");
            DropTable("dbo.Classes");
        }
    }
}
