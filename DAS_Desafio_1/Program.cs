﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_Desafio_1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Splahs splahs = new Splahs();
            if (splahs.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Login());
            }
        }
    }
}
