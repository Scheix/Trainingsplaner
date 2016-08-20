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
            SQLiteConnection dbConnection;
            dbConnection =
            new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            dbConnection.Open();

            string sql_tableCreate = "CREATE TABLE trainingsplaner (kategorie VARCHAR(20), unterkategorie VARCHAR(20), beschreibung VARCHAR(120), kurzbeschreibung VARCHAR(50), dauer INT, bild BLOB)";
            SQLiteCommand command = new SQLiteCommand(sql_tableCreate, dbConnection);
            command.ExecuteNonQuery();

            string sql_values = "insert into trainingsplaner (kategorie, unterkategorie, beschreibung, kurzbeschreibung, dauer, bild) values ('Aufwaermen', 'Einlaufen', 'verschiedene Übungen in den Ecken', null, 15, C:\\Users\\Simon\\Desktop\\Schule\\Diplomarbeit\\Projekt\\Trainingsplaner\\Trainingsplaner\\Pictures\\pirelli.png)";
            SQLiteCommand command1 = new SQLiteCommand(sql_values, dbConnection);
            command1.ExecuteNonQuery();
        }
    }
}
