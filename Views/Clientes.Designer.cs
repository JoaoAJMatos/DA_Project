namespace TopCinema.Views
{
    partial class Clientes
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
            this.Nome = new System.Windows.Forms.Label();
            this.Morada = new System.Windows.Forms.Label();
            this.NIF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(29, 38);
            this.Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 17);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // Morada
            // 
            this.Morada.AutoSize = true;
            this.Morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Morada.Location = new System.Drawing.Point(29, 79);
            this.Morada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(56, 17);
            this.Morada.TabIndex = 2;
            this.Morada.Text = "Morada";
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF.Location = new System.Drawing.Point(29, 117);
            this.NIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(29, 17);
            this.NIF.TabIndex = 3;
            this.NIF.Text = "NIF";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(82, 36);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 23);
            this.txtNome.TabIndex = 4;
            // 
            // txtMorada
            // 
            this.txtMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorada.Location = new System.Drawing.Point(82, 79);
            this.txtMorada.Margin = new System.Windows.Forms.Padding(2);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(224, 23);
            this.txtMorada.TabIndex = 5;
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(82, 117);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(224, 23);
            this.txtNIF.TabIndex = 6;
            this.txtNIF.TextChanged += new System.EventHandler(this.txtNIF_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(32, 171);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(82, 48);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Enabled = false;
            this.btnApagar.Location = new System.Drawing.Point(128, 171);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(82, 48);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(224, 171);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 48);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(325, 36);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(453, 183);
            this.dataGridViewClientes.TabIndex = 10;
            this.dataGridViewClientes.SelectionChanged += new System.EventHandler(this.dataGridViewClientes_SelectionChanged);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 243);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.NIF);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.Nome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Morada;
        private System.Windows.Forms.Label NIF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
    }
}