
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityFrameworkCodeFirst.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}