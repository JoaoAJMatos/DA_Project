namespace TopCinema.Views
{
    partial class FormSessoes
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
            this.numericUpDownPreco = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSala = new System.Windows.Forms.ComboBox();
            this.comboBoxFilme = new System.Windows.Forms.ComboBox();
            this.lbSessoes = new System.Windows.Forms.ListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDownPreco);
            this.panel1.Controls.Add(this.dateTimePickerData);
            this.panel1.Controls.Add(this.comboBoxSala);
            this.panel1.Controls.Add(this.comboBoxFilme);
            this.panel1.Controls.Add(this.lbSessoes);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePickerHora);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 288);
            this.panel1.TabIndex = 3;
            // 
            // numericUpDownPreco
            // 
            this.numericUpDownPreco.DecimalPlaces = 2;
            this.numericUpDownPreco.Location = new System.Drawing.Point(84, 59);
            this.numericUpDownPreco.Name = "numericUpDownPreco";
            this.numericUpDownPreco.Size = new System.Drawing.Size(235, 20);
            this.numericUpDownPreco.TabIndex = 5;
            this.numericUpDownPreco.Tag = "";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(84, 19);
            this.dateTimePickerData.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(134, 23);
            this.dateTimePickerData.TabIndex = 16;
            this.dateTimePickerData.Value = new System.DateTime(2023, 6, 10, 0, 0, 0, 0);
            // 
            // comboBoxSala
            // 
            this.comboBoxSala.FormattingEnabled = true;
            this.comboBoxSala.Location = new System.Drawing.Point(84, 146);
            this.comboBoxSala.Name = "comboBoxSala";
            this.comboBoxSala.Size = new System.Drawing.Size(235, 21);
            this.comboBoxSala.TabIndex = 15;
            // 
            // comboBoxFilme
            // 
            this.comboBoxFilme.FormattingEnabled = true;
            this.comboBoxFilme.Location = new System.Drawing.Point(84, 105);
            this.comboBoxFilme.Name = "comboBoxFilme";
            this.comboBoxFilme.Size = new System.Drawing.Size(235, 21);
            this.comboBoxFilme.TabIndex = 14;
            // 
            // lbSessoes
            // 
            this.lbSessoes.FormattingEnabled = true;
            this.lbSessoes.Location = new System.Drawing.Point(333, 22);
            this.lbSessoes.Name = "lbSessoes";
            this.lbSessoes.Size = new System.Drawing.Size(239, 238);
            this.lbSessoes.TabIndex = 13;
            this.lbSessoes.SelectedIndexChanged += new System.EventHandler(this.lbSessoes_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(222, 232);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 33);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Enabled = false;
            this.btnApagar.Location = new System.Drawing.Point(121, 232);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(97, 33);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(20, 232);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 33);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filme";
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora.Location = new System.Drawing.Point(222, 19);
            this.dateTimePickerHora.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.Size = new System.Drawing.Size(97, 23);
            this.dateTimePickerHora.TabIndex = 4;
            this.dateTimePickerHora.Value = new System.DateTime(2023, 6, 10, 14, 41, 9, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataHora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Criar Sessao";
            // 
            // FormSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSessoes";
            this.Text = "FormSessoes";
            this.Load += new System.EventHandler(this.FormSessoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListBox lbSessoes;
        private System.Windows.Forms.ComboBox comboBoxSala;
        private System.Windows.Forms.ComboBox comboBoxFilme;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.NumericUpDown numericUpDownPreco;
    }
}