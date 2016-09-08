namespace Trainingsplaner
{
    partial class FrmTrainingshistorie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnAufwaermen = new System.Windows.Forms.RadioButton();
            this.rbtnTechnik = new System.Windows.Forms.RadioButton();
            this.rbtnAusdauer = new System.Windows.Forms.RadioButton();
            this.rbtnKraft = new System.Windows.Forms.RadioButton();
            this.rbtnLocker = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(12, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(521, 435);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnLocker);
            this.panel1.Controls.Add(this.rbtnKraft);
            this.panel1.Controls.Add(this.rbtnAusdauer);
            this.panel1.Controls.Add(this.rbtnTechnik);
            this.panel1.Controls.Add(this.rbtnAufwaermen);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 21);
            this.panel1.TabIndex = 2;
            // 
            // rbtnAufwaermen
            // 
            this.rbtnAufwaermen.AutoSize = true;
            this.rbtnAufwaermen.Location = new System.Drawing.Point(4, 4);
            this.rbtnAufwaermen.Name = "rbtnAufwaermen";
            this.rbtnAufwaermen.Size = new System.Drawing.Size(84, 17);
            this.rbtnAufwaermen.TabIndex = 0;
            this.rbtnAufwaermen.TabStop = true;
            this.rbtnAufwaermen.Text = "Aufwaermen";
            this.rbtnAufwaermen.UseVisualStyleBackColor = true;
            this.rbtnAufwaermen.CheckedChanged += new System.EventHandler(this.rbtnAufwaermen_CheckedChanged);
            // 
            // rbtnTechnik
            // 
            this.rbtnTechnik.AutoSize = true;
            this.rbtnTechnik.Checked = true;
            this.rbtnTechnik.Location = new System.Drawing.Point(135, 4);
            this.rbtnTechnik.Name = "rbtnTechnik";
            this.rbtnTechnik.Size = new System.Drawing.Size(64, 17);
            this.rbtnTechnik.TabIndex = 1;
            this.rbtnTechnik.TabStop = true;
            this.rbtnTechnik.Text = "Technik";
            this.rbtnTechnik.UseVisualStyleBackColor = true;
            this.rbtnTechnik.CheckedChanged += new System.EventHandler(this.rbtnTechnik_CheckedChanged);
            // 
            // rbtnAusdauer
            // 
            this.rbtnAusdauer.AutoSize = true;
            this.rbtnAusdauer.Location = new System.Drawing.Point(248, 4);
            this.rbtnAusdauer.Name = "rbtnAusdauer";
            this.rbtnAusdauer.Size = new System.Drawing.Size(70, 17);
            this.rbtnAusdauer.TabIndex = 2;
            this.rbtnAusdauer.TabStop = true;
            this.rbtnAusdauer.Text = "Ausdauer";
            this.rbtnAusdauer.UseVisualStyleBackColor = true;
            this.rbtnAusdauer.CheckedChanged += new System.EventHandler(this.rbtnAusdauer_CheckedChanged);
            // 
            // rbtnKraft
            // 
            this.rbtnKraft.AutoSize = true;
            this.rbtnKraft.Location = new System.Drawing.Point(367, 4);
            this.rbtnKraft.Name = "rbtnKraft";
            this.rbtnKraft.Size = new System.Drawing.Size(47, 17);
            this.rbtnKraft.TabIndex = 3;
            this.rbtnKraft.TabStop = true;
            this.rbtnKraft.Text = "Kraft";
            this.rbtnKraft.UseVisualStyleBackColor = true;
            this.rbtnKraft.CheckedChanged += new System.EventHandler(this.rbtnKraft_CheckedChanged);
            // 
            // rbtnLocker
            // 
            this.rbtnLocker.AutoSize = true;
            this.rbtnLocker.Location = new System.Drawing.Point(462, 4);
            this.rbtnLocker.Name = "rbtnLocker";
            this.rbtnLocker.Size = new System.Drawing.Size(58, 17);
            this.rbtnLocker.TabIndex = 4;
            this.rbtnLocker.TabStop = true;
            this.rbtnLocker.Text = "Locker";
            this.rbtnLocker.UseVisualStyleBackColor = true;
            this.rbtnLocker.CheckedChanged += new System.EventHandler(this.rbtnLocker_CheckedChanged);
            // 
            // FrmTrainingshistorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "FrmTrainingshistorie";
            this.Text = "Trainingshistorie";
            this.Load += new System.EventHandler(this.FrmTrainingshistorie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnLocker;
        private System.Windows.Forms.RadioButton rbtnKraft;
        private System.Windows.Forms.RadioButton rbtnAusdauer;
        private System.Windows.Forms.RadioButton rbtnTechnik;
        private System.Windows.Forms.RadioButton rbtnAufwaermen;
    }
}