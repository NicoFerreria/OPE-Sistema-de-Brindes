using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //License Syncfusion
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTM3ODM5QDMxMzYyZTM0MmUzMFZhWmpRY2dVdzJJdEMxUjlRb2tQSTNBekRBbE1zTElORkZOVlh2SWRwSXc9");
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lounch());
        }
    }
}
