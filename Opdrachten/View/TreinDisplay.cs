using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class TreinDisplay : Form, ITreinDisplay
    {
        private string Spoor;
        private string Station;

        public TreinDisplay(string spoor, string station)
        {
            InitializeComponent();
            this.Spoor = spoor;
            this.Station = station;
        }

        private void TreinDisplay_Load(object sender, EventArgs e)
        {

        }
        public void ReisInfoDisplay()
        {
            lblSpoor.Text = Spoor;
            lblSpoor.Text = Station;
        }
        public void Update()
        {
            lblSpoor.Text = Spoor;
            lblSpoor.Text = Station;
        }
    }
}
