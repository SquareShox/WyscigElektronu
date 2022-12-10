using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projekt_Wyścigelektronu
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartClick(object sender, EventArgs e)
        {
            /* this.Close();
             th = new Thread(OPenForm);
             th.SetApartmentState(ApartmentState.STA);
             th.Start();
            */
            tabControl1.SelectTab(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            // Sprawdzenie, czy kursor myszy znajduje się nad linią
            if (IsCursorOverLine(e.Location))
            {
                // Przesunięcie obrazka na pozycję kursora myszy
                //PoleGry.Location = e.Location;
                gwiazdka.Location = e.Location;
            }
        }

        private bool IsCursorOverLine(Point cursorPosition)
        {
            // Obliczenie odległości pomiędzy kurserem myszy a linią
            // (w tym przykładzie zakładamy, że linia jest prosta i ma współrzędne (10, 10) - (100, 100))
            var distance = Math.Abs((cursorPosition.Y - 10) * (100 - 10) - (cursorPosition.X - 10) * (100 - 10)) /
                           Math.Sqrt(Math.Pow(100 - 10, 2) + Math.Pow(100 - 10, 2));

            // Sprawdzenie, czy odległość jest mniejsza od progu (np. 2 pikseli)
            return distance <= 10;
        }
        /*
private void OPenForm(object obj)
{
   Application.Run(new Form2());
}
*/
    }

   
}
