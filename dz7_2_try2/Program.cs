using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz7_2_try2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //Form form2 = mainmenu;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // form2.Show();
            Application.Run(new Form1());            
        }
    }
}
