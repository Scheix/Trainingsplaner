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
    public partial class FrmBenutzerdefiniertDetails : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        Form uebersichtRef;
        public FrmBenutzerdefiniertDetails(Form uebersicht)
        {
            this.uebersichtRef = uebersicht;
            InitializeComponent();
            if (uebersichtRef.GetType() == typeof(FrmUebersicht))
            {
                ((FrmUebersicht)uebersichtRef).Open = false;
            }
        }
        public string UebungsName { get; set; }
        string bildPfad = "";
        private void FrmBenutzerdefiniertDetails_Load(object sender, EventArgs e)
        {
            string select = "select * from uebungen where name = '" + this.UebungsName + "'";
            string path = ConfigurationManager.AppSettings["BasePath"];
            string destination = path+"\\displayImage.jpg";
            trainingsDB.Open();
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblName.Text = "" + reader["name"];
                lblBeschreibung.Text = "" + reader["beschreibung"];
                File.Copy("" + reader["bild"], destination, true);
                //Display Image machen, Bild kopieren und im Ordner unter den Namen displayImage speichern, dieses Bild anzeigen und dann originales löschen
                //displayImage wird immer am anfang überschrieben, also mit dem Bild das ich anzeigen will --> wird nicht gelöscht!
                pictureBox1.Image = ResizeImage(450, Image.FromFile(destination));
                bildPfad = ""+reader["bild"];
            }
            trainingsDB.Close();
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten Sie diese Uebung wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = "delete from uebungen where name = '" + this.UebungsName + "'";
                trainingsDB.Open();
                SQLiteCommand command = new SQLiteCommand(delete, trainingsDB);
                command.ExecuteNonQuery();
                trainingsDB.Close();
                try
                {
                    System.IO.File.Delete(@""+bildPfad);
                }
                catch (System.IO.IOException exc)
                {
                    Console.WriteLine(exc.Message);
                    MessageBox.Show("Ein Fehler ist aufgetreten!\n"+exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (uebersichtRef.GetType() == typeof(FrmUebersicht))
                {
                    ((FrmUebersicht)uebersichtRef).ReloadList();
                }
                this.Close();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "In welches Verzeichnis soll das Bild exportiert werden?";
            string path = "";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string filename = System.IO.Path.GetFileName(bildPfad); 
                path = fbd.SelectedPath;
                string destination = Path.Combine(path, filename);
                File.Copy(bildPfad, destination,true);
                MessageBox.Show("Ihr Training wurde erfolgreich exportiert", "PDF-Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmBenutzerdefiniertDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (uebersichtRef.GetType() == typeof(FrmUebersicht))
            {
                ((FrmUebersicht)uebersichtRef).Open = true;
            }
        }
    }
}
