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
    public partial class ReisInfoDisplay : Form, ITreinDisplay
    {
        private ITreinReis reis;
        private ITreinController controller;

        public ReisInfoDisplay(ITreinReis reis, ITreinController controller)
        {
            InitializeComponent();
            this.reis = reis;
            this.controller = controller;
            this.reis.AddObserver(this);
        }

        public void Update(Station huidigStation)
        {
            lblStation.Text = huidigStation.Naam;
            lblSpoor.Text = huidigStation.AankomstSpoor;
        }

    }
}
