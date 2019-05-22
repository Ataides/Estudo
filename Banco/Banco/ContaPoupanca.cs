using Banco.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public double Total { get; private set; }

        public ContaPoupanca()
        {

        }        

        public override void Saca(double valorOperacao)
        {
            MovimentaSaldo((valorOperacao + 0.10) * -1);
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
