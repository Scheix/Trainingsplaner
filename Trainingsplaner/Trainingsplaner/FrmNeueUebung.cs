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
        public bool Open { get; set; }
        Form menuRef;
        public FrmNeueUebung(Form menu)
        {
            InitializeComponent();
            Open = true;
            this.menuRef = menu;
            if (menuRef.GetType() == typeof(Form1))
            {
                ((Form1)menuRef).OpenNeueUebung = false;
            }
        }

        private void FrmNeueUebung_Load(object sender, EventArgs e)
        {

        }

        private void btnHIIT_Click(object sender, EventArgs e)
        {
            if (Open == true)
            {
                FrmStandardUebungErstellen frm = new FrmStandardUebungErstellen(this);
                frm.Kategorie = "HIIT";
                frm.Show();
            }
        }

        private void btnLaufen_Click(object sender, EventArgs e)
        {
            if (Open == true)
            {
                FrmStandardUebungErstellen frm = new FrmStandardUebungErstellen(this);
                frm.Kategorie = "Laufen";
                frm.Show();
            } 
        }

        private void btnTechnik_Click(object sender, EventArgs e)
        {
            if (Open == true)
            {
                FrmStandardUebungErstellen frm = new FrmStandardUebungErstellen(this);
                frm.Kategorie = "Technik";
                frm.Show();
            }
        }

        private void btnBenutzerdefiniert_Click(object sender, EventArgs e)
        {
            if (Open == true)
            {
                FrmBenutzerdefinierteUebung frm = new FrmBenutzerdefinierteUebung(this);
                frm.Show();
            }     
        }

        private void FrmNeueUebung_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuRef.GetType() == typeof(Form1))
            {
                ((Form1)menuRef).OpenNeueUebung = true;
            }
        }
    }
}
