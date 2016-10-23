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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rbtnHIIT = new System.Windows.Forms.RadioButton();
            this.rbtnAusdauer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBenutzerdefiniert = new System.Windows.Forms.RadioButton();
            this.btnTechnik = new System.Windows.Forms.RadioButton();
            this.rbtnZirkel = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            // rbtnHIIT
            // 
            this.rbtnHIIT.AutoSize = true;
            this.rbtnHIIT.Location = new System.Drawing.Point(163, 3);
            this.rbtnHIIT.Name = "rbtnHIIT";
            this.rbtnHIIT.Size = new System.Drawing.Size(46, 17);
            this.rbtnHIIT.TabIndex = 1;
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
            this.panel1.Controls.Add(this.btnBenutzerdefiniert);
            this.panel1.Controls.Add(this.btnTechnik);
            this.panel1.Controls.Add(this.rbtnZirkel);
            this.panel1.Controls.Add(this.rbtnAusdauer);
            this.panel1.Controls.Add(this.rbtnHIIT);
            this.panel1.Location = new System.Drawing.Point(11, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 27);
            this.panel1.TabIndex = 2;
            // 
            // btnBenutzerdefiniert
            // 
            this.btnBenutzerdefiniert.AutoSize = true;
            this.btnBenutzerdefiniert.Location = new System.Drawing.Point(351, 3);
            this.btnBenutzerdefiniert.Name = "btnBenutzerdefiniert";
            this.btnBenutzerdefiniert.Size = new System.Drawing.Size(104, 17);
            this.btnBenutzerdefiniert.TabIndex = 5;
            this.btnBenutzerdefiniert.Text = "Benutzerdefiniert";
            this.btnBenutzerdefiniert.UseVisualStyleBackColor = true;
            this.btnBenutzerdefiniert.CheckedChanged += new System.EventHandler(this.btnBenutzerdefiniert_CheckedChanged);
            // 
            // btnTechnik
            // 
            this.btnTechnik.AutoSize = true;
            this.btnTechnik.Checked = true;
            this.btnTechnik.Location = new System.Drawing.Point(245, 3);
            this.btnTechnik.Name = "btnTechnik";
            this.btnTechnik.Size = new System.Drawing.Size(64, 17);
            this.btnTechnik.TabIndex = 4;
            this.btnTechnik.TabStop = true;
            this.btnTechnik.Text = "Technik";
            this.btnTechnik.UseVisualStyleBackColor = true;
            this.btnTechnik.CheckedChanged += new System.EventHandler(this.btnTechnik_CheckedChanged);
            // 
            // rbtnZirkel
            // 
            this.rbtnZirkel.AutoSize = true;
            this.rbtnZirkel.Location = new System.Drawing.Point(490, 3);
            this.rbtnZirkel.Name = "rbtnZirkel";
            this.rbtnZirkel.Size = new System.Drawing.Size(51, 17);
            this.rbtnZirkel.TabIndex = 3;
            this.rbtnZirkel.TabStop = true;
            this.rbtnZirkel.Text = "Zirkel";
            this.rbtnZirkel.UseVisualStyleBackColor = true;
            this.rbtnZirkel.CheckedChanged += new System.EventHandler(this.rbtnZirkel_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
        private System.Windows.Forms.RadioButton rbtnHIIT;
        private System.Windows.Forms.RadioButton rbtnAusdauer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnZirkel;
        private System.Windows.Forms.RadioButton btnBenutzerdefiniert;
        private System.Windows.Forms.RadioButton btnTechnik;
        private System.Windows.Forms.ImageList imageList1;
    }
}