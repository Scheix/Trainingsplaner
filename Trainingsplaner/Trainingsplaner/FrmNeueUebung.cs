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
    public partial class FrmNeueUebung : Form
    {
        public FrmNeueUebung()
        {
            InitializeComponent();
        }

        private void FrmNeueUebung_Load(object sender, EventArgs e)
        {

        }

        private void btnHIIT_Click(object sender, EventArgs e)
        {
            FrmStandardUebungErstellen frm = new FrmStandardUebungErstellen();
            frm.Kategorie = "HIIT";
            frm.Show();
        }

        private void btnLaufen_Click(object sender, EventArgs e)
        {
            FrmStandardUebungErstellen frm = new FrmStandardUebungErstellen();
            frm.Kategorie = "Laufen";
            frm.Show();
        }

        private void btnTechnik_Click(object sender, EventArgs e)
        {
            FrmStandardUebungErstellen frm = new FrmStandardUebungErstellen();
            frm.Kategorie = "Technik";
            frm.Show();
        }

        private void btnBenutzerdefiniert_Click(object sender, EventArgs e)
        {
            FrmBenutzerdefinierteUebung frm = new FrmBenutzerdefinierteUebung();
            frm.Show();
        }
    }
}
