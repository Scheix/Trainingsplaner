using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data.Entity;

namespace Trainingsplaner
{
    public partial class Form1 : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Change the directory of the project of simon und michael to the same folder, because of the import of the pictures
            initializeDatabase();
            string select = "select kategorie, bild from trainingsplaner";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.Text = "" + reader["kategorie"];
                pctboxTrainingErstellen.Image = Image.FromFile(""+reader["bild"]);
            }
            trainingsDB.Close();
        }
        private void initializeDatabase ()
        {
            SQLiteConnection.CreateFile("Trainingsplaner.sqlite");
            trainingsDB.Open();
            string create = "create table trainingsplaner (kategorie varchar(20), unterkategorie varchar(20), beschreibung varchar(200), name varchar(20), dauer int, bild varchar(100))";
            SQLiteCommand command = new SQLiteCommand(create, trainingsDB);
            command.ExecuteNonQuery();
            string insert = "insert into trainingsplaner (kategorie, unterkategorie, beschreibung, name, dauer, bild) values ('Aufwaermen','Einlaufen','Verschiedene Übungen in den Ecken','Workout1',15, 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            command = new SQLiteCommand(insert, trainingsDB);
            command.ExecuteNonQuery();
        }

        private void pctboxTrainingErstellen_Click(object sender, EventArgs e)
        {
            FrmTrainingErstellen frm = new FrmTrainingErstellen();
            frm.Show();
        }

        private void pctboxTrainings_Click(object sender, EventArgs e)
        {
            FrmTrainingshistorie frm = new FrmTrainingshistorie();
            frm.Show();
        }

        private void pctboxNeueUebung_Click(object sender, EventArgs e)
        {
            FrmNeueUebung frm = new FrmNeueUebung();
            frm.Show();
        }

        private void pctboxUebersicht_Click(object sender, EventArgs e)
        {
            FrmUebersicht frm = new FrmUebersicht();
            frm.Show();
        }
    }
}
