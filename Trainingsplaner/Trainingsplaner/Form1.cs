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
            SQLiteConnection trainingsDB;
            trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
            trainingsDB.Open();
            string sql = "create table trainingsplaner (kategorie varchar(20), unterkategorie varchar(20), beschreibung varchar(200), name varchar(20), dauer int, bild blob)";
            SQLiteCommand command = new SQLiteCommand(sql, trainingsDB);
            //Start
        }
    }
}
