namespace MeuEcommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Compra_CompraItens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataCompra = c.DateTime(nullable: false),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.CompraItens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrecoUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantidade = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                        Compra_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtos", t => t.ProdutoId, cascadeDelete: true)
                .ForeignKey("dbo.Compras", t => t.Compra_Id)
                .Index(t => t.ProdutoId)
                .Index(t => t.Compra_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.CompraItens", "Compra_Id", "dbo.Compras");
            DropForeignKey("dbo.CompraItens", "ProdutoId", "dbo.Produtos");
            DropIndex("dbo.CompraItens", new[] { "Compra_Id" });
            DropIndex("dbo.CompraItens", new[] { "ProdutoId" });
            DropIndex("dbo.Compras", new[] { "Cliente_Id" });
            DropTable("dbo.CompraItens");
            DropTable("dbo.Compras");
            DropTable("dbo.Clientes");
        }
    }
}
