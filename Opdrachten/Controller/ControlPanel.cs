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
using Model;

namespace Controller
{
    public partial class ControlPanel : Form
    {
        ITreinDisplay treinDisplay;
        ITreinController TreinController;
        Station station;
        TreinReis treinReis = new TreinReis();

        public ControlPanel(ITreinController treinController)
        {
            InitializeComponent();
            station = treinReis.HuidigStation();
            this.TreinController = new TreinController(treinReis);
        }

        private void btnVolgendStation_Click(object sender, EventArgs e)
        {
            TreinController.VolgendeStation();
        }

        private void btnNewDisplay_Click(object sender, EventArgs e)
        {
            treinDisplay = new TreinDisplay(station.AankomstSpoort, station.Naam);
            treinDisplay.Show();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
