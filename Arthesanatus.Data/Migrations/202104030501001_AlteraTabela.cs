namespace Arthesanatus.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraTabela : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Receita",
                c => new
                    {
                        ReceitaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        RevistaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReceitaId)
                .ForeignKey("dbo.Revista", t => t.RevistaId, cascadeDelete: true)
                .Index(t => t.RevistaId);
            
            CreateTable(
                "dbo.Revista",
                c => new
                    {
                        RevistaID = c.Int(nullable: false, identity: true),
                        NumeroEdicao = c.Int(nullable: false),
                        AnoEdicaoo = c.Int(nullable: false),
                        MesEdicao = c.Int(nullable: false),
                        Tema = c.String(),
                        Foto = c.Binary(),
                    })
                .PrimaryKey(t => t.RevistaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receita", "RevistaId", "dbo.Revista");
            DropIndex("dbo.Receita", new[] { "RevistaId" });
            DropTable("dbo.Revista");
            DropTable("dbo.Receita");
        }
    }
}
