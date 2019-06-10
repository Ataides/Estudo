using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MapaDeAplicacoes.Models
{
    [Table("ObjetoTecnologia")]
    public class ObjetoTecnologiaModels
    {
        [Key]
        public int ObjetoTecnologiaId { get; set; }
        public int ObjetoId { get; set; }
        public int TecnologiaId { get; set; }
        public virtual ObjetoModels Objeto { get; set; }
        public virtual TecnologiaModels Tecnologia { get; set; }
    }
}