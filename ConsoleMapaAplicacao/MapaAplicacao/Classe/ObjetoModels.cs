using MapaAplicacao.Classe;
using MapaDeAplicacoes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MapaDeAplicacoes.Models
{
    [Table("Objeto")]
    public class ObjetoModels
    {
        [Key]
        public int ObjetoId { get; set; }
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [MaxLength(30, ErrorMessage = "Campo com no máximo 30 caracteres!"), MinLength(1, ErrorMessage = "Campo com no mínimo 1 caracteres!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Descrição é obrigatório")]
        [MaxLength(100, ErrorMessage = "Campo com no máximo 50 caracteres!"), MinLength(1, ErrorMessage = "Campo com no mínimo 1 caracteres!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo Data criação objeto é obrigatório")]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacaoObjeto { get; set; }

        public int RepositorioId { get; set; }
                
        public RepositorioModels RepositorioModels { get; set; }

        public virtual ICollection<ObjetoTecnologiaModels> ObjetoTecnologias { get; set; }

        [Column("SubObjetoId")]
        public virtual ICollection<ObjetoModels> SubObjetos { get; set; }

        public virtual ICollection<FuncionalidadeModels> Funcionalidades { get; set; }

    }
}