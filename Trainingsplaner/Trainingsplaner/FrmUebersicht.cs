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
    public partial class FrmUebersicht : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        public FrmUebersicht()
        {
            InitializeComponent();
        }

        private void FrmUebersicht_Load(object sender, EventArgs e)
        {
            //addImagesToListView();
            radiobuttonCheckedChanged();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo htInfo = listView1.HitTest(e.X, e.Y);

            if (rbtnZirkel.Checked)
            {
                if (htInfo != null)
                {
                    if (htInfo.Item != null)
                    {
                        ListViewItem lvi = htInfo.Item;
                        string item = lvi.Text;
                        FrmZirkelDetails frm = new FrmZirkelDetails(this);
                        frm.ZirkelName = item;
                        frm.Show();
                    }
                }
            }
            else
            {
                if (htInfo != null)
                {
                    if (htInfo.Item != null)
                    {
                        ListViewItem lvi = htInfo.Item;
                        string item = lvi.Text;
                        FrmUebungsDetails frm = new FrmUebungsDetails(this);
                        frm.UebungsName = item;
                        frm.Show();
                    }
                }
            }        
        }

        public void ReloadList()
        {
            radiobuttonCheckedChanged();
        }

        private void rbtnAusdauer_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonCheckedChanged();
        }

        private void rbtnHIIT_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonCheckedChanged();
        }

        private void rbtnDehnen_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonCheckedChanged();
        }
        private void radiobuttonCheckedChanged ()
        {
            listView1.Items.Clear();
            string select = "";
            if (rbtnAusdauer.Checked)
            {
                select = "select name, bild from uebungen where kategorie = 'Laufen'";
            }
            else if (rbtnHIIT.Checked)
            {
                select = "select name, bild from uebungen where kategorie = 'HIIT'";
            }
            else if (rbtnZirkel.Checked)
            {
                select = "select name from zirkel";
            }
            else if (btnBenutzerdefiniert.Checked)
            {
                select = "select name, bild from uebungen where kategorie = 'Benutzerdefiniert'";
            }
            else if (btnTechnik.Checked)
            {
                select = "select name, bild from uebungen where kategorie = 'Technik'";
            }
            trainingsDB.Open();
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string sth = "" + reader["bild"];
                imageList1.Images.Add(Image.FromFile("" + reader["bild"]));
                listView1.LargeImageList = imageList1;
                listView1.SmallImageList = imageList1;
                listView1.View = View.Details;
                
                listView1.Items.Add(new ListViewItem { ImageIndex = 0, Text = ""+reader["name"]});
            }
            trainingsDB.Close();
        }

        private void rbtnZirkel_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonCheckedChanged();    
        }

        private void btnTechnik_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonCheckedChanged();
        }

        private void btnBenutzerdefiniert_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonCheckedChanged();
        }
        private void addImagesToListView ()
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
            this.listView1.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(42, 42);
            this.listView1.LargeImageList = this.imageList1;

            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listView1.Items.Add(item);
            }
        }
    }
}
