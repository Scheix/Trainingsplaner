namespace Trainingsplaner
{
    partial class FrmErstellauswahl
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
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnZirkel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTraining
            // 
            this.btnTraining.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraining.Location = new System.Drawing.Point(12, 12);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(260, 166);
            this.btnTraining.TabIndex = 0;
            this.btnTraining.Text = "Training erstellen";
            this.btnTraining.UseVisualStyleBackColor = false;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnZirkel
            // 
            this.btnZirkel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnZirkel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZirkel.Location = new System.Drawing.Point(12, 184);
            this.btnZirkel.Name = "btnZirkel";
            this.btnZirkel.Size = new System.Drawing.Size(260, 166);
            this.btnZirkel.TabIndex = 1;
            this.btnZirkel.Text = "Zirkel erstellen";
            this.btnZirkel.UseVisualStyleBackColor = false;
            this.btnZirkel.Click += new System.EventHandler(this.btnZirkel_Click);
            // 
            // FrmErstellauswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(284, 359);
            this.Controls.Add(this.btnZirkel);
            this.Controls.Add(this.btnTraining);
            this.Name = "FrmErstellauswahl";
            this.Text = "FrmErstellauswahl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnZirkel;
    }
}