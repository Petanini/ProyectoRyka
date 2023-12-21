using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRyka
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenuAdmin());
            //Application.Run(new FrmOrderChoices());
            //Application.Run(new FrmPrincipal());
            //Application.Run(new PatientOnboarding());
            //Application.Run(new FrmOrderHistory());
            //Application.Run(new FrmFacility());
            //Application.Run(new FrmExamen());
            //Application.Run(new FrmUsers());
        }
    }
}
