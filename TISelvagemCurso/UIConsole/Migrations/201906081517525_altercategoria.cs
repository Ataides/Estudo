namespace UIConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altercategoria : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtoes", newName: "Produto");
            AddColumn("dbo.Produto", "Categoria", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Categoria");
            RenameTable(name: "dbo.Produto", newName: "Produtoes");
        }
    }
}
