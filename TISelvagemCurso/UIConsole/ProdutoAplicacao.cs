using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    public class ProdutoAplicacao
    {
        public DbSelvagem db { get; set; }

        public ProdutoAplicacao()
        {
            db = new DbSelvagem();
        }

        public void Salvar(Produto produto)
        {
            db.Produtos.Add(produto);
            db.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return db.Produtos.ToList();
        }

        public void Alterar(Produto produto)
        {
            Produto ProdutoSalvar = db.Produtos.Where(x=>x.Id == produto.Id).First();
            ProdutoSalvar.Nome = produto.Nome;
            db.SaveChanges();
        }

        public void Excluir(int codigo)
        {            
            Produto ProdutoSalvar = db.Produtos.Where(x => x.Id == codigo).First();            
            db.Set<Produto>().Remove(ProdutoSalvar);
            db.SaveChanges();
        }
    }
}
