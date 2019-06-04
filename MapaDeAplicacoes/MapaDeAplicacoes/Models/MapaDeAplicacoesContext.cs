using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MapaDeAplicacoes.Models
{
    public class MapaDeAplicacoesContext : DbContext
    {
        public MapaDeAplicacoesContext() : base("DefaultConnection")
        {

        }

        //DESABILITAR CASCATAS
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<MapaDeAplicacoes.Models.RepositorioModels> RepositorioModels { get; set; }

        public System.Data.Entity.DbSet<MapaDeAplicacoes.Models.TecnologiaModels> TecnologiaModels { get; set; }

        public System.Data.Entity.DbSet<MapaDeAplicacoes.Models.ObjetoModels> ObjetoModels { get; set; }

        //public System.Data.Entity.DbSet<MapaDeAplicacoes.Models.ObjetoTecnologiasModels> ObjetoTecnologiasModels { get; set; }
    }
}