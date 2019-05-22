using System;

namespace Banco
{
    public abstract class Conta
    {
        public Conta()
        {

        }

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public string Nome { get; set; }
        public Cliente Titular { get; set; }

        //public virtual void Deposita(double valorOperacao)
        //{
        //    this.Saldo += valorOperacao;
        //}

        //public virtual void Saca(double valorOperacao)
        //{
        //    this.Saldo -= valorOperacao;
        //}

        public abstract void Deposita(double valorOperacao);
        public abstract void Saca(double valorOperacao);

        public void MovimentaSaldo(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }
    }
}