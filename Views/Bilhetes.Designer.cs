namespace TopCinema.Views
{
    partial class Bilhetes
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
            this.checkedListBoxBilhetes = new System.Windows.Forms.CheckedListBox();
            this.buttonAtivarBilhete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxBilhetes
            // 
            this.checkedListBoxBilhetes.FormattingEnabled = true;
            this.checkedListBoxBilhetes.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxBilhetes.Name = "checkedListBoxBilhetes";
            this.checkedListBoxBilhetes.Size = new System.Drawing.Size(379, 379);
            this.checkedListBoxBilhetes.TabIndex = 0;
            // 
            // buttonAtivarBilhete
            // 
            this.buttonAtivarBilhete.Location = new System.Drawing.Point(12, 397);
            this.buttonAtivarBilhete.Name = "buttonAtivarBilhete";
            this.buttonAtivarBilhete.Size = new System.Drawing.Size(379, 41);
            this.buttonAtivarBilhete.TabIndex = 1;
            this.buttonAtivarBilhete.Text = "Ativar Bilhetes";
            this.buttonAtivarBilhete.UseVisualStyleBackColor = true;
            this.buttonAtivarBilhete.Click += new System.EventHandler(this.buttonAtivarBilhete_Click);
            // 
            // Bilhetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.buttonAtivarBilhete);
            this.Controls.Add(this.checkedListBoxBilhetes);
            this.Name = "Bilhetes";
            this.Text = "Bilhetes";
            this.Load += new System.EventHandler(this.Bilhetes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxBilhetes;
        private System.Windows.Forms.Button buttonAtivarBilhete;
    }
}