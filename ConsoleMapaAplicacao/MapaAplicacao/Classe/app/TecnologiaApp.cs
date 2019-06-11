using MapaDeAplicacoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaAplicacao.Classe
{
    public class TecnologiaApp
    {
        public MapaAplicacaoContex DbContext { get; set; }

        public TecnologiaApp()
        {
            DbContext = new MapaAplicacaoContex();
        }

        public void Incluir(TecnologiaModels tecnologia)
        {
            DbContext.TecnologiaModels.Add(tecnologia);
            DbContext.SaveChanges();
        }

        public IEnumerable<TecnologiaModels> Listar()
        {
            return DbContext.TecnologiaModels.ToList();
        }
    }
}
