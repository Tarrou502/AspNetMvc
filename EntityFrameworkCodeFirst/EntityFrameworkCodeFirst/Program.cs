using EntityFrameworkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var BancodeDados = new Database();
            /*
            var cat1 = new Categoria();
            cat1.Id = 1;
            cat1.Nome = "Categoria 1";
            cat1.Produtos = new List<Produto>()
            {
                new Produto()
                {
                    Id = 1,
                    Nome ="Produto 1",
                    Preco =10
                }
            };

            BancodeDados.Categorias.Add(cat1);
            BancodeDados.SaveChanges();

    */
            var dados = from p in BancodeDados.Categorias
                           select p;
              
              foreach (var linha in dados)
              {
                         Console.WriteLine("{0,-30} - {1}", linha.Id , linha.Nome);
              }
            Console.ReadKey();

        }
    }
}
