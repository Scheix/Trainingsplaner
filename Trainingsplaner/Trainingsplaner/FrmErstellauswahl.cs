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
        public FrmErstellauswahl()
        {
            InitializeComponent();
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
    }
}
