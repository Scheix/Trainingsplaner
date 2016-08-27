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
    public partial class FrmTrainingshistorie : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        public FrmTrainingshistorie()
        {
            InitializeComponent();
        }

        private void FrmTrainingshistorie_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string select = "select name from trainings";
            trainingsDB.Open();
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listView1.Items.Add("" + reader["name"]);
            }
            trainingsDB.Close();
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
                    FrmTrainingsDetails frm = new FrmTrainingsDetails();
                    frm.TrainingsName = item;
                    frm.Show();
                }
            }
        }
    }
}
