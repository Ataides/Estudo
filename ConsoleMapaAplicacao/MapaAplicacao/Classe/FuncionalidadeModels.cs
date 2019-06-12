using MapaDeAplicacoes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaAplicacao.Classe
{
    [Table("Funcionalidade")]
    public class FuncionalidadeModels
    {
        [Key]
        public int FuncionalidadeId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public int ObjetoId { get; set; }

        public ObjetoModels ObjetoModels { get; set; }
    }
}
