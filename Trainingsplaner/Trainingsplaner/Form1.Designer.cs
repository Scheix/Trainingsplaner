﻿namespace Trainingsplaner
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
            this.pctboxTrainingErstellen = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctboxTrainings = new System.Windows.Forms.PictureBox();
            this.pctboxNeueUebung = new System.Windows.Forms.PictureBox();
            this.pctboxUebersicht = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTrainingErstellen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxNeueUebung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxUebersicht)).BeginInit();
            this.SuspendLayout();
            // 
            // pctboxTrainingErstellen
            // 
            this.pctboxTrainingErstellen.ImageLocation = "";
            this.pctboxTrainingErstellen.Location = new System.Drawing.Point(6, 37);
            this.pctboxTrainingErstellen.Name = "pctboxTrainingErstellen";
            this.pctboxTrainingErstellen.Size = new System.Drawing.Size(219, 196);
            this.pctboxTrainingErstellen.TabIndex = 0;
            this.pctboxTrainingErstellen.TabStop = false;
            this.pctboxTrainingErstellen.Click += new System.EventHandler(this.pctboxTrainingErstellen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.erstellenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // erstellenToolStripMenuItem
            // 
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.erstellenToolStripMenuItem.Text = "Erstellen";
            // 
            // pctboxTrainings
            // 
            this.pctboxTrainings.Location = new System.Drawing.Point(231, 37);
            this.pctboxTrainings.Name = "pctboxTrainings";
            this.pctboxTrainings.Size = new System.Drawing.Size(219, 196);
            this.pctboxTrainings.TabIndex = 2;
            this.pctboxTrainings.TabStop = false;
            this.pctboxTrainings.Click += new System.EventHandler(this.pctboxTrainings_Click);
            // 
            // pctboxNeueUebung
            // 
            this.pctboxNeueUebung.Location = new System.Drawing.Point(6, 239);
            this.pctboxNeueUebung.Name = "pctboxNeueUebung";
            this.pctboxNeueUebung.Size = new System.Drawing.Size(219, 196);
            this.pctboxNeueUebung.TabIndex = 3;
            this.pctboxNeueUebung.TabStop = false;
            this.pctboxNeueUebung.Click += new System.EventHandler(this.pctboxNeueUebung_Click);
            // 
            // pctboxUebersicht
            // 
            this.pctboxUebersicht.Location = new System.Drawing.Point(231, 239);
            this.pctboxUebersicht.Name = "pctboxUebersicht";
            this.pctboxUebersicht.Size = new System.Drawing.Size(219, 196);
            this.pctboxUebersicht.TabIndex = 4;
            this.pctboxUebersicht.TabStop = false;
            this.pctboxUebersicht.Click += new System.EventHandler(this.pctboxUebersicht_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(459, 438);
            this.Controls.Add(this.pctboxUebersicht);
            this.Controls.Add(this.pctboxNeueUebung);
            this.Controls.Add(this.pctboxTrainings);
            this.Controls.Add(this.pctboxTrainingErstellen);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Trainingsplaner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTrainingErstellen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxNeueUebung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxUebersicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctboxTrainingErstellen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erstellenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctboxTrainings;
        private System.Windows.Forms.PictureBox pctboxNeueUebung;
        private System.Windows.Forms.PictureBox pctboxUebersicht;
    }
}

