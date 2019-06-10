using MapaDeAplicacoes.Models;
using System.Data.Entity;

namespace MapaAplicacao.Classe
{
    public class MapaAplicacaoContex : DbContext
    {
        public DbSet<RepositorioModels> RepositorioModels { get; set; }
        public DbSet<TecnologiaModels> TecnologiaModels { get; set; }
        public DbSet<ObjetoModels> ObjetoModels { get; set; }
        public DbSet<ObjetoTecnologiaModels> ObjetoTecnologiasModels { get; set; }

        public MapaAplicacaoContex() : base("DefaultConnection")
        {

        }
    }
}
