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
            this.btnFertig = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstUebungen
            // 
            this.lstUebungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUebungen.Location = new System.Drawing.Point(12, 40);
            this.lstUebungen.Name = "lstUebungen";
            this.lstUebungen.Size = new System.Drawing.Size(182, 509);
            this.lstUebungen.TabIndex = 2;
            this.lstUebungen.UseCompatibleStateImageBehavior = false;
            this.lstUebungen.View = System.Windows.Forms.View.Tile;
            this.lstUebungen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstUebungen_MouseDown);
            // 
            // cbxKategorie
            // 
            this.cbxKategorie.FormattingEnabled = true;
            this.cbxKategorie.Location = new System.Drawing.Point(12, 13);
            this.cbxKategorie.Name = "cbxKategorie";
            this.cbxKategorie.Size = new System.Drawing.Size(182, 21);
            this.cbxKategorie.TabIndex = 5;
            this.cbxKategorie.Text = "HIIT";
            this.cbxKategorie.SelectedIndexChanged += new System.EventHandler(this.cbxKategorie_SelectedIndexChanged_1);
            // 
            // lstZirkel
            // 
            this.lstZirkel.AllowDrop = true;
            this.lstZirkel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstZirkel.Location = new System.Drawing.Point(200, 12);
            this.lstZirkel.Name = "lstZirkel";
            this.lstZirkel.Size = new System.Drawing.Size(565, 511);
            this.lstZirkel.TabIndex = 6;
            this.lstZirkel.UseCompatibleStateImageBehavior = false;
            this.lstZirkel.View = System.Windows.Forms.View.Tile;
            this.lstZirkel.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstZirkel_DragDrop_1);
            this.lstZirkel.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstZirkel_DragEnter_1);
            this.lstZirkel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstZirkel_MouseClick);
            // 
            // btnFertig
            // 
            this.btnFertig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertig.Location = new System.Drawing.Point(13, 556);
            this.btnFertig.Name = "btnFertig";
            this.btnFertig.Size = new System.Drawing.Size(752, 79);
            this.btnFertig.TabIndex = 7;
            this.btnFertig.Text = "Fertig";
            this.btnFertig.UseVisualStyleBackColor = true;
            this.btnFertig.Click += new System.EventHandler(this.btnFertig_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(358, 529);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(407, 24);
            this.txtName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name des Zirkels:";
            // 
            // FrmZirkelErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(777, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnFertig);
            this.Controls.Add(this.lstZirkel);
            this.Controls.Add(this.cbxKategorie);
            this.Controls.Add(this.lstUebungen);
            this.Name = "FrmZirkelErstellen";
            this.Text = "FrmZirkelErstellen";
            this.Load += new System.EventHandler(this.FrmZirkelErstellen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstUebungen;
        private System.Windows.Forms.ComboBox cbxKategorie;
        private System.Windows.Forms.ListView lstZirkel;
        private System.Windows.Forms.Button btnFertig;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}