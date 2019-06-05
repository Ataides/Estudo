namespace MapaDeAplicacoes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnFirstName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Objeto",
                c => new
                    {
                        ObjetoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        DataCriacaoObjeto = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ObjetoId);
            
            CreateTable(
                "dbo.ObjetoTecnologia",
                c => new
                    {
                        ObjetoTecnologiaId = c.Int(nullable: false, identity: true),
                        ObjetoId = c.Int(nullable: false),
                        TecnologiaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ObjetoTecnologiaId)
                .ForeignKey("dbo.Objeto", t => t.ObjetoId)
                .ForeignKey("dbo.Tecnologia", t => t.TecnologiaId)
                .Index(t => t.ObjetoId)
                .Index(t => t.TecnologiaId);
            
            CreateTable(
                "dbo.Tecnologia",
                c => new
                    {
                        TecnologiaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.TecnologiaId);
            
            CreateTable(
                "dbo.RepositorioObjeto",
                c => new
                    {
                        RepositorioObjetoId = c.Int(nullable: false, identity: true),
                        ObjetoId = c.Int(nullable: false),
                        RepositorioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RepositorioObjetoId)
                .ForeignKey("dbo.Objeto", t => t.ObjetoId)
                .ForeignKey("dbo.Repositorio", t => t.RepositorioId)
                .Index(t => t.ObjetoId)
                .Index(t => t.RepositorioId);
            
            CreateTable(
                "dbo.Repositorio",
                c => new
                    {
                        RepositorioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        DataCriacao = c.DateTime(),
                    })
                .PrimaryKey(t => t.RepositorioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RepositorioObjeto", "RepositorioId", "dbo.Repositorio");
            DropForeignKey("dbo.RepositorioObjeto", "ObjetoId", "dbo.Objeto");
            DropForeignKey("dbo.ObjetoTecnologia", "TecnologiaId", "dbo.Tecnologia");
            DropForeignKey("dbo.ObjetoTecnologia", "ObjetoId", "dbo.Objeto");
            DropIndex("dbo.RepositorioObjeto", new[] { "RepositorioId" });
            DropIndex("dbo.RepositorioObjeto", new[] { "ObjetoId" });
            DropIndex("dbo.ObjetoTecnologia", new[] { "TecnologiaId" });
            DropIndex("dbo.ObjetoTecnologia", new[] { "ObjetoId" });
            DropTable("dbo.Repositorio");
            DropTable("dbo.RepositorioObjeto");
            DropTable("dbo.Tecnologia");
            DropTable("dbo.ObjetoTecnologia");
            DropTable("dbo.Objeto");
        }
    }
}
