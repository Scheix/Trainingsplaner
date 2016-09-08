namespace Trainingsplaner
{
    partial class FrmNeueUebung
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
            this.btnHIIT = new System.Windows.Forms.Button();
            this.btnLaufen = new System.Windows.Forms.Button();
            this.btnTechnik = new System.Windows.Forms.Button();
            this.btnBenutzerdefiniert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHIIT
            // 
            this.btnHIIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHIIT.Location = new System.Drawing.Point(13, 12);
            this.btnHIIT.Name = "btnHIIT";
            this.btnHIIT.Size = new System.Drawing.Size(329, 67);
            this.btnHIIT.TabIndex = 0;
            this.btnHIIT.Text = "HIIT";
            this.btnHIIT.UseVisualStyleBackColor = true;
            this.btnHIIT.Click += new System.EventHandler(this.btnHIIT_Click);
            // 
            // btnLaufen
            // 
            this.btnLaufen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaufen.Location = new System.Drawing.Point(13, 86);
            this.btnLaufen.Name = "btnLaufen";
            this.btnLaufen.Size = new System.Drawing.Size(329, 67);
            this.btnLaufen.TabIndex = 1;
            this.btnLaufen.Text = "Laufen";
            this.btnLaufen.UseVisualStyleBackColor = true;
            this.btnLaufen.Click += new System.EventHandler(this.btnLaufen_Click);
            // 
            // btnTechnik
            // 
            this.btnTechnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnik.Location = new System.Drawing.Point(13, 159);
            this.btnTechnik.Name = "btnTechnik";
            this.btnTechnik.Size = new System.Drawing.Size(329, 67);
            this.btnTechnik.TabIndex = 2;
            this.btnTechnik.Text = "Technik";
            this.btnTechnik.UseVisualStyleBackColor = true;
            this.btnTechnik.Click += new System.EventHandler(this.btnTechnik_Click);
            // 
            // btnBenutzerdefiniert
            // 
            this.btnBenutzerdefiniert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenutzerdefiniert.Location = new System.Drawing.Point(13, 232);
            this.btnBenutzerdefiniert.Name = "btnBenutzerdefiniert";
            this.btnBenutzerdefiniert.Size = new System.Drawing.Size(329, 67);
            this.btnBenutzerdefiniert.TabIndex = 3;
            this.btnBenutzerdefiniert.Text = "Benutzerdefiniert";
            this.btnBenutzerdefiniert.UseVisualStyleBackColor = true;
            this.btnBenutzerdefiniert.Click += new System.EventHandler(this.btnBenutzerdefiniert_Click);
            // 
            // FrmNeueUebung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 307);
            this.Controls.Add(this.btnBenutzerdefiniert);
            this.Controls.Add(this.btnTechnik);
            this.Controls.Add(this.btnLaufen);
            this.Controls.Add(this.btnHIIT);
            this.Name = "FrmNeueUebung";
            this.Text = "Neue Uebung";
            this.Load += new System.EventHandler(this.FrmNeueUebung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHIIT;
        private System.Windows.Forms.Button btnLaufen;
        private System.Windows.Forms.Button btnTechnik;
        private System.Windows.Forms.Button btnBenutzerdefiniert;
    }
}