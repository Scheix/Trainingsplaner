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

namespace Trainingsplaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("Trainingsplaner.sqlite");
            SQLiteConnection trainingsDB;
            trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
            trainingsDB.Open();
            string create = "create table trainingsplaner (kategorie varchar(20), unterkategorie varchar(20), beschreibung varchar(200), name varchar(20), dauer int, bild blob)";
            SQLiteCommand command = new SQLiteCommand(create, trainingsDB);
            command.ExecuteNonQuery();
            string insert = "insert into trainingsplaner (kategorie, unterkategorie, beschreibung, name, dauer, bild) values ('Aufwaermen','Einlaufen','Verschiedene Übungen in den Ecken','Workout1',15, 'C:\\Users\\Michael\\Desktop\\Eigene Dateien\\Schule\\Diplomarbeit\\Trainingsplaner\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png')";
            command = new SQLiteCommand(insert, trainingsDB);
            command.ExecuteNonQuery();
            string select = "select kategorie, bild from trainingsplaner";
            command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.Text = "" + reader["kategorie"];
                byte[] result = (byte[])reader["bild"];
                //int arraySize = result.GetUpperBound(0);
                pictureBox1.Image = convertByteArrayToImage(result);
            }
        }
        private Image convertByteArrayToImage (byte[] bytes)
        {
            Image image = null;
            using (MemoryStream ms = new MemoryStream(bytes, true))
            {
                ms.Position = 0;
                ms.Write(bytes, 0, bytes.Length);
                image = Image.FromStream(ms);
            }
            return image;
        }
    }
}
