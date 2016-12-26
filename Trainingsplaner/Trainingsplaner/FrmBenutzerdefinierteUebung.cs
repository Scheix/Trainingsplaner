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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainingsplaner
{
    //Fragen wegen besserer Lösung bezüglich dem Rausfinden ob das zu verschiebende Bild ein Spielfeld ist
    //Fragen wegen genauerer Erklärung des Codes
    //Fragen wiso am Anfang so viele Spielfeldbilder da sind
  public partial class FrmBenutzerdefinierteUebung : Form
  {
    #region otherStuff top
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
      cbxKategorie.Items.Add("Spielfeld");
      cbxKategorie.Items.Add("Spieler");
      cbxKategorie.Items.Add("Pfeile");
      cbxKategorie.Items.Add("Ball");
      cbxKategorie.SelectedItem = cbxKategorie.Items[0];    
      KeyPreview = true;
      addImagesToListView();
      typeof(Panel).InvokeMember("DoubleBuffered",
        BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
        null,
        panel1,
        new object[] { true });
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
        //PB.MouseClick += (ss, ee) => { currentPB = PB; PB.Focus(); };
      }
    }
    private void PB_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(typeof(ListViewItem)))
        e.Effect = DragDropEffects.Move;
      else
        e.Effect = DragDropEffects.None;
    }
    #endregion

    private class PositionedImage
    {
      public int Top { get; set; }
      public int Left { get; set; }
      public Image Image { get; set; }
    }
    private PositionedImage activeImage = null;
    private List<PositionedImage> positionedImages = new List<PositionedImage>();
    private void PB_DragDrop(object sender, DragEventArgs e)
    {
      var item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
      int index = item.ImageIndex;
      var image = imageList1.Images[index];
      var transformedPoint = panel1.PointToClient(new Point(e.X, e.Y));
      var pi = new PositionedImage { Top = transformedPoint.Y, Left = transformedPoint.X, Image = image };
      positionedImages.Add(pi);
      panel1.Invalidate();
    }

    private void panel1_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left) return;
      activeImage = null;
      Console.WriteLine(nameof(panel1_MouseUp));
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left) return;
      const int imageSize = 100;
      int x = e.X;
      int y = e.Y;
      foreach (var item in positionedImages)
      {
        int up = item.Top;
        int down = item.Top + imageSize;
        int left = item.Left;
        int right = item.Left + imageSize;
        if (x >= left && x <= right
            && y >= up && y <= down)
        {
          activeImage = item;
          Console.WriteLine(nameof(panel1_MouseDown));
        }
      }
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      //see activation of double buffering in FrmBenutzerdefinierteUebung_Load to avoid "blinking"
      Console.WriteLine($"{nameof(panel1_MouseMove)} activePictureBox null -->{activeImage == null}");
      if (activeImage == null) return;
      var transformedPoint = new Point(e.X, e.Y);
      activeImage.Top = transformedPoint.Y;
      activeImage.Left = transformedPoint.X;
      panel1.Invalidate();
    }
    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      var g = e.Graphics;
      foreach (var item in positionedImages)
      {
        g.DrawImage(item.Image, item.Left, item.Top);
      }
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
      DirectoryInfo dir = new DirectoryInfo(@"" + path); ;
      if (cbxKategorie.SelectedItem.ToString().Equals("Spielfeld"))
      {
          dir = new DirectoryInfo(@"" + path+"\\Spielfeld");
      }
      else if (cbxKategorie.SelectedItem.ToString().Equals("Spieler"))
      {
           dir = new DirectoryInfo(@"" + path + "\\Spieler");
      }
      else if (cbxKategorie.SelectedItem.ToString().Equals("Pfeile"))
      {
           dir = new DirectoryInfo(@"" + path + "\\Pfeile");
      }
      else
      {
           dir = new DirectoryInfo(@"" + path + "\\Ball");
      }
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
      //AddPBs(50);
      lstZeichenBehaelter.DoDragDrop(e.Item, DragDropEffects.Move);
    }

    private void FrmBenutzerdefinierteUebung_KeyDown(object sender, KeyEventArgs e)
    {
      if (currentPB == null) return;

      if (e.KeyData == Keys.Left) currentPB.Left -= 3;
      else if (e.KeyData == Keys.Right) currentPB.Left += 3;
      else if (e.KeyData == Keys.Up) currentPB.Top -= 3;
      else if (e.KeyData == Keys.Down) currentPB.Top += 3;
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

        string path = ConfigurationManager.AppSettings["BasePath"]+"\\Uebungen";
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
        destination = path + "\\" + txtName.Text + ".jpg";
        bm.Save(@"" + destination, ImageFormat.Jpeg);
        trainingsDB.Open();
        string insert = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Benutzerdefiniert','" + description + "','" + txtName.Text + "','" + destination + "')";
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
        private void cbxKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstZeichenBehaelter.Items.Clear();
            this.imageList1.Images.Clear();
            addImagesToListView();
        }
    }
}
