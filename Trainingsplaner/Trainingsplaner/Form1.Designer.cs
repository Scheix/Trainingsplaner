namespace Trainingsplaner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctboxUebersicht = new System.Windows.Forms.PictureBox();
            this.pctboxNeueUebung = new System.Windows.Forms.PictureBox();
            this.pctboxTrainings = new System.Windows.Forms.PictureBox();
            this.pctboxTrainingErstellen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxUebersicht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxNeueUebung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTrainingErstellen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pctboxUebersicht
            // 
            this.pctboxUebersicht.Image = ((System.Drawing.Image)(resources.GetObject("pctboxUebersicht.Image")));
            this.pctboxUebersicht.Location = new System.Drawing.Point(732, 368);
            this.pctboxUebersicht.Name = "pctboxUebersicht";
            this.pctboxUebersicht.Size = new System.Drawing.Size(551, 338);
            this.pctboxUebersicht.TabIndex = 4;
            this.pctboxUebersicht.TabStop = false;
            this.pctboxUebersicht.Click += new System.EventHandler(this.pctboxUebersicht_Click);
            // 
            // pctboxNeueUebung
            // 
            this.pctboxNeueUebung.Image = ((System.Drawing.Image)(resources.GetObject("pctboxNeueUebung.Image")));
            this.pctboxNeueUebung.Location = new System.Drawing.Point(75, 368);
            this.pctboxNeueUebung.Name = "pctboxNeueUebung";
            this.pctboxNeueUebung.Size = new System.Drawing.Size(551, 339);
            this.pctboxNeueUebung.TabIndex = 3;
            this.pctboxNeueUebung.TabStop = false;
            this.pctboxNeueUebung.Click += new System.EventHandler(this.pctboxNeueUebung_Click);
            // 
            // pctboxTrainings
            // 
            this.pctboxTrainings.Image = ((System.Drawing.Image)(resources.GetObject("pctboxTrainings.Image")));
            this.pctboxTrainings.Location = new System.Drawing.Point(732, 21);
            this.pctboxTrainings.Name = "pctboxTrainings";
            this.pctboxTrainings.Size = new System.Drawing.Size(551, 340);
            this.pctboxTrainings.TabIndex = 2;
            this.pctboxTrainings.TabStop = false;
            this.pctboxTrainings.Click += new System.EventHandler(this.pctboxTrainings_Click);
            // 
            // pctboxTrainingErstellen
            // 
            this.pctboxTrainingErstellen.Image = ((System.Drawing.Image)(resources.GetObject("pctboxTrainingErstellen.Image")));
            this.pctboxTrainingErstellen.ImageLocation = "";
            this.pctboxTrainingErstellen.Location = new System.Drawing.Point(75, 21);
            this.pctboxTrainingErstellen.Name = "pctboxTrainingErstellen";
            this.pctboxTrainingErstellen.Size = new System.Drawing.Size(551, 340);
            this.pctboxTrainingErstellen.TabIndex = 0;
            this.pctboxTrainingErstellen.TabStop = false;
            this.pctboxTrainingErstellen.Click += new System.EventHandler(this.pctboxTrainingErstellen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(632, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 79);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(632, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 79);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctboxUebersicht);
            this.Controls.Add(this.pctboxNeueUebung);
            this.Controls.Add(this.pctboxTrainings);
            this.Controls.Add(this.pctboxTrainingErstellen);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Trainingsplaner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxUebersicht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxNeueUebung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTrainingErstellen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctboxTrainingErstellen;
        private System.Windows.Forms.PictureBox pctboxTrainings;
        private System.Windows.Forms.PictureBox pctboxNeueUebung;
        private System.Windows.Forms.PictureBox pctboxUebersicht;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

