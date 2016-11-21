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
    public partial class FrmUebungsDetails : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        Form uebersichtRef;
        public FrmUebungsDetails(Form uebersicht)
        {
            this.uebersichtRef = uebersicht;
            InitializeComponent();
            if (uebersichtRef.GetType() == typeof(FrmUebersicht))
            {
                ((FrmUebersicht)uebersichtRef).Open = false;
            }
        }
        public string UebungsName { get; set; }
        private void FrmUebungsDetails_Load(object sender, EventArgs e)
        {
            string select = "select * from uebungen where name = '" + this.UebungsName + "'";
            trainingsDB.Open();
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblTitel.Text = ""+reader["name"];
                lblBeschreibung.Text = "" + reader["beschreibung"];
                pctBoxUebung.Image = Image.FromFile("" + reader["bild"]);
            }
            trainingsDB.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten Sie diese Uebung wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = "delete from uebungen where name = '" + this.UebungsName + "'";
                trainingsDB.Open();
                SQLiteCommand command = new SQLiteCommand(delete, trainingsDB);
                command.ExecuteNonQuery();
                trainingsDB.Close();
                if(uebersichtRef.GetType() == typeof(FrmUebersicht))
                {
                    ((FrmUebersicht)uebersichtRef).ReloadList();
                }
                this.Close();
            }
        }

        private void FrmUebungsDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (uebersichtRef.GetType() == typeof(FrmUebersicht))
            {
                ((FrmUebersicht)uebersichtRef).Open = true;
            }
        }
    }
}
