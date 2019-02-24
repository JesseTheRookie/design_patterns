using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Controller
{
    public partial class Controller : Form
    {
        TreinController TreinController = new TreinController();
        public Controller()
        {
            InitializeComponent();
        }

        private void btnVolgendStation_Click(object sender, EventArgs e)
        {
            TreinController.VolgendeStation();
        }

        private void btnNewDisplay_Click(object sender, EventArgs e)
        {
            TreinDisplay treinDisplay = new TreinDisplay();
            treinDisplay.Show();
        }
    }
}
