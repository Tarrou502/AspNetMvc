
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityFrameworkCodeFirst.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public String Nome { get;set; }

        public List <Produto> Produtos;
    }
}