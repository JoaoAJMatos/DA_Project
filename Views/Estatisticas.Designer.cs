namespace TopCinema.Views
{
    partial class Estatisticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumBilhetesTotal = new System.Windows.Forms.Label();
            this.labelTotalValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estatísticas";
            // 
            // labelNumBilhetesTotal
            // 
            this.labelNumBilhetesTotal.AutoSize = true;
            this.labelNumBilhetesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumBilhetesTotal.Location = new System.Drawing.Point(24, 47);
            this.labelNumBilhetesTotal.Name = "labelNumBilhetesTotal";
            this.labelNumBilhetesTotal.Size = new System.Drawing.Size(217, 16);
            this.labelNumBilhetesTotal.TabIndex = 3;
            this.labelNumBilhetesTotal.Text = "Numero total de bilhetes vendidos: ";
            // 
            // labelTotalValor
            // 
            this.labelTotalValor.AutoSize = true;
            this.labelTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValor.Location = new System.Drawing.Point(24, 77);
            this.labelTotalValor.Name = "labelTotalValor";
            this.labelTotalValor.Size = new System.Drawing.Size(144, 16);
            this.labelTotalValor.TabIndex = 5;
            this.labelTotalValor.Text = "Valor total arrecadado:";
            // 
            // Estatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 113);
            this.Controls.Add(this.labelTotalValor);
            this.Controls.Add(this.labelNumBilhetesTotal);
            this.Controls.Add(this.label1);
            this.Name = "Estatisticas";
            this.Text = "Estatisticas";
            this.Load += new System.EventHandler(this.Estatisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumBilhetesTotal;
        private System.Windows.Forms.Label labelTotalValor;
    }
}