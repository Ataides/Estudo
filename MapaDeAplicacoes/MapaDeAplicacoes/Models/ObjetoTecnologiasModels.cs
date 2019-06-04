using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MapaDeAplicacoes.Models
{
    [Table("ObjetoTecnologia")]
    public class ObjetoTecnologiasModels
    {
        [Key]
        public int ObjetoTecnologiasId { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Selecione um objeto!")]
        public int ObjetoId { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Selecione uma tecnologia!")]
        public int TecnologiaId { get; set; }
                
        //public virtual ICollection<ObjetoModels> Objeto { get; set; }
        //public virtual ICollection<TecnologiaModels> Tecnologia { get; set; }
    }
}