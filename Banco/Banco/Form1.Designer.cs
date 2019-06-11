namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Saque = new System.Windows.Forms.Button();
            this.Titular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Totaliza = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textoIndex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.BotaoImposto = new System.Windows.Forms.Button();
            this.btnTotContas = new System.Windows.Forms.Button();
            this.Linq = new System.Windows.Forms.Button();
            this.Exception = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.HashSet = new System.Windows.Forms.Button();
            this.SortedSet = new System.Windows.Forms.Button();
            this.Dictionary = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(149, 153);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 0;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(148, 188);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 1;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(149, 223);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 2;
            this.textoValor.TextChanged += new System.EventHandler(this.textoSaldo_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Depositar_Click);
            // 
            // Saque
            // 
            this.Saque.Location = new System.Drawing.Point(92, 294);
            this.Saque.Name = "Saque";
            this.Saque.Size = new System.Drawing.Size(75, 23);
            this.Saque.TabIndex = 4;
            this.Saque.Text = "Saque";
            this.Saque.UseVisualStyleBackColor = true;
            this.Saque.Click += new System.EventHandler(this.Saque_Click);
            // 
            // Titular
            // 
            this.Titular.Location = new System.Drawing.Point(148, 120);
            this.Titular.Name = "Titular";
            this.Titular.Size = new System.Drawing.Size(100, 20);
            this.Titular.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor";
            // 
            // Totaliza
            // 
            this.Totaliza.Location = new System.Drawing.Point(173, 324);
            this.Totaliza.Name = "Totaliza";
            this.Totaliza.Size = new System.Drawing.Size(75, 23);
            this.Totaliza.TabIndex = 10;
            this.Totaliza.Text = "Totalizador";
            this.Totaliza.UseVisualStyleBackColor = true;
            this.Totaliza.Click += new System.EventHandler(this.Totaliza_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboContas);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textoIndex);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 96);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(7, 54);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 3;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textoIndex
            // 
            this.textoIndex.Location = new System.Drawing.Point(139, 26);
            this.textoIndex.Name = "textoIndex";
            this.textoIndex.Size = new System.Drawing.Size(100, 20);
            this.textoIndex.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Escolha a conta";
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(92, 323);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(75, 23);
            this.btnNovaConta.TabIndex = 12;
            this.btnNovaConta.Text = "Nova conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // BotaoImposto
            // 
            this.BotaoImposto.Location = new System.Drawing.Point(174, 353);
            this.BotaoImposto.Name = "BotaoImposto";
            this.BotaoImposto.Size = new System.Drawing.Size(75, 23);
            this.BotaoImposto.TabIndex = 13;
            this.BotaoImposto.Text = "Imposto";
            this.BotaoImposto.UseVisualStyleBackColor = true;
            this.BotaoImposto.Click += new System.EventHandler(this.BotaoImposto_Click);
            // 
            // btnTotContas
            // 
            this.btnTotContas.Location = new System.Drawing.Point(92, 352);
            this.btnTotContas.Name = "btnTotContas";
            this.btnTotContas.Size = new System.Drawing.Size(75, 23);
            this.btnTotContas.TabIndex = 14;
            this.btnTotContas.Text = "Total contas";
            this.btnTotContas.UseVisualStyleBackColor = true;
            this.btnTotContas.Click += new System.EventHandler(this.btnTotContas_Click);
            // 
            // Linq
            // 
            this.Linq.Location = new System.Drawing.Point(11, 294);
            this.Linq.Name = "Linq";
            this.Linq.Size = new System.Drawing.Size(75, 23);
            this.Linq.TabIndex = 15;
            this.Linq.Text = "Linq";
            this.Linq.UseVisualStyleBackColor = true;
            this.Linq.Click += new System.EventHandler(this.Linq_Click);
            // 
            // Exception
            // 
            this.Exception.Location = new System.Drawing.Point(11, 323);
            this.Exception.Name = "Exception";
            this.Exception.Size = new System.Drawing.Size(75, 23);
            this.Exception.TabIndex = 16;
            this.Exception.Text = "Exception";
            this.Exception.UseVisualStyleBackColor = true;
            this.Exception.Click += new System.EventHandler(this.Exception_Click);
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(9, 352);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(75, 23);
            this.Equals.TabIndex = 17;
            this.Equals.Text = "Equals";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // HashSet
            // 
            this.HashSet.Location = new System.Drawing.Point(174, 382);
            this.HashSet.Name = "HashSet";
            this.HashSet.Size = new System.Drawing.Size(75, 23);
            this.HashSet.TabIndex = 18;
            this.HashSet.Text = "HashSet";
            this.HashSet.UseVisualStyleBackColor = true;
            this.HashSet.Click += new System.EventHandler(this.HashSet_Click);
            // 
            // SortedSet
            // 
            this.SortedSet.Location = new System.Drawing.Point(92, 381);
            this.SortedSet.Name = "SortedSet";
            this.SortedSet.Size = new System.Drawing.Size(75, 23);
            this.SortedSet.TabIndex = 19;
            this.SortedSet.Text = "SortedSet";
            this.SortedSet.UseVisualStyleBackColor = true;
            this.SortedSet.Click += new System.EventHandler(this.SortedSet_Click);
            // 
            // Dictionary
            // 
            this.Dictionary.Location = new System.Drawing.Point(9, 381);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(75, 23);
            this.Dictionary.TabIndex = 20;
            this.Dictionary.Text = "Dictionary";
            this.Dictionary.UseVisualStyleBackColor = true;
            this.Dictionary.Click += new System.EventHandler(this.Dictionary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 435);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.SortedSet);
            this.Controls.Add(this.HashSet);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Exception);
            this.Controls.Add(this.Linq);
            this.Controls.Add(this.btnTotContas);
            this.Controls.Add(this.BotaoImposto);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Totaliza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titular);
            this.Controls.Add(this.Saque);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Saque;
        private System.Windows.Forms.TextBox Titular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Totaliza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textoIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.Button BotaoImposto;
        private System.Windows.Forms.Button btnTotContas;
        private System.Windows.Forms.Button Linq;
        private System.Windows.Forms.Button Exception;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button HashSet;
        private System.Windows.Forms.Button SortedSet;
        private System.Windows.Forms.Button Dictionary;
    }
}

