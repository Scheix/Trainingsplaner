using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainingsplaner
{
    public partial class FrmErstellauswahl : Form
    {
        Form menuRef;
        public FrmErstellauswahl(Form menu)
        {
            InitializeComponent();
            this.menuRef = menu;
            if (menuRef.GetType() == typeof(Form1))
            {
                ((Form1)menuRef).OpenTrainingErstellen = false;
            }
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            FrmTrainingErstellen frm = new FrmTrainingErstellen();
            frm.Show();
            this.Close();
        }

        private void btnZirkel_Click(object sender, EventArgs e)
        {
            FrmZirkelErstellen frm = new FrmZirkelErstellen();
            frm.Show();
            this.Close();
        }

        private void FrmErstellauswahl_Load(object sender, EventArgs e)
        {

        }

        private void FrmErstellauswahl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuRef.GetType() == typeof(Form1))
            {
                ((Form1)menuRef).OpenTrainingErstellen = true;
            }
        }
    }
}
