namespace TopCinema.Views
{
    partial class Cinema
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownFilas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColunas = new System.Windows.Forms.NumericUpDown();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbSalas = new System.Windows.Forms.ListBox();
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.NIF = new System.Windows.Forms.Label();
            this.Morada = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColunas)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(115, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 27);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Text = "topcinema@therealworld.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Morada:";
            // 
            // txtMorada
            // 
            this.txtMorada.Enabled = false;
            this.txtMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorada.Location = new System.Drawing.Point(115, 143);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(263, 27);
            this.txtMorada.TabIndex = 10;
            this.txtMorada.Text = "Arroz com Queijo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Defenições do Cinema";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(115, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 27);
            this.txtNome.TabIndex = 7;
            this.txtNome.Text = "TopCinema";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(285, 245);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 33);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownFilas);
            this.panel1.Controls.Add(this.numericUpDownColunas);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.lbSalas);
            this.panel1.Controls.Add(this.txtNomeSala);
            this.panel1.Controls.Add(this.NIF);
            this.panel1.Controls.Add(this.Morada);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Location = new System.Drawing.Point(424, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 503);
            this.panel1.TabIndex = 15;
            // 
            // numericUpDownFilas
            // 
            this.numericUpDownFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFilas.Location = new System.Drawing.Point(141, 355);
            this.numericUpDownFilas.Name = "numericUpDownFilas";
            this.numericUpDownFilas.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownFilas.TabIndex = 24;
            // 
            // numericUpDownColunas
            // 
            this.numericUpDownColunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownColunas.Location = new System.Drawing.Point(141, 313);
            this.numericUpDownColunas.Name = "numericUpDownColunas";
            this.numericUpDownColunas.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownColunas.TabIndex = 23;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(333, 413);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 59);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(206, 413);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(110, 59);
            this.btnApagar.TabIndex = 21;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(78, 413);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 59);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lbSalas
            // 
            this.lbSalas.FormattingEnabled = true;
            this.lbSalas.ItemHeight = 16;
            this.lbSalas.Location = new System.Drawing.Point(110, 16);
            this.lbSalas.Name = "lbSalas";
            this.lbSalas.Size = new System.Drawing.Size(319, 228);
            this.lbSalas.TabIndex = 17;
            this.lbSalas.SelectedIndexChanged += new System.EventHandler(this.lbSalas_SelectedIndexChanged);
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSala.Location = new System.Drawing.Point(141, 262);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.Size = new System.Drawing.Size(288, 27);
            this.txtNomeSala.TabIndex = 10;
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF.Location = new System.Drawing.Point(60, 362);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(50, 20);
            this.NIF.TabIndex = 9;
            this.NIF.Text = "Filas:";
            // 
            // Morada
            // 
            this.Morada.AutoSize = true;
            this.Morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Morada.Location = new System.Drawing.Point(60, 315);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(75, 20);
            this.Morada.TabIndex = 8;
            this.Morada.Text = "Colunas:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(60, 265);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(58, 20);
            this.Nome.TabIndex = 7;
            this.Nome.Text = "Nome:";
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "Cinema";
            this.Text = "Cinema";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.Label NIF;
        private System.Windows.Forms.Label Morada;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.ListBox lbSalas;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.NumericUpDown numericUpDownFilas;
        private System.Windows.Forms.NumericUpDown numericUpDownColunas;
    }
}