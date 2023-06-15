namespace TopCinema
{
    partial class CardSessao
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbMovieName = new System.Windows.Forms.Label();
            this.ptMovieImage = new System.Windows.Forms.PictureBox();
            this.labelSala = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptMovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.Location = new System.Drawing.Point(1, 194);
            this.lbHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(48, 15);
            this.lbHorario.TabIndex = 1;
            this.lbHorario.Text = "Horario";
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovieName.Location = new System.Drawing.Point(10, 124);
            this.lbMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(102, 17);
            this.lbMovieName.TabIndex = 6;
            this.lbMovieName.Text = "Nome do Filme";
            // 
            // ptMovieImage
            // 
            this.ptMovieImage.BackgroundImage = global::TopCinema.Properties.Resources.brokie;
            this.ptMovieImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptMovieImage.Location = new System.Drawing.Point(10, 11);
            this.ptMovieImage.Margin = new System.Windows.Forms.Padding(2);
            this.ptMovieImage.Name = "ptMovieImage";
            this.ptMovieImage.Size = new System.Drawing.Size(104, 102);
            this.ptMovieImage.TabIndex = 7;
            this.ptMovieImage.TabStop = false;
            // 
            // labelSala
            // 
            this.labelSala.AutoSize = true;
            this.labelSala.Location = new System.Drawing.Point(11, 150);
            this.labelSala.Name = "labelSala";
            this.labelSala.Size = new System.Drawing.Size(28, 13);
            this.labelSala.TabIndex = 8;
            this.labelSala.Text = "Sala";
            // 
            // CardSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelSala);
            this.Controls.Add(this.ptMovieImage);
            this.Controls.Add(this.lbMovieName);
            this.Controls.Add(this.lbHorario);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardSessao";
            this.Size = new System.Drawing.Size(128, 213);
            this.Load += new System.EventHandler(this.CardSessao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptMovieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.PictureBox ptMovieImage;
        private System.Windows.Forms.Label labelSala;
    }
}
