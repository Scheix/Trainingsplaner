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
    public partial class FrmTrainingsDetails : Form
    {
        public FrmTrainingsDetails()
        {
            InitializeComponent();
        }
        public string TrainingsName { get; set; }

        private void FrmTrainingsDetails_Load(object sender, EventArgs e)
        {
            this.Text = TrainingsName;
        }
    }
}
