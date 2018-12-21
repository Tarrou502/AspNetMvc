namespace MeuEcommerce.Migrations
{
    using MeuEcommerce.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MeuEcommerce.DAL.Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MeuEcommerce.DAL.Database context)
        {
            context.Categorias.AddOrUpdate(
                new Categoria(1,"SmartPhones"),
                new Categoria(2, "TVs"),
                new Categoria(3, "Video Games"),
                new Categoria(4, "Notebooks")
                );
            context.SaveChanges();
        }
    }
}
