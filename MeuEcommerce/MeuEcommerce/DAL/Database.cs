using MeuEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MeuEcommerce.DAL
{



    public class Database:DbContext
    {
        public IDbSet<Categoria> Categorias { get; set; }
        public IDbSet<Produto> Produtos { get; set; }
      
        


        public Database()
        {
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

    
    
    
    
    /*    public class Database
        {

            static Categoria[] _categorias;
            public Categoria[] GetCategorias()
            {
                if (_categorias == null)
                {
                    _categorias = new Models.Categoria[]
                    {
                        new Models.Categoria(1,"Smartphones"),
                        new Models.Categoria(2,"TVs"),
                        new Models.Categoria(3,"Video Games"),
                        new Models.Categoria(4,"Notebooks")
                    };

                }
                return _categorias;
            }


            static Produto[] _produtos;
            public Produto[] GetProdutos()
            {
                if (_produtos == null)
                {
                    _produtos = new Models.Produto[]
                    {
                    new Models.Produto("IPhone",1,"IPhone",1),
                    new Models.Produto("Tv Led",2,"TvLed",2),
                    new Models.Produto("Playstation 4",3,"Playstation4",3),
                    new Models.Produto("Notebook Dell 17",4,"NotebookDell",4),
                    new Models.Produto("Notebook Samsung 15",5,"NotebookSamsung",4),
                    new Models.Produto("SmartPhone S9",6,"S9preto",1),
                    new Models.Produto("Smart TV Samsung 55",7,"TvSamsung55",2),
                    new Models.Produto("Xbox One",8,"XboxOne",3),
                    new Models.Produto("Notebook Apple Macbook",9,"NotebookAppleMacbook",4),
                    new Models.Produto("Smart TV Led Philco 39",10,"TvPhilco39",2),
                    new Models.Produto("Nintendo Wii",11,"NintendoWii",3),
                      new Models.Produto("Smart Phone Lg G7",12,"SmartPhoneLgG7",1)



                    };
                }
                return _produtos;
            }

            public Produto GetProdutoPorId(int id)
            {
                var todosOsProdutos = GetProdutos();

                  //foreach (var item in todosOsProdutos)
                  //{
                  //    if (item.Id == id)
                  //    {
                  //        return item;
                  //    }
                  //}
                  //return null;


                return todosOsProdutos.First(item => item.Id == id);
            }
        }
        */
        }