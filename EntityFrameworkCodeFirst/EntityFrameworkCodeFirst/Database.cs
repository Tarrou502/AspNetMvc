
using EntityFrameworkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityFrameworkCodeFirst
{
    class Database: DbContext
    {
        public IDbSet<Produto> Produtos { get; set; }
        public IDbSet<Categoria> Categorias { get; set; }
        public IDbSet<Fornecedor> Fornecedores { get; set; }

    }
}