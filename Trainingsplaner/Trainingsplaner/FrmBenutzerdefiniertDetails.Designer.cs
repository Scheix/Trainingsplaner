namespace Trainingsplaner
{
    partial class FrmBenutzerdefiniertDetails
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
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 414);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(12, 564);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(293, 38);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Foto exportieren";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLöschen.Location = new System.Drawing.Point(311, 564);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(302, 38);
            this.btnLöschen.TabIndex = 4;
            this.btnLöschen.Text = "Übung löschen";
            this.btnLöschen.UseVisualStyleBackColor = false;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 462);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(595, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // FrmBenutzerdefiniertDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(627, 613);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "FrmBenutzerdefiniertDetails";
            this.Text = "Benutzerdefinierte Uebung, Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBenutzerdefiniertDetails_FormClosed);
            this.Load += new System.EventHandler(this.FrmBenutzerdefiniertDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}