using Banco;
using System;

namespace Estudo.Banco.Contas
{
    public class ContaCorrente : Conta
    {
        private static int totalDeContas = 0;

        public ContaCorrente()
        {
            totalDeContas++;
        }

        public override void Saca(double valorOperacao)
        {
            if (valorOperacao < 0.0)
            {
                throw new ArgumentException();
            }
            if (valorOperacao + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                MovimentaSaldo((valorOperacao + 0.05) * -1);
            }
        }

        public override void Deposita(double valorOperacao)
        {
            if (valorOperacao < 0.0)
            {
                throw new ArgumentException();
            }
            MovimentaSaldo(valorOperacao + 0.10);
        }

        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }
    }
}
