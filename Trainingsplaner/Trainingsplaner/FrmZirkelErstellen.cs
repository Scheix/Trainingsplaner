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
using Newtonsoft.Json;

namespace Trainingsplaner
{
    public partial class FrmZirkelErstellen : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        List<Zirkel> list = new List<Zirkel>();
        public FrmZirkelErstellen()
        {
            InitializeComponent();
        }
        private void FrmZirkelErstellen_Load(object sender, EventArgs e)
        {
            trainingsDB.Open();
            string select = "select distinct kategorie from uebungen";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbxKategorie.Items.Add(""+reader["kategorie"]);
            }
            string selectUebungen = "select name from uebungen where kategorie = '"+cbxKategorie.Text+"'";
            command = new SQLiteCommand(selectUebungen, trainingsDB);
            command.ExecuteNonQuery();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lstUebungen.Items.Add("" + reader["name"]);
            }
            trainingsDB.Close();
        }
        private void cbxKategorie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            trainingsDB.Open();
            lstUebungen.Items.Clear();
            string selectedItem = cbxKategorie.SelectedItem.ToString();
            string select = "select name from uebungen where kategorie = '" + selectedItem + "'";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lstUebungen.Items.Add("" + reader["name"]);
            }
            trainingsDB.Close();
        }
        private void lstZirkel_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void lstZirkel_DragDrop_1(object sender, DragEventArgs e)
        {
            string kategorie = "";
            trainingsDB.Open();
            string select = "select kategorie from uebungen where name = '"+ e.Data.GetData(DataFormats.Text).ToString()+"'";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                kategorie = ""+reader["kategorie"];
            }
            trainingsDB.Close();
            if (kategorie.Equals("HIIT"))
            {
                string value = "10";
                if (InputBox("Wiederholungen", "Wie viele Wiederholungen?",ref value) == DialogResult.OK)
                {
                    Zirkel z = new Zirkel { Wiederholungen = Convert.ToInt32(value), Uebungsname = e.Data.GetData(DataFormats.Text).ToString() };
                    list.Add(z);
                    string fullText = e.Data.GetData(DataFormats.Text).ToString() + " >> " + value + " Wiederholungen";
                    lstZirkel.Items.Add(fullText);
                }
            }
            else
            {
                Zirkel z = new Zirkel { Wiederholungen = 1, Uebungsname = e.Data.GetData(DataFormats.Text).ToString() };
                list.Add(z);
                lstZirkel.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
            }        
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
                    lstZirkel.DoDragDrop(item, DragDropEffects.Copy | DragDropEffects.Move);
                }
            }
        }

        private void btnFertig_Click(object sender, EventArgs e)
        {
            trainingsDB.Open();
            string name = txtName.Text;
            string listOfExercises = "";
            for (int i = 0; i < list.Count; i++)
            {
                listOfExercises = listOfExercises + list[i].Uebungsname+","+list[i].Wiederholungen+";";
            }
            string value = "5 Runden";
            if (InputBox("Art der Durchführung", "Soll der Zirkel in Runden oder in einer bestimmten Anzahl an Minuten absolviert werden? (Eingabebeispiel: 5 Runden oder 10 Minuten)", ref value) == DialogResult.OK)
            {
                if (value.EndsWith("Runden")|| value.EndsWith("Minuten"))
                {
                    string insert = "insert into zirkel (name ,uebungen, dauer) values ('" + name + "','" + listOfExercises + "','" + value + "')";
                    SQLiteCommand command = new SQLiteCommand(insert, trainingsDB);
                    command.ExecuteNonQuery();
                    trainingsDB.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fehlerhafte Eingabe, bitte versuchen Sie es erneut!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    trainingsDB.Close();
                }
            }
        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        private void lstZirkel_MouseClick(object sender, MouseEventArgs e)
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
                        lstZirkel.Items.RemoveAt(item);
                    }
                }
            }
        }
    }
}
