using Configuration;
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
    public partial class FrmStandardUebungErstellen : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        string destination = "";
        public string Kategorie { get; set; }
        public FrmStandardUebungErstellen()
        {
            InitializeComponent();
        }

        private void FrmStandardUebungErstellen_Load(object sender, EventArgs e)
        {
            destination = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string beschreibung = rboxBeschreibung.Text;
            trainingsDB.Open();
            string insert = "insert into uebungen (kategorie, beschreibung, name, bild) values ('"+Kategorie+ "','" + beschreibung + "','" + name + "','" + destination + "')";
            SQLiteCommand command = new SQLiteCommand(insert, trainingsDB);
            command.ExecuteNonQuery();
            trainingsDB.Close();
            if (MessageBox.Show("Uebung wurde erfolgreich in die Datenbank gespeichert", "Einfuegen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            } 
        }

        private void btnBild_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["BasePath"];
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            OpenFileDialog fd = new OpenFileDialog();
            //fd.Filter = "Images only. |*.jpg, *.jpeg, *.png, *.gif;";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string source = fd.FileName;
                string filename = System.IO.Path.GetFileName(source);
                //destination = "C:\\Trainingsplaner\\Fotos\\"+filename;
                destination = path + "\\" + filename;
                System.IO.File.Copy(source, destination, true);
                pictureBox1.Image = Image.FromFile(destination);
            }            
        }
    }
}
