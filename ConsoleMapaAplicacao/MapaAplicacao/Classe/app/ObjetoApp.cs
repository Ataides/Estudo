using MapaDeAplicacoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaAplicacao.Classe
{
    public class ObjetoApp
    {
        public MapaAplicacaoContex DbContext { get; set; }

        public ObjetoApp()
        {
            DbContext = new MapaAplicacaoContex();
        }

        public ObjetoModels Incluir(ObjetoModels objeto)
        {
            DbContext.ObjetoModels.Add(objeto);
            int codigo = DbContext.SaveChanges();
            return Listar(codigo);
        } 
        
        public ObjetoModels Listar(int codigo)
        {
            return DbContext.ObjetoModels.Where(x => x.ObjetoId == codigo).First();
        }      
        
    }
}
