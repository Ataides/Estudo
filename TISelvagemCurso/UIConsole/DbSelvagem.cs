using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class DbSelvagem : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
