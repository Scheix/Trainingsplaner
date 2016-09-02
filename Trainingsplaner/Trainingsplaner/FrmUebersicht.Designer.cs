namespace Trainingsplaner
{
    partial class FrmUebersicht
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.rbtnDehnen = new System.Windows.Forms.RadioButton();
            this.rbtnHIIT = new System.Windows.Forms.RadioButton();
            this.rbtnAusdauer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnZirkel = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(10, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(554, 489);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // rbtnDehnen
            // 
            this.rbtnDehnen.AutoSize = true;
            this.rbtnDehnen.Location = new System.Drawing.Point(487, 3);
            this.rbtnDehnen.Name = "rbtnDehnen";
            this.rbtnDehnen.Size = new System.Drawing.Size(63, 17);
            this.rbtnDehnen.TabIndex = 2;
            this.rbtnDehnen.TabStop = true;
            this.rbtnDehnen.Text = "Dehnen";
            this.rbtnDehnen.UseVisualStyleBackColor = true;
            this.rbtnDehnen.CheckedChanged += new System.EventHandler(this.rbtnDehnen_CheckedChanged);
            // 
            // rbtnHIIT
            // 
            this.rbtnHIIT.AutoSize = true;
            this.rbtnHIIT.Location = new System.Drawing.Point(202, 3);
            this.rbtnHIIT.Name = "rbtnHIIT";
            this.rbtnHIIT.Size = new System.Drawing.Size(46, 17);
            this.rbtnHIIT.TabIndex = 1;
            this.rbtnHIIT.TabStop = true;
            this.rbtnHIIT.Text = "HIIT";
            this.rbtnHIIT.UseVisualStyleBackColor = true;
            this.rbtnHIIT.CheckedChanged += new System.EventHandler(this.rbtnHIIT_CheckedChanged);
            // 
            // rbtnAusdauer
            // 
            this.rbtnAusdauer.AutoSize = true;
            this.rbtnAusdauer.Location = new System.Drawing.Point(3, 3);
            this.rbtnAusdauer.Name = "rbtnAusdauer";
            this.rbtnAusdauer.Size = new System.Drawing.Size(131, 17);
            this.rbtnAusdauer.TabIndex = 0;
            this.rbtnAusdauer.TabStop = true;
            this.rbtnAusdauer.Text = "Ausdauer/Schnellkraft";
            this.rbtnAusdauer.UseVisualStyleBackColor = true;
            this.rbtnAusdauer.CheckedChanged += new System.EventHandler(this.rbtnAusdauer_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnZirkel);
            this.panel1.Controls.Add(this.rbtnDehnen);
            this.panel1.Controls.Add(this.rbtnAusdauer);
            this.panel1.Controls.Add(this.rbtnHIIT);
            this.panel1.Location = new System.Drawing.Point(11, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 27);
            this.panel1.TabIndex = 2;
            // 
            // rbtnZirkel
            // 
            this.rbtnZirkel.AutoSize = true;
            this.rbtnZirkel.Location = new System.Drawing.Point(327, 3);
            this.rbtnZirkel.Name = "rbtnZirkel";
            this.rbtnZirkel.Size = new System.Drawing.Size(51, 17);
            this.rbtnZirkel.TabIndex = 3;
            this.rbtnZirkel.TabStop = true;
            this.rbtnZirkel.Text = "Zirkel";
            this.rbtnZirkel.UseVisualStyleBackColor = true;
            this.rbtnZirkel.CheckedChanged += new System.EventHandler(this.rbtnZirkel_CheckedChanged);
            // 
            // FrmUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "FrmUebersicht";
            this.Text = "Uebungs-Uebersicht";
            this.Load += new System.EventHandler(this.FrmUebersicht_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbtnDehnen;
        private System.Windows.Forms.RadioButton rbtnHIIT;
        private System.Windows.Forms.RadioButton rbtnAusdauer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnZirkel;
    }
}