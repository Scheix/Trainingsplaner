using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10,10,42,35);
            PdfWriter pri = PdfWriter.GetInstance(doc, new FileStream(TrainingsName+".pdf", FileMode.Create));
            doc.Open();
            //Training tr = new Training { Name="NewWOD", Uebungen = "Uebungen", Kategorie = "something", Unterkategorie = "anything"};
            Paragraph pr = new Paragraph("This is my first line using Paragraph. \n hello world");
            doc.Add(pr);
            //List list = new List(List.UNORDERED);
            //list.IndentationLeft = 30f;
            //list.Add(new ListItem("Title"));
            //for (int i = 0; i < lstDetails.Items.Count; i++)
            //{
            //    list.Add(lstDetails.Items[i].Text);
            //}
            //doc.Add(list);

            RomanList list = new RomanList(true, 20);
            list.IndentationLeft = 30f;
            for (int i = 0; i < lstDetails.Items.Count; i++)
            {
                list.Add(lstDetails.Items[i].Text);
            }
            List sublist = new List(List.UNORDERED, 40f);
            sublist.SetListSymbol("\u2022");
            list.IndentationLeft = 40f;
            sublist.Add("One");
            sublist.Add("Two");
            sublist.Add("Three");
            sublist.Add("Roman List");
            sublist.Add(list);
            doc.Add(sublist);
            doc.Close();
        }
    }
}
