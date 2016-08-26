using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
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
            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo htInfo = listView1.HitTest(e.X, e.Y);

            if (htInfo != null)
            {
                if (htInfo.Item != null)
                {
                    ListViewItem lvi = htInfo.Item;
                    string item = lvi.Text;
                    FrmUebungsDetails frm = new FrmUebungsDetails();
                    frm.UebungsName = item;
                    frm.Show();
                }
            }
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
                select = "select name from uebungen where unterkategorie = 'Laufen'";
            }
            else if (rbtnHIIT.Checked)
            {
                select = "select name from uebungen where unterkategorie = 'HIIT'";
            }
            else
            {
                select = "select name from uebungen where unterkategorie = 'Dehnen'";
            }
            trainingsDB.Open();
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listView1.Items.Add("" + reader["name"]);
            }
            trainingsDB.Close();
        }
    }
}
