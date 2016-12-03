namespace Trainingsplaner
{
    partial class FrmTrainingErstellen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnFertig = new System.Windows.Forms.Button();
            this.lstTraining = new System.Windows.Forms.ListView();
            this.cbxKategorie = new System.Windows.Forms.ComboBox();
            this.lstUebungen = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxEinteilung = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name des Trainings:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(378, 529);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 24);
            this.txtName.TabIndex = 14;
            // 
            // btnFertig
            // 
            this.btnFertig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertig.Location = new System.Drawing.Point(13, 559);
            this.btnFertig.Name = "btnFertig";
            this.btnFertig.Size = new System.Drawing.Size(752, 79);
            this.btnFertig.TabIndex = 13;
            this.btnFertig.Text = "Fertig";
            this.btnFertig.UseVisualStyleBackColor = true;
            this.btnFertig.Click += new System.EventHandler(this.btnFertig_Click);
            // 
            // lstTraining
            // 
            this.lstTraining.AllowDrop = true;
            this.lstTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTraining.Location = new System.Drawing.Point(200, 12);
            this.lstTraining.Name = "lstTraining";
            this.lstTraining.Size = new System.Drawing.Size(565, 484);
            this.lstTraining.TabIndex = 12;
            this.lstTraining.UseCompatibleStateImageBehavior = false;
            this.lstTraining.View = System.Windows.Forms.View.Tile;
            this.lstTraining.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstTraining_DragDrop);
            this.lstTraining.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstTraining_DragEnter);
            this.lstTraining.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstTraining_MouseClick);
            // 
            // cbxKategorie
            // 
            this.cbxKategorie.FormattingEnabled = true;
            this.cbxKategorie.Location = new System.Drawing.Point(12, 13);
            this.cbxKategorie.Name = "cbxKategorie";
            this.cbxKategorie.Size = new System.Drawing.Size(182, 21);
            this.cbxKategorie.TabIndex = 11;
            this.cbxKategorie.Text = "HIIT";
            this.cbxKategorie.SelectedIndexChanged += new System.EventHandler(this.cbxKategorie_SelectedIndexChanged);
            // 
            // lstUebungen
            // 
            this.lstUebungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUebungen.Location = new System.Drawing.Point(12, 40);
            this.lstUebungen.Name = "lstUebungen";
            this.lstUebungen.Size = new System.Drawing.Size(182, 509);
            this.lstUebungen.TabIndex = 10;
            this.lstUebungen.UseCompatibleStateImageBehavior = false;
            this.lstUebungen.View = System.Windows.Forms.View.Tile;
            this.lstUebungen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstUebungen_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kategorie:";
            // 
            // cboxEinteilung
            // 
            this.cboxEinteilung.FormattingEnabled = true;
            this.cboxEinteilung.Location = new System.Drawing.Point(378, 504);
            this.cboxEinteilung.Name = "cboxEinteilung";
            this.cboxEinteilung.Size = new System.Drawing.Size(385, 21);
            this.cboxEinteilung.TabIndex = 17;
            // 
            // FrmTrainingErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(775, 645);
            this.Controls.Add(this.cboxEinteilung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnFertig);
            this.Controls.Add(this.lstTraining);
            this.Controls.Add(this.cbxKategorie);
            this.Controls.Add(this.lstUebungen);
            this.MaximizeBox = false;
            this.Name = "FrmTrainingErstellen";
            this.Text = "Training erstellen";
            this.Load += new System.EventHandler(this.FrmTrainingErstellen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnFertig;
        private System.Windows.Forms.ListView lstTraining;
        private System.Windows.Forms.ComboBox cbxKategorie;
        private System.Windows.Forms.ListView lstUebungen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxEinteilung;
    }
}