namespace Banco
{
    public class Cliente
    {        
        public string NomeCliente { get; set; }
        public string cpf { get; set; }
        public string documentos { get; set; }
        public int idade { get; set; }

        public Cliente(string nome)
        {
            this.NomeCliente = nome;
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

        
    }
}