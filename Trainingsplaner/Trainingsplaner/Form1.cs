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
        }
        private void initializeDatabase()
        {
            // In Tabelle "zirkel" muss auch noch eine Liste der Übungen welche in diesem Workout durchgeführt werden
            SQLiteConnection.CreateFile("Trainingsplaner.sqlite");
            trainingsDB.Open();
            string create = "create table trainings (kategorie varchar(20), unterkategorie varchar(20), beschreibung varchar(200), name varchar(20), dauer int, bild varchar(100))";
            string create2 = "create table uebungen (kategorie varchar(20), unterkategorie varchar(20), beschreibung varchar(200), name varchar(20), bild varchar(100))";
            string create3 = "create table zirkel (uebungen varchar(1000))";
            SQLiteCommand command = new SQLiteCommand(create, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(create2, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(create3, trainingsDB);
            command.ExecuteNonQuery();
            string insert = "insert into trainings (kategorie, unterkategorie, beschreibung, name, dauer, bild) values ('Aufwaermen','Einlaufen','Verschiedene Übungen in den Ecken','Workout1',15, 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert2 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Burpees', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert3 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Climbers', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert4 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Jumping Jacks', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert5 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Jumps', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert6 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Lunge Walk', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert7 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Pushups', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert8 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Situps', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert9 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Squats', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert10 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Straight Leg Lever', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert11 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Pistols', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert12 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Standup Jumps', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert13 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Pikes', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert14 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','HIIT','Kommt später','Jackknifes', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert15 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Aufwaermen','Laufen','Kommt später','40m Sprint', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert16 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Aufwaermen','Laufen','Kommt später','100m Sprint', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert17 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Aufwaermen','Laufen','Kommt später','200m Sprint', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert18 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Aufwaermen','Laufen','Kommt später','400m Sprint', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert19 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Aufwaermen','Laufen','Kommt später','800m Sprint', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert20 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Aufwaermen','Laufen','Kommt später','1.5km Run', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert21 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Aufwaermen','Laufen','Kommt später','5km Run', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert22 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Aufwaermen','Laufen','Kommt später','8km Run', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert23 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Aufwaermen','Laufen','Kommt später','10km Run', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            command = new SQLiteCommand(insert, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert2, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert3, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert4, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert5, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert6, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert7, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert8, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert9, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert10, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert11, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert12, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert13, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert14, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert15, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert16, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert17, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert18, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert19, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert20, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert21, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert22, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert23, trainingsDB);
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

        private void txtSuche_TextChanged(object sender, EventArgs e)
        {
            //nach Workouts und Übungen
            string suche = txtSuche.Text;
            string select = "select * from trainings";
            trainingsDB.Open();
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    if 
            //}
            trainingsDB.Close();
        }
    }
}
