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
            // Tabelle Trainings braucht bei der Erstellung noch ein Kategorie-Feld zur einteilung, soll vom Benutzer zum Schluss eingeteilt werden
            SQLiteConnection.CreateFile("Trainingsplaner.sqlite");
            trainingsDB.Open();
            string create = "create table trainings (name varchar(20), uebungen varchar(1000))";
            string create2 = "create table uebungen (kategorie varchar(20), unterkategorie varchar(20), beschreibung varchar(200), name varchar(20), bild varchar(100))";
            string create3 = "create table zirkel (name varchar(20), uebungen varchar(1000), dauer varchar(20))";
            SQLiteCommand command = new SQLiteCommand(create, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(create2, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(create3, trainingsDB);
            command.ExecuteNonQuery();
            //string insert = "insert into trainings (kategorie, unterkategorie, beschreibung, name, dauer, bild) values ('Aufwaermen','Einlaufen','Verschiedene Übungen in den Ecken','Workout1',15, 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
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
            string insert24 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','Pause','Pause machen','10s Pause', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert25 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','Pause','Pause machen','20s Pause', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert26 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','Pause','Pause machen','30s Pause', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert27 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','Pause','Pause machen','1min Pause', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert28 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','Pause','Pause machen','2min Pause', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert29 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','Pause','Pause machen','5min Pause', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert30 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Zirkel','Pause','Pause machen','10min Pause', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert31 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Abkühlen','Dehnen','Nimm eine Squat-aehnliche Position ein und senke deine Hüften so tief wie möglich ab, während du deinen Rücken gerade hälst. Greife deine Zehen und ziehe an ihnen. Deine Zehen sollten so gerade wie möglich nach vorne zeigen. Drücke ein Knie vorsichtig nach außen, bis du einen Stretch in der Innenseite deiner Oberschenkel verspürst.','Dehnübung 1', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert32 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Abkühlen','Dehnen','Kommt später','Dehnübung 2', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert33 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Abkühlen','Dehnen','Kommt später','Dehnübung 3', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert34 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Abkühlen','Dehnen','Kommt später','Dehnübung 4', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert35 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Abkühlen','Dehnen','Kommt später','Dehnübung 5', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert36 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Abkühlen','Dehnen','Kommt später','Dehnübung 6', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert37 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Abkühlen','Dehnen','Kommt später','Dehnübung 7', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert38 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Abkühlen','Dehnen','Kommt später','Dehnübung 8', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            string insert39 = "insert into uebungen (kategorie, unterkategorie, beschreibung, name, bild) values ('Abkühlen','Dehnen','Kommt später','Dehnübung 9', 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";

            //command = new SQLiteCommand(insert, trainingsDB);
            //command.ExecuteNonQuery();
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
            command = new SQLiteCommand(insert31, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert32, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert33, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert34, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert35, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert36, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert37, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert38, trainingsDB);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(insert39, trainingsDB);
            command.ExecuteNonQuery(); 
            trainingsDB.Close();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            FrmSuche frm = new FrmSuche();
            frm.Show();
        }
    }
}
