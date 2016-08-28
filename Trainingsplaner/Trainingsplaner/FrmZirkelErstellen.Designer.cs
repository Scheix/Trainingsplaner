namespace Trainingsplaner
{
    partial class FrmZirkelErstellen
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
            this.lstUebungen = new System.Windows.Forms.ListView();
            this.cbxKategorie = new System.Windows.Forms.ComboBox();
            this.lstZirkel = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstUebungen
            // 
            this.lstUebungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUebungen.Location = new System.Drawing.Point(12, 40);
            this.lstUebungen.Name = "lstUebungen";
            this.lstUebungen.Size = new System.Drawing.Size(128, 509);
            this.lstUebungen.TabIndex = 2;
            this.lstUebungen.UseCompatibleStateImageBehavior = false;
            this.lstUebungen.View = System.Windows.Forms.View.Tile;
            // 
            // cbxKategorie
            // 
            this.cbxKategorie.FormattingEnabled = true;
            this.cbxKategorie.Location = new System.Drawing.Point(12, 12);
            this.cbxKategorie.Name = "cbxKategorie";
            this.cbxKategorie.Size = new System.Drawing.Size(128, 21);
            this.cbxKategorie.TabIndex = 3;
            this.cbxKategorie.SelectedIndexChanged += new System.EventHandler(this.cbxKategorie_SelectedIndexChanged);
            // 
            // lstZirkel
            // 
            this.lstZirkel.Location = new System.Drawing.Point(146, 12);
            this.lstZirkel.Name = "lstZirkel";
            this.lstZirkel.Size = new System.Drawing.Size(424, 537);
            this.lstZirkel.TabIndex = 4;
            this.lstZirkel.UseCompatibleStateImageBehavior = false;
            // 
            // FrmZirkelErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 561);
            this.Controls.Add(this.lstZirkel);
            this.Controls.Add(this.cbxKategorie);
            this.Controls.Add(this.lstUebungen);
            this.Name = "FrmZirkelErstellen";
            this.Text = "FrmZirkelErstellen";
            this.Load += new System.EventHandler(this.FrmZirkelErstellen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstUebungen;
        private System.Windows.Forms.ComboBox cbxKategorie;
        private System.Windows.Forms.ListView lstZirkel;
    }
}