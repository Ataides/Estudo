using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapaDeAplicacoes.Models
{
    [Table("Tecnologia")]
    public class TecnologiaModels
    {
        [Key]
        public int TecnologiaId { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "Campo com no máximo 50 caracteres!"), MinLength(1, ErrorMessage = "Campo com no mínimo 1 caracteres!")]
        public string Nome { get; set; }

        public virtual ICollection<ObjetoTecnologiaModels> ObjetoTecnologias { get; set; }

    }
}