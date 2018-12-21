using MeuEcommerce.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MeuEcommerce.DAL
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public IDbSet<Categoria> Categorias { get; set; }
        public IDbSet<Produto> Produtos { get; set; }
        public IDbSet<Cliente> Clientes { get; set; }
        public IDbSet<Compra> Compras { get; set; }
        public IDbSet<CompraItem> CompraItens { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public Categoria[] GetCategorias()
        {
            return Categorias.ToArray();

        }

        public Produto[] GetProdutos()
        {
            return Produtos.ToArray();
        }

        public Produto GetProdutoPorId(int id)
        {
            return Produtos.FirstOrDefault(p => p.Id == id);
        }

    }
}