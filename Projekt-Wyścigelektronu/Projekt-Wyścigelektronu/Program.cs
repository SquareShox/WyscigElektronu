using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Wyścigelektronu
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            // Application.Run(new Form2());

        }
    }

    class Menu
    {


    }

    class Poziom
    {
        public Poziom()
        {
            int zycia = 3;
        }

        public void RozpoczecieGry()
        {


        }

    }

    class Rezystor
    {
        

    }
}
