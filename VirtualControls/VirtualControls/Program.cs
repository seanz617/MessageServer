using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VirtualControls
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //调整后
            Application.Run(new FrmMain());
            //调整前
            Application.Run(new FrmCompare());
        }
    }
}
