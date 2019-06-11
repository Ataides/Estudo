using MapaDeAplicacoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaAplicacao.Classe.app
{
    public class RepositorioApp
    {
        public MapaAplicacaoContex DbContext { get; set; }
        public RepositorioApp()
        {
            DbContext = new MapaAplicacaoContex();
        }

        public void Incluir(RepositorioModels repositorio)
        {
            DbContext.RepositorioModels.Add(repositorio);
            DbContext.SaveChanges();
        }

        public void Alterar()
        {
            DbContext.SaveChanges();
        }

        public RepositorioModels Listar(int codigoRepositorio)
        {
            return DbContext.RepositorioModels.Where(x=> x.RepositorioId == codigoRepositorio).First();
        }
    }
}
