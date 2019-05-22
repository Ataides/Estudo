using Banco.Interface;
using System;

namespace Banco
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public override void Deposita(double valorOperacao)
        {
            MovimentaSaldo(valorOperacao + 0.10);
        }

        public override void Saca(double valorOperacao)
        {
            throw new NotImplementedException();
        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
