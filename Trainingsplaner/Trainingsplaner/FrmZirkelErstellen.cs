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
    public partial class FrmZirkelErstellen : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        public FrmZirkelErstellen()
        {
            InitializeComponent();
        }

        private void cbxKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainingsDB.Open();
            string selectedItem = cbxKategorie.SelectedItem.ToString();
            string select = "select name from uebungen where kategorie = "+selectedItem;
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lstUebungen.Items.Add(""+reader["name"]);
            }
            trainingsDB.Close();
        }

        private void FrmZirkelErstellen_Load(object sender, EventArgs e)
        {
            cbxKategorie.Text = "Zirkel";
            trainingsDB.Open();
            string select = "select distinct kategorie from uebungen";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbxKategorie.Items.Add(""+reader["kategorie"]);
            }
            trainingsDB.Close();
        }
    }
}
