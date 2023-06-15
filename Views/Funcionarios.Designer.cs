
namespace TopCinema.Views
{
    partial class Funcionarios
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Salario = new System.Windows.Forms.Label();
            this.Morada = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.lbFuncionarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfuncao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(244, 195);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 48);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Enabled = false;
            this.btnApagar.Location = new System.Drawing.Point(148, 195);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(82, 48);
            this.btnApagar.TabIndex = 18;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(52, 195);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(82, 48);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(102, 116);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(224, 23);
            this.txtSalario.TabIndex = 16;
            // 
            // txtMorada
            // 
            this.txtMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorada.Location = new System.Drawing.Point(102, 78);
            this.txtMorada.Margin = new System.Windows.Forms.Padding(2);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(224, 23);
            this.txtMorada.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(102, 35);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 23);
            this.txtNome.TabIndex = 14;
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salario.Location = new System.Drawing.Point(36, 117);
            this.Salario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(52, 17);
            this.Salario.TabIndex = 13;
            this.Salario.Text = "Salario";
            // 
            // Morada
            // 
            this.Morada.AutoSize = true;
            this.Morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Morada.Location = new System.Drawing.Point(36, 79);
            this.Morada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(56, 17);
            this.Morada.TabIndex = 12;
            this.Morada.Text = "Morada";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(36, 38);
            this.Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 17);
            this.Nome.TabIndex = 11;
            this.Nome.Text = "Nome";
            // 
            // lbFuncionarios
            // 
            this.lbFuncionarios.FormattingEnabled = true;
            this.lbFuncionarios.Location = new System.Drawing.Point(366, 35);
            this.lbFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.lbFuncionarios.Name = "lbFuncionarios";
            this.lbFuncionarios.Size = new System.Drawing.Size(218, 186);
            this.lbFuncionarios.TabIndex = 10;
            this.lbFuncionarios.SelectedIndexChanged += new System.EventHandler(this.lbFuncionarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Função";
            // 
            // txtfuncao
            // 
            this.txtfuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfuncao.Location = new System.Drawing.Point(102, 150);
            this.txtfuncao.Margin = new System.Windows.Forms.Padding(2);
            this.txtfuncao.Name = "txtfuncao";
            this.txtfuncao.Size = new System.Drawing.Size(224, 23);
            this.txtfuncao.TabIndex = 21;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 293);
            this.Controls.Add(this.txtfuncao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.lbFuncionarios);
            this.Name = "Funcionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.Label Morada;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.ListBox lbFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfuncao;
    }
}