using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapaDeAplicacoes.Models
{
    [Table("Repositorio")]
    public class RepositorioModels
    {      

        [Key]        
        public int RepositorioId { get; set; }
        [Required(ErrorMessage ="Campo nome é obrigatório")]
        [MaxLength(30, ErrorMessage ="Campo com no máximo 15 caracteres!"), MinLength(5, ErrorMessage = "Campo com no mínimo 15 caracteres!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        [MaxLength(100, ErrorMessage = "Campo com no máximo 50 caracteres!"), MinLength(5, ErrorMessage = "Campo com no mínimo 5 caracteres!")]
        public string Descricao { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DataCriacao { get; set; }

        public virtual ICollection<ObjetoModels> Objeto { get; set; }

    }
}