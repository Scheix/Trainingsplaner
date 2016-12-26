using Configuration;
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
    public partial class FrmStandardUebungErstellen : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        string destination = "";
        public string Kategorie { get; set; }
        Form neueUebungRef;
        public FrmStandardUebungErstellen(Form neueUebung)
        {
            InitializeComponent();
            this.neueUebungRef = neueUebung;
            if (neueUebungRef.GetType() == typeof(FrmNeueUebung))
            {
                ((FrmNeueUebung)neueUebungRef).Open = false;
            }
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
            if (destination!="")
            {
                string insert = "insert into uebungen (kategorie, beschreibung, name, bild) values ('" + Kategorie + "','" + beschreibung + "','" + name + "','" + destination + "')";
                SQLiteCommand command = new SQLiteCommand(insert, trainingsDB);
                command.ExecuteNonQuery();
                trainingsDB.Close();
                if (MessageBox.Show("Uebung wurde erfolgreich in die Datenbank gespeichert", "Einfuegen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                string path = ConfigurationManager.AppSettings["BasePath"];
                string insert = "insert into uebungen (kategorie, beschreibung, name, bild) values ('" + Kategorie + "','" + beschreibung + "','" + name + "','" + path+ "\\Uebungen\\training.png')";
                SQLiteCommand command = new SQLiteCommand(insert, trainingsDB);
                command.ExecuteNonQuery();
                trainingsDB.Close();
                if (MessageBox.Show("Uebung wurde erfolgreich in die Datenbank gespeichert", "Einfuegen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btnBild_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["BasePath"];
            if (!System.IO.Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string source = fd.FileName;
                string filename = System.IO.Path.GetFileName(source);
                destination = path + "\\Uebungen\\" + filename;
                //System.IO.File.Copy(source, destination, true);
                //pictureBox1.Image = Image.FromFile(destination);
                //pictureBox1.Image = ResizeImage(250,Image.FromFile(destination));
                ResizeImage(250, Image.FromFile(source)).Save(destination);
                pictureBox1.Image = Image.FromFile(destination);
            }            
        }
        private static Image ResizeImage(int newSize, Image originalImage)
        {
            if (originalImage.Width <= newSize)
                newSize = originalImage.Width;

            var newHeight = originalImage.Height * newSize / originalImage.Width;

            if (newHeight > newSize)
            {
                // Resize with height instead
                newSize = originalImage.Width * newSize / originalImage.Height;
                newHeight = newSize;
            }

            return originalImage.GetThumbnailImage(newSize, newHeight, null, IntPtr.Zero);
            //http://stackoverflow.com/questions/1922040/resize-an-image-c-sharp
        }

        private void FrmStandardUebungErstellen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (neueUebungRef.GetType() == typeof(FrmNeueUebung))
            {
                ((FrmNeueUebung)neueUebungRef).Open = true;
            }
        }
    }
}
