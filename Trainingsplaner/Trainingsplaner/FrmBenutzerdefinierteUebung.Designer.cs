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
            this.cbxKategorie = new System.Windows.Forms.ComboBox();
            this.lstZeichenBehaelter = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
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
            // 
            // lstZeichenBehaelter
            // 
            this.lstZeichenBehaelter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstZeichenBehaelter.Location = new System.Drawing.Point(12, 36);
            this.lstZeichenBehaelter.Name = "lstZeichenBehaelter";
            this.lstZeichenBehaelter.Size = new System.Drawing.Size(250, 509);
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
            this.panel1.Location = new System.Drawing.Point(269, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 509);
            this.panel1.TabIndex = 8;
            // 
            // FrmBenutzerdefinierteUebung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxKategorie);
            this.Controls.Add(this.lstZeichenBehaelter);
            this.Name = "FrmBenutzerdefinierteUebung";
            this.Text = "Uebung erstellen";
            this.Load += new System.EventHandler(this.FrmBenutzerdefinierteUebung_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBenutzerdefinierteUebung_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKategorie;
        private System.Windows.Forms.ListView lstZeichenBehaelter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
    }
}