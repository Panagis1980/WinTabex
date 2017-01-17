using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Diagnostics;

namespace WinTabex
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]



        static void Main(String[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new WinTabex());
            }
            else
            {
                OraConsole con = new OraConsole(args);
            }
        }
    }
}
