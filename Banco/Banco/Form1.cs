using Banco.Interface;
using Estudo.Banco.Contas;
using System;
using System.Collections.Generic;
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

            try
            {
                selecionada.Deposita(Convert.ToInt32(textoValor.Text));
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                //textoValor.Text = "";
                comboContas.SelectedIndex = -1;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível depositar um valor menor ou igual a zero!");
            }
            
        }

        private void Saque_Click(object sender, EventArgs e)
        {
            // primeiro precisamos recuperar o índice da conta selecionada
            int indice = comboContas.SelectedIndex; //Convert.ToInt32(textoIndex.Text);
            // e depois precisamos ler a posição correta do array.
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoSaldo.Text);

            try
            {
                selecionada.Saca(Convert.ToInt32(textoValor.Text));
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                textoValor.Text = "";
                MessageBox.Show("Saque realizado com sucesso");
            }
            catch (SaldoInsuficienteException esi)
            {
                MessageBox.Show(esi.Message);                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            } 
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

        private void btnTotContas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total: " + ContaCorrente.ProximaConta());
        }

        private void Linq_Click(object sender, EventArgs e)
        {
            IntroToLINQ.ExecutaLINQ();
        }

        private void Exception_Click(object sender, EventArgs e)
        {
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("ArithmeticException Handler: {0}", e.ToString());
            }
            catch (Exception exx)
            {
                Console.WriteLine("Generic Exception Handler: {0}", e.ToString());
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cliente.ComparaClienteExercicio());
        }

        private void HashSet_Click(object sender, EventArgs e)
        {
            HashSet<string> devedores = new HashSet<string>();
            // Podemos adicionar elementos no conjunto utilizando o método Add
            devedores.Add("victor");
            devedores.Add("osni");
            // Para sabermos o número de elementos adicionados, utilizamos a propriedade
            // Count do conjunto. Nesse exemplo elementos guardará o valor 2
            int elementos = devedores.Count;
            // O conjunto não guarda elementos repetidos, então se tentarmos
            // adicionar novamente a string "victor", o número de elementos
            // continua sendo 2
            devedores.Add("victor");
            // Para perguntarmos se o conjunto possui um determinado elemento,
            // utilizamos o método Contains
            bool contem = devedores.Contains("osni");

            foreach (string devedor in devedores)
            {
                MessageBox.Show(devedor);
            }
        }

        private void SortedSet_Click(object sender, EventArgs e)
        {
            /*A diferença é
            que no HashSet os elementos são espalhados em categorias e por isso não sabemos qual é a ordem da
            iteração, já o SortedSet guarda os elementos na ordem crescente
            */
            SortedSet<string> devedores = new SortedSet<string>();
            devedores.Add("Hugo");
            devedores.Add("Ettore");
            devedores.Add("Osni");
            
            devedores.Add("Alberto");
            devedores.Add("Victor");
            devedores.Add("Beto");
            devedores.Add("Ataides");
                        
            // Esse foreach vai mostrar os nomes na seguinte ordem:
            // Alberto, Ettore, Hugo, Osni e por fim Victor
            foreach (string nome in devedores)
            {
                MessageBox.Show(nome);
            }
        }

        private void Dictionary_Click(object sender, EventArgs e)
        {
            Dictionary<String, Conta> dicionario = new Dictionary<String, Conta>();

            foreach (var item in contas)
            {
                if (item != null)
                {
                    dicionario.Add(item.Titular.NomeCliente, item);
                }else
                {
                    break;
                }
                
            }

            Conta busca = dicionario["victor"];
            MessageBox.Show(busca.Titular.NomeCliente);

        }
    }
}
