namespace Trainingsplaner
{
    partial class FrmUebungsDetails
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.pctBoxUebung = new System.Windows.Forms.PictureBox();
            this.lblBeschreibung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUebung)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(13, 13);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(85, 29);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "label1";
            // 
            // pctBoxUebung
            // 
            this.pctBoxUebung.Location = new System.Drawing.Point(18, 73);
            this.pctBoxUebung.Name = "pctBoxUebung";
            this.pctBoxUebung.Size = new System.Drawing.Size(234, 205);
            this.pctBoxUebung.TabIndex = 1;
            this.pctBoxUebung.TabStop = false;
            // 
            // lblBeschreibung
            // 
            this.lblBeschreibung.AutoSize = true;
            this.lblBeschreibung.Location = new System.Drawing.Point(15, 313);
            this.lblBeschreibung.Name = "lblBeschreibung";
            this.lblBeschreibung.Size = new System.Drawing.Size(35, 13);
            this.lblBeschreibung.TabIndex = 2;
            this.lblBeschreibung.Text = "label1";
            // 
            // FrmUebungsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 441);
            this.Controls.Add(this.lblBeschreibung);
            this.Controls.Add(this.pctBoxUebung);
            this.Controls.Add(this.lblTitel);
            this.Name = "FrmUebungsDetails";
            this.Text = "FrmUebungsDetails";
            this.Load += new System.EventHandler(this.FrmUebungsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUebung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.PictureBox pctBoxUebung;
        private System.Windows.Forms.Label lblBeschreibung;
    }
}