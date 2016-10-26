using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainingsplaner
{
    public partial class FrmBenutzerdefinierteUebung : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        PictureBox currentPB = null;
        public FrmBenutzerdefinierteUebung()
        {
            InitializeComponent();
        }

        private void FrmBenutzerdefinierteUebung_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            addImagesToListView();
            AddPBs(36);
        }
        private void AddPBs(int count)
        {
            int iWidth = imageList1.ImageSize.Width;
            int iHeight = imageList1.ImageSize.Height;
            int cols = panel1.ClientSize.Width / iWidth;

            for (int i = 0; i < count; i++)
            {
                PictureBox PB = new PictureBox();
                PB.BackColor = Color.LightGray;
                PB.Margin = new System.Windows.Forms.Padding(0);
                PB.ClientSize = new System.Drawing.Size(iWidth, iHeight);
                PB.Location = new Point(iWidth * (i % cols), iHeight * (i / cols));
                PB.Parent = panel1;
                PB.DragEnter += PB_DragEnter;
                PB.DragDrop += PB_DragDrop;
                PB.AllowDrop = true;
                PB.MouseClick += (ss, ee) => { currentPB = PB; PB.Focus(); };
            }
        }
        private void PB_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void PB_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            var item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            int index = item.ImageIndex;
            pb.Image = imageList1.Images[index];  // make sure you have images for indices!!

        }
        private void addImagesToListView()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Trainingsplaner\Fotos");

            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
            lstZeichenBehaelter.View = View.LargeIcon;
            //lstZeichenBehaelter.View = View.Details;
            imageList1.ImageSize = new Size(100, 100);
            lstZeichenBehaelter.LargeImageList = this.imageList1;

            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                lstZeichenBehaelter.Items.Add(item);
            }
        }

        private void lstZeichenBehaelter_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lstZeichenBehaelter.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void FrmBenutzerdefinierteUebung_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentPB == null) return;
            if (e.KeyData == Keys.Left) currentPB.Left -= 1;
            else if (e.KeyData == Keys.Right) currentPB.Left += 1;
            else if (e.KeyData == Keys.Up) currentPB.Top -= 1;
            else if (e.KeyData == Keys.Down) currentPB.Top += 1;
            else
            {
                int z = panel1.Controls.GetChildIndex(currentPB);
                if (e.KeyData == Keys.Home) panel1.Controls.SetChildIndex(currentPB, 0);
                else if (e.KeyData == Keys.End)
                    panel1.Controls.SetChildIndex(currentPB, panel1.Controls.Count);
                else if (e.KeyData == Keys.PageUp)
                    panel1.Controls.SetChildIndex(currentPB, z + 1);
                else if (e.KeyData == Keys.PageDown)
                { if (z > 0) panel1.Controls.SetChildIndex(currentPB, z - 1); }
            }
            panel1.Invalidate();
        }
    }
}
