﻿namespace Trainingsplaner
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(511, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Uebung löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 316);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(511, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // FrmUebungsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(535, 455);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pctBoxUebung);
            this.Controls.Add(this.lblTitel);
            this.MaximizeBox = false;
            this.Name = "FrmUebungsDetails";
            this.Text = "Uebungs Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUebungsDetails_FormClosed);
            this.Load += new System.EventHandler(this.FrmUebungsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUebung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.PictureBox pctBoxUebung;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}