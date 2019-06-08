using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{    
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=Gs9FaIyba28
            ProdutoAplicacao app = new ProdutoAplicacao();

            RemoverProduto(1);


            AlterarProduto(2, "Feijão de corda preto importado");

            Produto produto = new Produto();            
            produto.Nome = "Macacheira roxa";

            app.Salvar(produto);

            IEnumerable<Produto> produtosBanco = app.Listar();

            foreach (Produto item in produtosBanco)
            {
                Console.WriteLine("{0} / {1}", item.Id, item.Nome);
            } 
            
            Console.ReadKey();
        }

        private static void RemoverProduto(int codigo)
        {
            ProdutoAplicacao app = new ProdutoAplicacao();
            app.Listar();
            app.Excluir(codigo);
        }

        private static void AlterarProduto(int codigo, string nome)
        {
            ProdutoAplicacao app = new ProdutoAplicacao();
            Produto produto = new Produto();
            produto.Id = codigo;

            produto.Nome = nome;

            app.Alterar(produto);
        }
    }
}
