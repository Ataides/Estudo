using System;

namespace Banco
{
    public class Cliente
    {        
        public string NomeCliente { get; set; }
        public string cpf { get; set; }
        public string Rg { get; set; }
        public string documentos { get; set; }
        public int idade { get; set; }

        public Cliente(string nome)
        {
            this.NomeCliente = nome;
        }

        public override bool Equals(Object obj)
        {
            Cliente outroCliente = (Cliente)obj;
            return this.NomeCliente == outroCliente.NomeCliente && this.Rg == outroCliente.Rg;
        }

        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.idade >= 18;
                var emancipado = this.documentos.Contains("emancipacao");
                var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }

        public static string ComparaClienteExercicio()
        {
            Cliente guilherme = new Cliente("Guilherme Silveira");
            guilherme.Rg = "12345678-9";
            Cliente mauricio = new Cliente("Mauricio Aniche");
            mauricio.Rg = "12345678-9";

            if (guilherme.Equals(guilherme))
            {
                return "São o mesmo cliente";
            }
            else
            {
                return "Não são o mesmo cliente";
            }
        }
    }
}