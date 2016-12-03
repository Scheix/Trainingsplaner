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
    public partial class FrmTrainingErstellen : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        public FrmTrainingErstellen()
        {
            InitializeComponent();
        }

        private void cbxKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainingsDB.Open();
            lstUebungen.Items.Clear();
            string selectedItem = cbxKategorie.SelectedItem.ToString();
            string select = "";
            if (selectedItem == "Zirkel")
            {
                select = "select name from zirkel";
            }
            else
            {
                select = "select name from uebungen where kategorie = '" + selectedItem + "'";
            }
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lstUebungen.Items.Add("" + reader["name"]);
            }
            trainingsDB.Close();
        }

        private void FrmTrainingErstellen_Load(object sender, EventArgs e)
        {
            trainingsDB.Open();
            cboxEinteilung.Items.Add("Aufwaermen");
            cboxEinteilung.Items.Add("Technik");
            cboxEinteilung.Items.Add("Ausdauer");
            cboxEinteilung.Items.Add("Kraft");
            cboxEinteilung.Items.Add("Locker");
            cboxEinteilung.SelectedItem = cboxEinteilung.Items[1];
            string select = "select distinct kategorie from uebungen";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbxKategorie.Items.Add("" + reader["kategorie"]);
            }
            cbxKategorie.Items.Add("Zirkel");
            string selectUebungen = "select name from uebungen where kategorie = '" + cbxKategorie.Text + "'";
            command = new SQLiteCommand(selectUebungen, trainingsDB);
            command.ExecuteNonQuery();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lstUebungen.Items.Add("" + reader["name"]);
            }
            trainingsDB.Close();
        }

        private void lstTraining_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lstTraining_DragDrop(object sender, DragEventArgs e)
        {
            lstTraining.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
        }

        private void lstUebungen_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo htInfo = lstUebungen.HitTest(e.X, e.Y);
            if (htInfo != null)
            {
                if (htInfo.Item != null)
                {
                    ListViewItem lvi = htInfo.Item;
                    string item = lvi.Text;
                    lstTraining.DoDragDrop(item, DragDropEffects.Copy | DragDropEffects.Move);
                }
            }
        }

        private void btnFertig_Click(object sender, EventArgs e)
        {
            trainingsDB.Open();
            string select = "select name from trainings";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Bitte geben Sie einen Namen für das Training ein!", "Warnung",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                    trainingsDB.Close();
                    return;
                }
                if (reader["name"].ToString().Equals(txtName.Text))
                {
                    MessageBox.Show("Dieser Name existieirt bereits, bitte geben Sie einen neuen Namen ein", "Warnung",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                    trainingsDB.Close();
                    return;
                }
            }
            string kategorie = cboxEinteilung.SelectedItem.ToString();
            string name = txtName.Text;
            string trainingsliste = "";
            for (int i = 0; i < lstTraining.Items.Count; i++)
            {
                trainingsliste = trainingsliste + lstTraining.Items[i].Text + ";";
            }
            string insert = "insert into trainings (name,uebungen,kategorie) values ('" + name + "','" + trainingsliste + "','" + kategorie + "')";
            command = new SQLiteCommand(insert, trainingsDB);
            //trainingsDB.Close();
            //trainingsDB.Open();
            //using (trainingsDB)
            //{
            //    trainingsDB.Open();
            //    using (SQLiteCommand cmd = new SQLiteCommand(insert, trainingsDB))
            //    {
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            command.ExecuteNonQuery();
            trainingsDB.Close();
            this.Close();     
        }

        private void lstTraining_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Möchten Sie den Eintrag löschen?", "Löschen",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
         == DialogResult.Yes)
            {
                ListViewHitTestInfo htInfo = lstUebungen.HitTest(e.X, e.Y);
                if (htInfo != null)
                {
                    if (htInfo.Item != null)
                    {
                        ListViewItem lvi = htInfo.Item;
                        int item = lvi.Index;
                        lstTraining.Items.RemoveAt(item);
                    }
                }
            }
        }
    }
}
