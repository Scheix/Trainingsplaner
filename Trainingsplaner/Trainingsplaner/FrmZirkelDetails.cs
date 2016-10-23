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
    public partial class FrmZirkelDetails : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        public string ZirkelName { get; set; }
        Form uebersichtRef;
        public FrmZirkelDetails(Form uebersicht)
        {
            this.uebersichtRef = uebersicht;
            InitializeComponent();
        }

        private void FrmZirkelDetails_Load(object sender, EventArgs e)
        {
            string select = "select * from zirkel where name = '" + this.ZirkelName + "'";
            trainingsDB.Open();
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string durchfuehrung = "" + reader["dauer"];
                if (durchfuehrung.Contains("Runden"))
                {
                    label1.Text = "Folgende Übungen müssen so schnell wie möglich \nin " + durchfuehrung + " durchgeführt werden:";
                }
                else
                {
                    label1.Text = "Folgende Übungen müssen so schnell und oft wie möglich \ninnerhalb von " + durchfuehrung + " durchgeführt werden:";
                }
                
                string bearb = "" + reader["uebungen"];
                string[] uebungen = bearb.Split(';');
                for (int i = 0; i < uebungen.Length-1; i++)
                {
                    string[] item = uebungen[i].Split(',');
                    string name = item[0];
                    string wdh = item[1];
                    string ub = "select name from uebungen where kategorie = 'HIIT'";
                    SQLiteCommand com = new SQLiteCommand(ub, trainingsDB);
                    SQLiteDataReader r = com.ExecuteReader();
                    int counter = 0;
                    while (r.Read())
                    {
                        if (r["name"].ToString().Equals(name))
                        {
                            counter++;
                            lstDetails.Items.Add(name + " >> " + wdh + " Wiederholungen");
                        }
                    }
                    if (counter == 0)
                    {
                        lstDetails.Items.Add(name);
                    }
                }
            }
            trainingsDB.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten Sie den Zirkel wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = "delete from zirkel where name = '" + this.ZirkelName + "'";
                trainingsDB.Open();
                SQLiteCommand command = new SQLiteCommand(delete, trainingsDB);
                command.ExecuteNonQuery();
                trainingsDB.Close();
                if (uebersichtRef.GetType() == typeof(FrmUebersicht))
                {
                    ((FrmUebersicht)uebersichtRef).ReloadList();
                }
                this.Close();
            }
        }
    }
}
