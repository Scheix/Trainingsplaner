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
            trainingsDB.Open();
            string select = "select name from uebungen";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listView1.Items.Add(""+reader["name"]);
            }
            trainingsDB.Close();
        }
    }
}
