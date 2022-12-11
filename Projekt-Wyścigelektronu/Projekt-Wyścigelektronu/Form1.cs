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

        Rezystor R1 = new Rezystor();
        Rezystor R2 = new Rezystor();
        Rezystor R3 = new Rezystor();
        Menu Menuglowna = new Menu();

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
            
            if (IsPictureBoxInsideFrame(this.electron, this.rezystor1)){


            }

            

        }

        private void movePictureBoxWithMouse(object sender, MouseEventArgs e)
        {
            //wykrycie ruchu myszkipo polu gry
            movePictureafterClickandMove(electron, e);
        }

        public void movePictureafterClickandMove(PictureBox pictureBox, MouseEventArgs e)
        {
            // jeśli lewy przycisk myszy jest wciśnięty
            if (e.Button == MouseButtons.Left)
            {
                // oblicz nowe położenie PictureBox na podstawie położenia myszy
                int newX = pictureBox.Location.X + (e.X - pictureBox.Location.X);
                int newY = pictureBox.Location.Y + (e.Y - pictureBox.Location.Y);

                // ustaw nowe położenie PictureBox
                pictureBox.Location = new Point(newX, newY);
            }
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private bool IsPictureBoxInsideFrame(PictureBox pictureBox, PictureBox frame)
        {
            Rectangle pictureBoxRect = new Rectangle(pictureBox.Location, pictureBox.Size);
            Rectangle frameRect = new Rectangle(frame.Location, frame.Size);

            return frameRect.Contains(pictureBoxRect);
        }

       
    }
}


        /*
private void OPenForm(object obj)
{
Application.Run(new Form2());
}
*/
