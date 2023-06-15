namespace TopCinema.Views
{
    partial class Atendimento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxRegistarCliente = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmitirBilhetes = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.NIF = new System.Windows.Forms.Label();
            this.Morada = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNomeFilme = new System.Windows.Forms.Label();
            this.labelDataHora = new System.Windows.Forms.Label();
            this.labelSala = new System.Windows.Forms.Label();
            this.labelLugaresLivres = new System.Windows.Forms.Label();
            this.labelDuracao = new System.Windows.Forms.Label();
            this.buttonVerBilhetes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxRegistarCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEmitirBilhetes);
            this.panel1.Controls.Add(this.buttonPesquisar);
            this.panel1.Controls.Add(this.textBoxPesquisa);
            this.panel1.Controls.Add(this.txtNIF);
            this.panel1.Controls.Add(this.txtMorada);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.NIF);
            this.panel1.Controls.Add(this.Morada);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Location = new System.Drawing.Point(25, 621);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 205);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxRegistarCliente
            // 
            this.checkBoxRegistarCliente.AutoSize = true;
            this.checkBoxRegistarCliente.Location = new System.Drawing.Point(392, 116);
            this.checkBoxRegistarCliente.Name = "checkBoxRegistarCliente";
            this.checkBoxRegistarCliente.Size = new System.Drawing.Size(201, 17);
            this.checkBoxRegistarCliente.TabIndex = 19;
            this.checkBoxRegistarCliente.Text = "Registar cliente para compras futuras";
            this.checkBoxRegistarCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisar cliente por NIF";
            // 
            // btnEmitirBilhetes
            // 
            this.btnEmitirBilhetes.Location = new System.Drawing.Point(445, 154);
            this.btnEmitirBilhetes.Name = "btnEmitirBilhetes";
            this.btnEmitirBilhetes.Size = new System.Drawing.Size(95, 42);
            this.btnEmitirBilhetes.TabIndex = 16;
            this.btnEmitirBilhetes.Text = "Emitir Bilhetes";
            this.btnEmitirBilhetes.UseVisualStyleBackColor = true;
            this.btnEmitirBilhetes.Click += new System.EventHandler(this.btnEmitirBilhetes_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.buttonPesquisar.BackgroundImage = global::TopCinema.Properties.Resources.magnifier;
            this.buttonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPesquisar.Location = new System.Drawing.Point(228, 17);
            this.buttonPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(22, 24);
            this.buttonPesquisar.TabIndex = 14;
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisa.Location = new System.Drawing.Point(34, 21);
            this.textBoxPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(190, 23);
            this.textBoxPesquisa.TabIndex = 13;
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(405, 88);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(174, 23);
            this.txtNIF.TabIndex = 12;
            // 
            // txtMorada
            // 
            this.txtMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorada.Location = new System.Drawing.Point(405, 49);
            this.txtMorada.Margin = new System.Windows.Forms.Padding(2);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(174, 23);
            this.txtMorada.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(405, 11);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 23);
            this.txtNome.TabIndex = 10;
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF.Location = new System.Drawing.Point(363, 94);
            this.NIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(29, 17);
            this.NIF.TabIndex = 9;
            this.NIF.Text = "NIF";
            // 
            // Morada
            // 
            this.Morada.AutoSize = true;
            this.Morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Morada.Location = new System.Drawing.Point(336, 55);
            this.Morada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(56, 17);
            this.Morada.TabIndex = 8;
            this.Morada.Text = "Morada";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(347, 17);
            this.Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 17);
            this.Nome.TabIndex = 7;
            this.Nome.Text = "Nome";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(22, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 585);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 61);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1122, 520);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AcceptsTab = true;
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(2, 2);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1122, 55);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Tela";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNomeFilme
            // 
            this.labelNomeFilme.AutoSize = true;
            this.labelNomeFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeFilme.Location = new System.Drawing.Point(638, 626);
            this.labelNomeFilme.Name = "labelNomeFilme";
            this.labelNomeFilme.Size = new System.Drawing.Size(74, 24);
            this.labelNomeFilme.TabIndex = 2;
            this.labelNomeFilme.Text = "Filme: ";
            // 
            // labelDataHora
            // 
            this.labelDataHora.AutoSize = true;
            this.labelDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataHora.Location = new System.Drawing.Point(638, 716);
            this.labelDataHora.Name = "labelDataHora";
            this.labelDataHora.Size = new System.Drawing.Size(66, 24);
            this.labelDataHora.TabIndex = 3;
            this.labelDataHora.Text = "Inicio:";
            // 
            // labelSala
            // 
            this.labelSala.AutoSize = true;
            this.labelSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSala.Location = new System.Drawing.Point(638, 669);
            this.labelSala.Name = "labelSala";
            this.labelSala.Size = new System.Drawing.Size(56, 24);
            this.labelSala.TabIndex = 4;
            this.labelSala.Text = "Sala:";
            // 
            // labelLugaresLivres
            // 
            this.labelLugaresLivres.AutoSize = true;
            this.labelLugaresLivres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLugaresLivres.Location = new System.Drawing.Point(933, 626);
            this.labelLugaresLivres.Name = "labelLugaresLivres";
            this.labelLugaresLivres.Size = new System.Drawing.Size(146, 24);
            this.labelLugaresLivres.TabIndex = 5;
            this.labelLugaresLivres.Text = "Lugares livres:";
            // 
            // labelDuracao
            // 
            this.labelDuracao.AutoSize = true;
            this.labelDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracao.Location = new System.Drawing.Point(638, 764);
            this.labelDuracao.Name = "labelDuracao";
            this.labelDuracao.Size = new System.Drawing.Size(94, 24);
            this.labelDuracao.TabIndex = 6;
            this.labelDuracao.Text = "Duracao:";
            // 
            // buttonVerBilhetes
            // 
            this.buttonVerBilhetes.Location = new System.Drawing.Point(937, 666);
            this.buttonVerBilhetes.Name = "buttonVerBilhetes";
            this.buttonVerBilhetes.Size = new System.Drawing.Size(175, 35);
            this.buttonVerBilhetes.TabIndex = 7;
            this.buttonVerBilhetes.Text = "Ver Bilhetes";
            this.buttonVerBilhetes.UseVisualStyleBackColor = true;
            this.buttonVerBilhetes.Click += new System.EventHandler(this.buttonVerBilhetes_Click);
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 837);
            this.Controls.Add(this.buttonVerBilhetes);
            this.Controls.Add(this.labelDuracao);
            this.Controls.Add(this.labelLugaresLivres);
            this.Controls.Add(this.labelSala);
            this.Controls.Add(this.labelDataHora);
            this.Controls.Add(this.labelNomeFilme);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Atendimento";
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.Atendimento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label NIF;
        private System.Windows.Forms.Label Morada;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEmitirBilhetes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNomeFilme;
        private System.Windows.Forms.Label labelDataHora;
        private System.Windows.Forms.Label labelSala;
        private System.Windows.Forms.Label labelLugaresLivres;
        private System.Windows.Forms.CheckBox checkBoxRegistarCliente;
        private System.Windows.Forms.Label labelDuracao;
        private System.Windows.Forms.Button buttonVerBilhetes;
    }
}