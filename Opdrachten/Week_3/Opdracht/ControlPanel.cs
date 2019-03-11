using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht
{
    public partial class ControlPanel : Form
    {
        private ITreinReis treinreis;
        private ITreinController controller;

        public ControlPanel()
        {
            InitializeComponent();
            treinreis = new TreinReis();
            controller = new TreinController(treinreis);
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            controller.VolgendeStation();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            controller.NieuweDisplay();
        }
    }
}
