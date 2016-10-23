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
    public partial class FrmSuche : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        public FrmSuche()
        {
            InitializeComponent();
        }

        private void FrmSuche_Load(object sender, EventArgs e)
        {

        }

        private void txtSuche_TextChanged(object sender, EventArgs e)
        {
            trainingsDB.Open();
            lstResults.Clear();
            string suche = txtSuche.Text.ToLower();
            string select = "select name from uebungen";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["name"].ToString().ToLower().Contains(suche))
                {
                    lstResults.Items.Add(""+reader["name"]);
                }
            }
            string select2 = "select name from zirkel";
            command = new SQLiteCommand(select2, trainingsDB);
            command.ExecuteNonQuery();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["name"].ToString().ToLower().Contains(suche))
                {
                    lstResults.Items.Add("" + reader["name"]);
                }
            }
            string select3 = "select name from trainings";
            command = new SQLiteCommand(select3, trainingsDB);
            command.ExecuteNonQuery();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["name"].ToString().ToLower().Contains(suche))
                {
                    lstResults.Items.Add("" + reader["name"]);
                }
            }
            trainingsDB.Close();
        }

        private void lstResults_MouseClick(object sender, MouseEventArgs e)
        {
            trainingsDB.Open();
            ListViewHitTestInfo htInfo = lstResults.HitTest(e.X, e.Y);
            if (htInfo != null)
            {
                if (htInfo.Item != null)
                {
                    ListViewItem lvi = htInfo.Item;
                    string item = lvi.Text;
                    string select = "select name from uebungen";
                    SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
                    command.ExecuteNonQuery();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["name"].ToString() == item)
                        {
                            FrmUebungsDetails frm = new FrmUebungsDetails(this);
                            frm.UebungsName = item;
                            frm.Show();
                        }
                    }
                    string select2 = "select name from zirkel";
                    command = new SQLiteCommand(select2, trainingsDB);
                    command.ExecuteNonQuery();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["name"].ToString() == item)
                        {
                            FrmZirkelDetails frm = new FrmZirkelDetails(this);
                            frm.ZirkelName = item;
                            frm.Show();
                        }
                    }
                    string select3 = "select name from trainings";
                    command = new SQLiteCommand(select3, trainingsDB);
                    command.ExecuteNonQuery();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["name"].ToString() == item)
                        {
                            FrmTrainingsDetails frm = new FrmTrainingsDetails(this);
                            frm.TrainingsName = item;
                            frm.Show();
                        }
                    }
                    trainingsDB.Close();
                }
            }
        }
    }
}
