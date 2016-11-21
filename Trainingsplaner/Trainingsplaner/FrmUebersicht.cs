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
        public bool Open { get; set; }
        Form menuRef;
        public FrmUebersicht(Form menu)
        {
            InitializeComponent();
            menuRef = menu;
            this.Open = true;
            if (menuRef.GetType() == typeof(Form1))
            {
                ((Form1)menuRef).OpenUebersicht = false;
            }
        }

        private void FrmUebersicht_Load(object sender, EventArgs e)
        {
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
                        if (Open == true)
                        {
                            ListViewItem lvi = htInfo.Item;
                            string item = lvi.Text;
                            FrmZirkelDetails frm = new FrmZirkelDetails(this);
                            frm.ZirkelName = item;
                            frm.Show();
                        } 
                    }
                }
            }
            else if(btnBenutzerdefiniert.Checked)
            {
                if (htInfo != null)
                {
                    if (htInfo.Item != null)
                    {
                        if (Open == true)
                        {
                            ListViewItem lvi = htInfo.Item;
                            string item = lvi.Text;
                            FrmBenutzerdefiniertDetails frm = new FrmBenutzerdefiniertDetails(this);
                            frm.UebungsName = item;
                            frm.Show();
                        }  
                    }
                }
            }
            else 
            {
                if (htInfo != null)
                {
                    if (htInfo.Item != null)
                    {
                        if (Open == true)
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
            int counter = 0;
            while (reader.Read())
            {
                if (select.Contains("zirkel"))
                {
                    listView1.View = View.List;
                    listView1.Items.Add(new ListViewItem("" + reader["name"]));
                }
                else
                {
                    string sth = "" + reader["bild"];
                    if (sth == "" || sth == null)
                    {
                        listView1.Items.Add(new ListViewItem("" + reader["name"]));
                    }
                    else
                    {
                        imageList1.Images.Add(Image.FromFile("" + reader["bild"]));
                        listView1.LargeImageList = this.imageList1;
                        listView1.SmallImageList = this.imageList1;
                        listView1.View = View.Tile;

                        listView1.Items.Add(new ListViewItem("" + reader["name"], imageList1.Images.Count-1));
                        counter++;
                    }
                }
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

        private void FrmUebersicht_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuRef.GetType() == typeof(Form1))
            {
                ((Form1)menuRef).OpenUebersicht = true;
            }
        }
    }
}
