namespace Trainingsplaner
{
    partial class FrmBenutzerdefinierteUebung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBenutzerdefinierteUebung));
            this.cbxKategorie = new System.Windows.Forms.ComboBox();
            this.lstZeichenBehaelter = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbBeschreibung = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxKategorie
            // 
            this.cbxKategorie.FormattingEnabled = true;
            this.cbxKategorie.Location = new System.Drawing.Point(12, 9);
            this.cbxKategorie.Name = "cbxKategorie";
            this.cbxKategorie.Size = new System.Drawing.Size(250, 21);
            this.cbxKategorie.TabIndex = 7;
            this.cbxKategorie.Text = "Grund";
            this.cbxKategorie.SelectedIndexChanged += new System.EventHandler(this.cbxKategorie_SelectedIndexChanged);
            // 
            // lstZeichenBehaelter
            // 
            this.lstZeichenBehaelter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstZeichenBehaelter.Location = new System.Drawing.Point(12, 36);
            this.lstZeichenBehaelter.Name = "lstZeichenBehaelter";
            this.lstZeichenBehaelter.Size = new System.Drawing.Size(250, 693);
            this.lstZeichenBehaelter.TabIndex = 6;
            this.lstZeichenBehaelter.UseCompatibleStateImageBehavior = false;
            this.lstZeichenBehaelter.View = System.Windows.Forms.View.Tile;
            this.lstZeichenBehaelter.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstZeichenBehaelter_ItemDrag);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(274, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 667);
            this.panel1.TabIndex = 8;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.PB_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PB_DragEnter);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(916, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 32);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1022, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1017, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(1022, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 32);
            this.txtName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1017, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Beschreibung:";
            // 
            // rtbBeschreibung
            // 
            this.rtbBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBeschreibung.Location = new System.Drawing.Point(1022, 122);
            this.rtbBeschreibung.Name = "rtbBeschreibung";
            this.rtbBeschreibung.Size = new System.Drawing.Size(320, 528);
            this.rtbBeschreibung.TabIndex = 15;
            this.rtbBeschreibung.Text = "";
            // 
            // FrmBenutzerdefinierteUebung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.rtbBeschreibung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxKategorie);
            this.Controls.Add(this.lstZeichenBehaelter);
            this.Name = "FrmBenutzerdefinierteUebung";
            this.Text = "Uebung erstellen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBenutzerdefinierteUebung_FormClosed);
            this.Load += new System.EventHandler(this.FrmBenutzerdefinierteUebung_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBenutzerdefinierteUebung_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKategorie;
        private System.Windows.Forms.ListView lstZeichenBehaelter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbBeschreibung;
    }
}