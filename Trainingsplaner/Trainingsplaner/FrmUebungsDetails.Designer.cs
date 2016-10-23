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
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.pctBoxUebung.Location = new System.Drawing.Point(18, 45);
            this.pctBoxUebung.Name = "pctBoxUebung";
            this.pctBoxUebung.Size = new System.Drawing.Size(348, 265);
            this.pctBoxUebung.TabIndex = 1;
            this.pctBoxUebung.TabStop = false;
            // 
            // lblBeschreibung
            // 
            this.lblBeschreibung.AutoSize = true;
            this.lblBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschreibung.Location = new System.Drawing.Point(14, 313);
            this.lblBeschreibung.Name = "lblBeschreibung";
            this.lblBeschreibung.Size = new System.Drawing.Size(51, 20);
            this.lblBeschreibung.TabIndex = 2;
            this.lblBeschreibung.Text = "label1";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(511, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Uebung löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmUebungsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 441);
            this.Controls.Add(this.btnDelete);
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
        private System.Windows.Forms.Button btnDelete;
    }
}