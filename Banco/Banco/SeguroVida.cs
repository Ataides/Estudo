using Banco.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class SeguroVida : Conta, ITributavel
    {
        public override void Deposita(double valorOperacao)
        {
            MovimentaSaldo(valorOperacao + 0.05);
        }

        public override void Saca(double valorOperacao)
        {
            throw new NotImplementedException();
        }

        double ITributavel.CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
