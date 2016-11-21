using Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
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
        Form neueUebungRef;
        public FrmBenutzerdefinierteUebung(Form neueUebung)
        {
            InitializeComponent();
            this.neueUebungRef = neueUebung;
            if (neueUebungRef.GetType() == typeof(FrmNeueUebung))
            {
                ((FrmNeueUebung)neueUebungRef).Open = false;
            }
        }

        private void FrmBenutzerdefinierteUebung_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            addImagesToListView();
           // AddPBs(1);
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
                //PB.Location = new Point(x,y);
                PB.Parent = panel1;
                PB.DragEnter += PB_DragEnter;
                PB.DragDrop += PB_DragDrop;
                PB.PreviewKeyDown += PB_PreviewKeyDown;
                PB.AllowDrop = true;
                PB.BackColor = Color.Transparent;
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
            //AddPBs(1, e.Y, e.X);
            PictureBox pb = sender as PictureBox;
            var item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            int index = item.ImageIndex;
            pb.Image = imageList1.Images[index];  // make sure you have images for indices!!
            //pb.Top = e.Y;
            //pb.Left = e.X;           
        }
        private void PB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                PictureBox pb = sender as PictureBox;
                pb.Visible = false;
            }
        }
        private void addImagesToListView()
        {
            string path = ConfigurationManager.AppSettings["BasePath"];
            DirectoryInfo dir = new DirectoryInfo(@""+path);

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
            AddPBs(50);
            lstZeichenBehaelter.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void FrmBenutzerdefinierteUebung_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentPB == null) return;
            
            if (e.KeyData == Keys.Left) currentPB.Left -= 3; 
            else if (e.KeyData == Keys.Right) currentPB.Left += 3;
            else if (e.KeyData == Keys.Up) currentPB.Top -= 3;
            else if (e.KeyData == Keys.Down) currentPB.Top += 3;
            //else
            //{
            //    int z = panel1.Controls.GetChildIndex(currentPB);
            //    if (e.KeyData == Keys.Home) panel1.Controls.SetChildIndex(currentPB, 0);
            //    else if (e.KeyData == Keys.End)
            //        panel1.Controls.SetChildIndex(currentPB, panel1.Controls.Count);
            //    else if (e.KeyData == Keys.PageUp)
            //        panel1.Controls.SetChildIndex(currentPB, z + 1);
            //    else if (e.KeyData == Keys.PageDown)
            //    { if (z > 0) panel1.Controls.SetChildIndex(currentPB, z - 1); }
            //}
            panel1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetImageFromPanel();
        }
        private void GetImageFromPanel()
        {
            if (!txtName.Text.Equals(""))
            {
                Bitmap bm = new Bitmap(panel1.Size.Width, panel1.Size.Height);
                panel1.DrawToBitmap(bm, new Rectangle(0, 0, panel1.Size.Width, panel1.Size.Height));

                string path = ConfigurationManager.AppSettings["BasePath"];
                string destination = "";
                string description = rtbBeschreibung.Text;
                if (description.Equals(""))
                {
                    description = "Es wurde keine Beschreibung für diese Übung erstellt";
                }
                if (!System.IO.Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                destination = path + "\\" + txtName.Text+".jpg";
                bm.Save(@"" + destination, ImageFormat.Jpeg);
                trainingsDB.Open();
                string insert = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Benutzerdefiniert','"+description+ "','" + txtName.Text + "','" + destination + "')";
                SQLiteCommand command = new SQLiteCommand(insert, trainingsDB);
                command.ExecuteNonQuery();
                trainingsDB.Close();
                if (MessageBox.Show("Benutzerdefinierte Übung wurde erfolgreich gespeichert!", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sie haben dieser Übung noch keinen Namen gegeben!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private static Image ResizeImage(int newSize, Image originalImage)
        {
            if (originalImage.Width <= newSize)
                newSize = originalImage.Width;

            var newHeight = originalImage.Height * newSize / originalImage.Width;

            if (newHeight > newSize)
            {
                // Resize with height instead
                newSize = originalImage.Width * newSize / originalImage.Height;
                newHeight = newSize;
            }

            return originalImage.GetThumbnailImage(newSize, newHeight, null, IntPtr.Zero);
            //http://stackoverflow.com/questions/1922040/resize-an-image-c-sharp
        }

        private void FrmBenutzerdefinierteUebung_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (neueUebungRef.GetType() == typeof(FrmNeueUebung))
            {
                ((FrmNeueUebung)neueUebungRef).Open = true;
            }
        }
        //public Image CapturePanel(Control ctrl)
        //{
        //    Graphics g = this.CreateGraphics();

        //    // Ein neues Image mit der grösse des jeweiligen Controls anlegen
        //    Image newImage = new Bitmap(ctrl.Size.Width, ctrl.Size.Height, g);

        //    Graphics memoryGraphics = Graphics.FromImage(newImage);
        //    //Handle holen
        //    IntPtr src = g.GetHdc();
        //    IntPtr dest = memoryGraphics.GetHdc();

        //    // das Handle des Ziels
        //    // die X Position an der das Bild eingefügt werden soll
        //    // die Y Position an der das Bild eingefügt werden soll
        //    // die breite des Bildes
        //    // die höhe des Bildes
        //    // das Handle der Quelle
        //    // die X Position an der das Control liegt
        //    // die Y Position an der das Control liegt
        //    // Raster Operation Code an dieser Stelle ist es SRCCOPY
        //    // Natürlich muß der auf der Seite angegebene Hex wert noch in ein int umgerechnet werden
        //    // mehr informationen auf http://msdn.microsoft.com/library/default.asp?url=/library/en-us/wceui40/html/_celrfternaryrasteroperations.asp
        //    BitBlt(dest, 0, 0, ctrl.ClientRectangle.Width, ctrl.ClientRectangle.Height, src, ctrl.Location.X, ctrl.Location.Y, 13369376);

        //    // Handles wieder Freigeben
        //    g.ReleaseHdc(dest);
        //    memoryGraphics.ReleaseHdc(src);
        //    return newImage;
        //}
    }
}
