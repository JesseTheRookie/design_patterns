using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using Model;

namespace Controller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ITreinReis reis = new TreinReis();
            ITreinController treinController = new TreinController(reis);
            Application.Run(new ControlPanel(treinController));
        }
    }
}
