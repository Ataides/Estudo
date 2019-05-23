﻿using Banco;
using Banco.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        private Conta[] contas;
        private int numeroDeContas;

        delegate void Acumula(Conta conta);

        public Form1()
        {
            InitializeComponent();
            //conta = new Conta();
            //conta.Numero = 1;
            //Cliente cliente = new Cliente("victor");
            //conta.Titular = cliente;

            //textoNumero.Text = conta.Titular.NomeCliente;

            //// criando o array para guardar as contas
            //contas = new Conta[3];
            //// vamos inicializar algumas instâncias de Conta.
            //this.contas[0] = new Conta();
            //this.contas[0].Titular = new Cliente("victor");
            //this.contas[0].Numero = 1;
            //this.numeroDeContas++;

            //this.contas[1] = new ContaPoupanca();
            //this.contas[1].Titular = new Cliente("mauricio");
            //this.contas[1].Numero = 2;

            //this.contas[2] = new ContaCorrente();
            //this.contas[2].Titular = new Cliente("osni");
            //this.contas[2].Numero = 3;

            //foreach (Conta conta in contas)
            //{
            //    comboContas.Items.Add(conta.Titular.NomeCliente);
            //}
            this.contas = new Conta[10];
            // vamos inicializar algumas instâncias de Conta.
            Conta c1 = new ContaPoupanca();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);

        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoSaldo.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Deposita(valorOperacao);
            textoValor.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void Depositar_Click(object sender, EventArgs e)
        {
            if (comboContas.SelectedIndex == -1) { return; }
            // primeiro precisamos recuperar o índice da conta selecionada
            int indice = comboContas.SelectedIndex; //Convert.ToInt32(textoIndex.Text);
            // e depois precisamos ler a posição correta do array.
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoSaldo.Text);
            selecionada.Deposita(Convert.ToInt32(textoValor.Text));
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            //textoValor.Text = "";
            comboContas.SelectedIndex = -1;
        }

        private void Saque_Click(object sender, EventArgs e)
        {
            // primeiro precisamos recuperar o índice da conta selecionada
            int indice = comboContas.SelectedIndex; //Convert.ToInt32(textoIndex.Text);
            // e depois precisamos ler a posição correta do array.
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoSaldo.Text);
            selecionada.Saca(Convert.ToInt32(textoValor.Text));
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoValor.Text = "";
        }

        private void Totaliza_Click(object sender, EventArgs e)
        {
            Conta c1 = new ContaCorrente();
            ContaPoupanca c2 = new ContaPoupanca();
            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Soma(c1);
            t.Soma(c2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndex.Text);
            Conta selecionada = this.contas[indice];
            Titular.Text = selecionada.Titular.NomeCliente;
            textoSaldo.Text = selecionada.Saldo.ToString();
            textoNumero.Text = selecionada.Numero.ToString();
            
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboContas.SelectedIndex == -1) {

                LimpaCampos();
                return;
            }
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            Titular.Text = selecionada.Titular.NomeCliente;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void LimpaCampos()
        {
            Titular.Text = "";
            textoSaldo.Text = "";
            textoNumero.Text = "";
            textoValor.Text = "";
        }

        public void AdicionaConta(Conta conta)
        {
            // implementação do método adiciona conta
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + conta.Titular.NomeCliente);
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            //Conta novaConta = new ContaCorrente();
            //novaConta.Titular = new Cliente(Titular.Text);
            //novaConta.Numero = Convert.ToInt32(textoNumero.Text);
            //AdicionaConta(novaConta);

            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void BotaoImposto_Click(object sender, EventArgs e)
        {                        
            ContaInvestimento conta = new ContaInvestimento();
            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            conta.Deposita(200.0);

            if (conta is ITributavel)
            {
                totalizador.Acumula(conta);
                MessageBox.Show("Total: " + totalizador.Total);
            }

            ContaCorrente corrente = new ContaCorrente();
            corrente.Deposita(450.0);

            if (corrente is ITributavel)
            {
                totalizador.Acumula(conta);
                MessageBox.Show("Total: " + totalizador.Total);
            }
            
            SeguroVida sv = new SeguroVida();
            sv.Deposita(200.0);

            if (sv is ITributavel)
            {
                totalizador.Acumula(sv);
                MessageBox.Show("Total: " + totalizador.Total);
            }
        }
    }
}