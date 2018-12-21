using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuEcommerce.Models
{
    public class Carrinho
    {
        public Dictionary<int, CarrinhoItem> Itens;
           

        public Carrinho()
        {
            Itens =  new Dictionary<int, CarrinhoItem>();
        }
        public decimal PrecoTotal
            => Itens.Sum(i => i.Value.PrecoTotal);

        public int QuantidadeDeItens => Itens.Values.Sum(item => item.Quantidade);

        public void Limpar()
        {
            Itens.Clear();
        }

        public void Add(Produto produto)
        {
            if (Itens.ContainsKey(produto.Id))
            {
                Itens[produto.Id].Quantidade++;
            }
            else
            {
                var carrinhoItem = new CarrinhoItem(
                        produto.Id,
                        produto.Nome,
                        produto.Preco);

                Itens.Add(produto.Id, carrinhoItem);

               /* Itens.Add(produto.Id, new CarrinhoItem
                {
                    IdProduto = produto.Id,
                    PrecoUnitario = produto.Preco,
                    Nome = produto.Nome,
                    Quantidade = 1
                });
                */
            }
        }

        public CarrinhoItem GetItem(int id)
        {
            return Itens[id];
        }

        public void SetItem(CarrinhoItem produto)
        {
            Itens[produto.IdProduto] = produto;
        }

        public void Remove(int id)
        {
            Itens.Remove(id);
        }

        public void  Decrementa (int id)
        {
            //throw new NotImplementedException;
            
            if (Itens[id].Quantidade == 1)
                Remove(id);
            else
                Itens[id].Quantidade--;

        }
        public void Incrementa(int id)
        {
            Itens[id].Quantidade++;
        }
        /*
        public decimal PrecoTotal()
        {
            decimal resultado = 0;
            foreach (var item in Itens.Values)
            {
                resultado += item.PrecoTotal;
            }
            return resultado;
        }*/
    }


    public class CarrinhoItem
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        // Somente leitura get
        public decimal PrecoTotal => PrecoUnitario * Quantidade;

        public CarrinhoItem(
            int idProduto,
            string nome,
            decimal precoUnitario)
        {
            this.IdProduto = idProduto;
            this.Quantidade = 1;
            this.Nome = nome;
            this.PrecoUnitario = precoUnitario;
        }

        
    }
}


