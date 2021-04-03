namespace Arthesanatus.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraTabela1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Revista", "AnoEdicao", c => c.Int(nullable: false));
            DropColumn("dbo.Revista", "AnoEdicaoo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Revista", "AnoEdicaoo", c => c.Int(nullable: false));
            DropColumn("dbo.Revista", "AnoEdicao");
        }
    }
}
