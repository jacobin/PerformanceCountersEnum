//  ---------------------------------------------------------------------------
//  Author:     Marc Ochsenmeier
//  Email:      info@winssential.net
//  Web:        www.winssential.net
//  Project:    "Performance Counters Enumerator" for www.codeproject.com
//
//  Date        11.Feb.2010
//  ---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Performance_Counters_Enumerator
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
            Application.Run(new Form1());
        }
    }
}
