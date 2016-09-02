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
            //trainingsDB.Open();
            //this.lstDetails.ActionAfterExport = Spire.DataExport.Common.ActionType.None;
            //this.cellExport1.DataFormats.CultureName = "zh-CN";
            //this.cellExport1.DataFormats.Currency = "?#,###,##0.00";
            //this.cellExport1.DataFormats.DateTime = "yyyy-M-d H:mm";
            //this.cellExport1.DataFormats.Float = "#,###,##0.00";
            //this.cellExport1.DataFormats.Integer = "#,###,##0";
            //this.cellExport1.DataFormats.Time = "H:mm";
            //this.cellExport1.SheetOptions.AggregateFormat.Font.Name = "Arial";
            //this.cellExport1.SheetOptions.CustomDataFormat.Font.Name = "Arial";
            //this.cellExport1.SheetOptions.DefaultFont.Name = "Arial";
            //this.cellExport1.SheetOptions.FooterFormat.Font.Name = "Arial";
            //this.cellExport1.SheetOptions.HeaderFormat.Font.Name = "Arial";
            //this.cellExport1.SheetOptions.HyperlinkFormat.Font.Color = Spire.DataExport.XLS.CellColor.Blue;
            //this.cellExport1.SheetOptions.HyperlinkFormat.Font.Name = "Arial";
            //this.cellExport1.SheetOptions.HyperlinkFormat.Font.Underline = Spire.DataExport.XLS.XlsFontUnderline.Single;
            //this.cellExport1.SheetOptions.NoteFormat.Alignment.Horizontal = Spire.DataExport.XLS.HorizontalAlignment.Left;
            //this.cellExport1.SheetOptions.NoteFormat.Alignment.Vertical = Spire.DataExport.XLS.VerticalAlignment.Top;
            //this.cellExport1.SheetOptions.NoteFormat.Font.Bold = true;
            //this.cellExport1.SheetOptions.NoteFormat.Font.Name = "Tahoma";
            //this.cellExport1.SheetOptions.NoteFormat.Font.Size = 8F;
            //this.cellExport1.SheetOptions.TitlesFormat.Font.Bold = true;
            //this.cellExport1.SheetOptions.TitlesFormat.Font.Name = "Arial";
            //this.cellExport1.DataSource = DataExport.Common.ExportSource.ListView;
            //this.cellExport1.ListView = this.listView1;

            //Using(MemoryStream stream = new MemoryStream())
            //            {
            //    cellExport1.SaveToFile(stream);
            //    this.oleDbConnection1.Close();
            //    Workbook workbook = new Workbook(stream);
            //    PdfConverter pdfConverter = new PdfConverter(workbook);

            //    PdfDocument pdfDocument = new PdfDocument();
            //    pdfDocument.PageSettings.Orientation = pdf.PdfPageOrientation.Landscape;
            //    pdfDocument.PageSettings.Width = 970;
            //    pdfDocument.PageSettings.Height = 850;

            //    PdfConverterSettings settings = new PdfConverterSettings();
            //    settings.TemplateDocument = pdfDocument;
            //    pdfDocument = pdfConverter.Convert(settings);

            //    pdfDocument.SaveToFile("test.pdf");
            //}
            //string File = TrainingsName;
            //List<string> result = new List<string>();
            //for (int i = 0; i < lstDetails.Items.Count; i++)
            //{
            //    result.Add(lstDetails.Items[i].ToString());
            //}
            //ExportListToPDF(result, File);
        }
    }
}
