using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace Trainingsplaner
{
    public partial class FrmTrainingsDetails : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        public FrmTrainingsDetails()
        {
            InitializeComponent();
        }
        public string TrainingsName { get; set; }

        private void FrmTrainingsDetails_Load(object sender, EventArgs e)
        {
            this.Text = TrainingsName;
            string select = "select * from trainings where name = '" + this.TrainingsName + "'";
            trainingsDB.Open();
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string bearb = "" + reader["uebungen"];
                string[] uebungen = bearb.Split(';');
                for (int i = 0; i < uebungen.Length - 1; i++)
                {
                    lstDetails.Items.Add(uebungen[i]);
                }
            }
            trainingsDB.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "In welches Verzeichnis soll das PDF exportiert werden?";
            string path = "";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
                trainingsDB.Open();
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter pri = PdfWriter.GetInstance(doc, new FileStream(path + "/" + TrainingsName + ".pdf", FileMode.Create));
                doc.Open();

                Font titlefont = FontFactory.GetFont("Arial");
                titlefont.Size = 30;
                titlefont.SetStyle("Bold");
                titlefont.SetColor(0, 0, 128);

                Paragraph pr = new Paragraph("Training: " + this.TrainingsName, titlefont);
                doc.Add(pr);

                List list = new List(List.UNORDERED, 20f);
                list.IndentationLeft = 10f;
                list.SetListSymbol("\u2022");
                List zirkelItems = new List(List.UNORDERED, 20f);
                zirkelItems.IndentationLeft = 20f;
                zirkelItems.SetListSymbol("\u2022");
                List<string> zirkelnamen = new List<string>();

                string select = "select name from zirkel";
                SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    zirkelnamen.Add("" + reader["name"]);
                }

                int counter = 0;
                for (int i = 0; i < lstDetails.Items.Count; i++)
                {
                    for (int j = 0; j < zirkelnamen.Count; j++)
                    {
                        if (lstDetails.Items[i].Text.Equals(zirkelnamen[j]))
                        {
                            counter++;
                            list.Add(lstDetails.Items[i].Text);
                            string zirkel = "select * from zirkel where name = '" + lstDetails.Items[i].Text + "'";
                            command = new SQLiteCommand(zirkel, trainingsDB);
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                string durchfuehrung = "" + reader["dauer"];
                                if (durchfuehrung.Contains("Runden"))
                                {
                                    zirkelItems.Add("Folgende Übungen müssen so schnell wie möglich in " + durchfuehrung + " durchgeführt werden:");
                                }
                                else
                                {
                                    zirkelItems.Add("Folgende Übungen müssen so schnell und oft wie möglich innerhalb von " + durchfuehrung + " durchgeführt werden:");
                                }

                                string bearb = "" + reader["uebungen"];
                                string[] uebungen = bearb.Split(';');
                                for (int x = 0; x < uebungen.Length - 1; x++)
                                {
                                    string[] item = uebungen[x].Split(',');
                                    string name = item[0];
                                    string wdh = item[1];
                                    string ub = "select name from uebungen where kategorie = 'HIIT'";
                                    SQLiteCommand com = new SQLiteCommand(ub, trainingsDB);
                                    SQLiteDataReader r = com.ExecuteReader();
                                    int count = 0;
                                    while (r.Read())
                                    {
                                        if (r["name"].ToString().Equals(name))
                                        {
                                            count++;
                                            zirkelItems.Add(name + " >> " + wdh + " Wiederholungen");
                                        }
                                    }
                                    if (count == 0)
                                    {
                                        zirkelItems.Add(name);
                                    }
                                }
                            }
                            list.Add(zirkelItems);
                        }
                    }
                    if (counter == 0)
                    {
                        list.Add(lstDetails.Items[i].Text);
                    }
                    counter = 0;
                }
                doc.Add(list);
                trainingsDB.Close();
                doc.Close();
                MessageBox.Show("Ihr Training wurde erfolgreich exportiert", "PDF-Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten Sie das Training wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = "delete from trainings where name = '" + this.TrainingsName + "'";
                trainingsDB.Open();
                SQLiteCommand command = new SQLiteCommand(delete, trainingsDB);
                command.ExecuteNonQuery();
                trainingsDB.Close();
                this.Close();
            }
        }
    }
}
