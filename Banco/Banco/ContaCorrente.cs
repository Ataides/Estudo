using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : Conta
    {
        public override void Saca(double valorOperacao)
        {
            MovimentaSaldo((valorOperacao + 0.05) * -1);
        }

        public override void Deposita(double valorOperacao)
        {
            MovimentaSaldo(valorOperacao + 0.10);
        }
    }
}
