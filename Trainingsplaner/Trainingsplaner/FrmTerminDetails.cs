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
    public partial class FrmTerminDetails : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        Form kalenderRef;
        public FrmTerminDetails(Form kalender)
        {
            this.kalenderRef = kalender;
            InitializeComponent();
        }
        public List<string> Dates { get; set; }
        private void FrmTerminDetails_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.AcceptButton = btnOk;
            trainingsDB.Open();
            for (int i = 0; i < Dates.Count; i++)
            {
                listBox1.Items.Add("Termine am "+Dates[i]+":");
                string select = "select name from termine where date = '" + Dates[i] + "'";
                SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
                command.ExecuteNonQuery();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(""+reader["name"]);
                }
                listBox1.Items.Add("");
            }
            trainingsDB.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainingsDB.Open();
            if (listBox1.SelectedItem != null)
            {
                string s = listBox1.SelectedItem.ToString();
                string select = "select date from termine where name = '" + s + "'";
                SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
                command.ExecuteNonQuery();
                SQLiteDataReader reader = command.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    counter++;
                }
                if (counter != 0)
                {
                    if (MessageBox.Show("Möchten Sie diesen Termin löschen?", "Löschen",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
             == DialogResult.Yes)
                    {
                        string deleteDate = "";
                        List<string> listOfDates = new List<string>();
                        string item = listBox1.SelectedItem.ToString();
                        string select2 = "select date from termine where name = '" + item + "'";
                        command = new SQLiteCommand(select2, trainingsDB);
                        command.ExecuteNonQuery();
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            listOfDates.Add("" + reader["date"]);
                        }
                        for (int i = 0; i < listOfDates.Count; i++)
                        {
                            for (int j = 0; j < Dates.Count; j++)
                            {
                                if (listOfDates[i].Equals(Dates[j]))
                                {
                                    deleteDate = Dates[j];
                                }
                            }
                        }
                        string delete = "delete from termine where name = '" + item + "' and date = '" + deleteDate + "'";
                        command = new SQLiteCommand(delete, trainingsDB);
                        command.ExecuteNonQuery();
                        trainingsDB.Close();
                        if (kalenderRef.GetType() == typeof(FrmTerminKalender))
                        {
                            ((FrmTerminKalender)kalenderRef).LoadCalender();
                        }
                        this.Close();
                    }
                }
            }
            trainingsDB.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
