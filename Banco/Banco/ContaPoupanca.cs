using Banco;
using Banco.Interface;
using System;

namespace Estudo.Banco.Contas
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public double Total { get; private set; }

        public ContaPoupanca()
        {

        }        

        public override void Saca(double valorOperacao)
        {
            if (valorOperacao < 0.0)
            {
                throw new SaldoInsuficienteException();
            }
            if (valorOperacao + 0.10 > this.Saldo)
            {
                throw new Exception("Valor do saque maior que o saldo");
            }
            else
            {
                MovimentaSaldo((valorOperacao + 0.10) * -1);
            }
        }

        public void CalculaRendimento()
        {
            // ...
        }

        public override void Deposita(double valorOperacao)
        {
            MovimentaSaldo(valorOperacao);
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

        public void Acumula(ContaPoupanca cp)
        {
            Total += cp.CalculaTributo();
        }
    }
}
