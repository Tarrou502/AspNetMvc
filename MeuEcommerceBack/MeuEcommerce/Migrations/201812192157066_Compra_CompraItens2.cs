namespace MeuEcommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Compra_CompraItens2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Compras", "Data", c => c.DateTime(nullable: false));
            DropColumn("dbo.Compras", "DataCompra");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Compras", "DataCompra", c => c.DateTime(nullable: false));
            DropColumn("dbo.Compras", "Data");
        }
    }
}
