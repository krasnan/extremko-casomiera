using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using perfectTiming.View;
using perfectTiming.Controller;
namespace perfectTiming
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("sk-SK");
            Application.CurrentCulture = cultureInfo;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new AppController();
            Application.Run(new MainView());
            
        }
    }
}
