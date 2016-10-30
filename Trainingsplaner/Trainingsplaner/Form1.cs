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
using Configuration;

namespace Trainingsplaner
{
    public partial class Form1 : Form
    {
        // Facebook anbindung
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeDatabase();
            //trainingsDB.Open();
            //string delete = "delete from uebungen where name = 'lkjkl'";
            //SQLiteCommand command = new SQLiteCommand(delete, trainingsDB);
            //command.ExecuteNonQuery();
            //trainingsDB.Close();
        }
        private void pctboxTrainingErstellen_Click(object sender, EventArgs e)
        {
            FrmErstellauswahl frm = new FrmErstellauswahl();
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
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void initializeDatabase()
        {
            if (!System.IO.File.Exists("Trainingsplaner.sqlite"))
            {
                string path = ConfigurationManager.AppSettings["BasePath"];
                SQLiteConnection.CreateFile("Trainingsplaner.sqlite");
                trainingsDB.Open();
                // Kategorie in trainings übernehmen, ausdauer training, technick...
                string create = "create table trainings (name varchar(20), uebungen varchar(1000), kategorie varchar(20))";
                string create2 = "create table uebungen (kategorie varchar(20), beschreibung varchar(200), name varchar(20), bild varchar(100))";
                string create3 = "create table zirkel (name varchar(20), uebungen varchar(1000), dauer varchar(20))";
                string create4 = "create table termine (name varchar(40), date varchar(20))";
                SQLiteCommand command = new SQLiteCommand(create, trainingsDB);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(create2, trainingsDB);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(create3, trainingsDB);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(create4, trainingsDB);
                command.ExecuteNonQuery();
                string insert2 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Burpees','" + path + "\\pirelli.png')";
                string insert3 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Climbers','" + path + "\\pirelli.png')";
                string insert4 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Jumping Jacks','" + path + "\\pirelli.png')";
                string insert5 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Jumps', '" + path + "\\pirelli.png')";
                string insert6 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Lunge Walk','" + path + "\\pirelli.png')";
                string insert7 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Pushups','" + path + "\\pirelli.png')";
                string insert8 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Situps','" + path + "\\pirelli.png')";
                string insert9 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Squats','" + path + "\\pirelli.png')";
                string insert10 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Straight Leg Lever','" + path + "\\pirelli.png')";
                string insert11 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Pistols','" + path + "\\pirelli.png')";
                string insert12 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Standup Jumps','" + path + "\\pirelli.png')";
                string insert13 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Pikes','" + path + "\\pirelli.png')";
                string insert14 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('HIIT','Kommt später','Jackknifes','" + path + "\\pirelli.png')";
                string insert15 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Laufen','Kommt später','40m Sprint','" + path + "\\pirelli.png')";
                string insert16 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Laufen','Kommt später','100m Sprint','" + path + "\\pirelli.png')";
                string insert17 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Laufen','Kommt später','200m Sprint', '" + path + "\\pirelli.png')";
                string insert18 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Laufen','Kommt später','400m Sprint','" + path + "\\pirelli.png')";
                string insert19 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Laufen','Kommt später','800m Sprint','" + path + "\\pirelli.png')";
                string insert20 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Laufen','Kommt später','1.5km Run','" + path + "\\pirelli.png')";
                string insert21 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Laufen','Kommt später','5km Run', '" + path + "\\pirelli.png')";
                string insert22 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Laufen','Kommt später','8km Run','" + path + "\\pirelli.png')";
                string insert23 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Laufen','Kommt später','10km Run','" + path + "\\pirelli.png')";
                string insert24 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Pause','Pause machen','10s Pause','" + path + "\\pirelli.png')";
                string insert25 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Pause','Pause machen','20s Pause','" + path + "\\pirelli.png')";
                string insert26 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Pause','Pause machen','30s Pause','" + path + "\\pirelli.png')";
                string insert27 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Pause','Pause machen','1min Pause','" + path + "\\pirelli.png')";
                string insert28 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Pause','Pause machen','2min Pause','" + path + "\\pirelli.png')";
                string insert29 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Pause','Pause machen','5min Pause','" + path + "\\pirelli.png')";
                string insert30 = "insert into uebungen (kategorie, beschreibung, name, bild) values ('Pause','Pause machen','10min Pause','" + path + "\\pirelli.png')";

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
                command = new SQLiteCommand(insert24, trainingsDB);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(insert25, trainingsDB);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(insert26, trainingsDB);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(insert27, trainingsDB);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(insert28, trainingsDB);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(insert29, trainingsDB);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(insert30, trainingsDB);
                command.ExecuteNonQuery();
                trainingsDB.Close();
            }
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            FrmSuche frm = new FrmSuche();
            frm.Show();
        }

        private void organisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArbeitsplan frm = new FrmArbeitsplan();
            frm.Show();
        }

        private void kalenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTerminKalender frm = new FrmTerminKalender();
            frm.Show();
        }
    }
}
