
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityFrameworkCodeFirst.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public int CategoriaId { get; set; }
        public int FornecedorId { get; set; }
    }
}