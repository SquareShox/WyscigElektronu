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
using System.Media;

namespace Projekt_Wyścigelektronu
{
    public partial class Form1 : Form /// Głowny Form
    {

        Rezystor R1 = new Rezystor(100,200,4000,false); /// <summary>
        /// inicjalizacja R1
        /// </summary>
        Rezystor R2 = new Rezystor(120, 2230, 1000, true); /// <summary>
        /// inicjalizacja R2
        /// </summary>
        Rezystor R3 = new Rezystor(100, 230, 2000, false); /// <summary>
        /// inicjalizacja R3
        /// </summary>
        Rezystor R4 = new Rezystor(120, 230, 2000, true); /// <summary>
        /// inicjalizacja R4
        /// </summary>
        Zrodlo U1 = new Zrodlo(50,100,10,true);  /// <summary>
        /// inicjalizacja U1
        /// </summary>
        Kondensator C1 = new Kondensator(400,400,50,true); /// <summary>
        /// inicjalizacja C1
        /// </summary>
        Menu Menuglowna = new Menu(); /// <summary>
        /// incjalizacje menu
        /// </summary>

        StatusPoziomu P1 = new StatusPoziomu();
       
        private int countdownTime = 300;
        private int trudnosc=1;
        private System.Windows.Forms.Timer timer1;
        SoundPlayer player = new SoundPlayer(@"C:\Users\User\source\repos\Projekt-Wyścigelektronu\Projekt-Wyścigelektronu\Resources\556717__nachtmahrtv__electricity-sound.wav");

        /// <summary>
        /// Ładowanie pliku audio i ustawianie timera
        /// </summary>
        




        public Form1() /// konstruktor from1
        {
            InitializeComponent();
            
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // Co 1 sekundę
            timer1.Tick += new EventHandler(zliaczanie);
           

        }
        
        
        
        
       
        private void StartClick(object sender, EventArgs e)///start Gry 


        {
            /* this.Close();
             th = new Thread(OPenForm);
             th.SetApartmentState(ApartmentState.STA);
             th.Start();
            */
            tabControl1.SelectTab(1);
            Menuglowna.RozpocznijGre();
            P1.RozpoczecieGry();
            this.ProbyNapis.Text = "Pozostało prób:" + P1.Getproby().ToString();
            countdownTime = Menuglowna.UstawOpcje(trudnosc);
            wyzerujCzas();

            R1.Location = rezystor1.Location;
            R2.Location = rezystor2.Location;
            R3.Location = rezystor3.Location;

            
        }

        

      


        private bool isDragging = false; /// <summary>
        /// zmienna służaca do kontroli elektronu myszką
        /// </summary>
        ///
        private Point lastMousePosition;/// <summary>
        /// wykrycie poruszania mysza
        /// </summary>
        /// <param name="sender">obiekt picture box który zgłosił nacisniecie myszka</param>
        /// <param name="e">obiekt myszy</param>

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) 
        {
            // Ustaw flagę, że PictureBox jest aktualnie przenoszony
            isDragging = true;

            // Zapisz pozycję myszy
            lastMousePosition = e.Location;
        }
        /// <summary>
        /// operacje podczas ruszania elektronem sprawdzanie w jakim poziomie itp
        /// </summary>
        /// <param name="sender">obiekt picture box który zgłosił nacisniecie myszka</param>
        /// <param name="e">obiekt myszy</param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) 
        {
            PictureBox pictureBox = sender as PictureBox;
            if (isDragging)
            {
                // Oblicz różnicę między pozycją myszy a pozycją PictureBox
                int deltaX = e.X - lastMousePosition.X+5;
                int deltaY = e.Y - lastMousePosition.Y+5;

                // Przesuń PictureBox o różnicę
                pictureBox.Location = new Point(pictureBox.Location.X + deltaX, pictureBox.Location.Y + deltaY);
              
            }
            // sprawdz czy jest w obiekcie
            Point mousePosition = pictureBox.PointToClient(Control.MousePosition);
            if (Menuglowna.ktoryPoziom == 1)
            {
                SprawdzCzyblednyPoziom1(pictureBox, e, mousePosition);
              
            }
            else if(Menuglowna.ktoryPoziom == 2)
            {
                SprawdzCzyblednyPoziom2(pictureBox, e, mousePosition);
            }
            else if(Menuglowna.ktoryPoziom == 3)
            {
                SprawdzCzyblednyPoziom3(pictureBox, e, mousePosition);
            }
        }

        ///  <summary>
        /// skonczenie poruszania elektronem
        /// </summary>
        /// <param name="sender">obiekt picture box który zgłosił nacisniecie myszka</param>
        /// <param name="e">obiekt myszy</param>
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)  
        {
            // Resetuj flagę, że PictureBox nie jest aktualnie przenoszony
            isDragging = false;
        }



        /// <summary>
        /// wejscie w opcje
        /// </summary>
        /// <param name="sender">obiekt przycisku</param>
        /// <param name="e">obiekt zdarzenia</param>

        private void OpcjeClick(object sender, EventArgs e) 
        {
            tabControl1.SelectTab(5);
        }
        /// <summary>
        /// zamkniecie aplikacji
        /// </summary>
        /// <param name="sender">obiekt przycisku</param>
        /// <param name="e">obiekt zdarzenia</param>
        private void Zamknijprog(object sender, EventArgs e) 
        {
            Application.Exit();
        }
        /// <summary>
        /// kontrola poziomu 1
        /// </summary>
        /// <param name="elektronbox">picturebox który jest sterowany w poziomie</param>
        /// <param name="e">obiekt myszy</param>
        /// <param name="mousePosition">pozycja myszy</param>

        public void SprawdzCzyblednyPoziom1(PictureBox elektronbox, MouseEventArgs e, Point mousePosition) 
        {
            if (R1.sprawdzPrzejscie() == false)
            {
                if (rezystor1.Bounds.IntersectsWith(elektronbox.Bounds)) /// kolizje
                {
                    this.Rezystor_1_label.Text = Rezystor_1_label.Text + " V ";
                    R1.ustawPrzeście(true);

                }
            }

            if (R1.sprawdzPrzejscie() == true && R2.sprawdzPrzejscie()==false)
            {
                if (rezystor3.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    this.rezystor3_label.Text = rezystor3_label.Text + " V ";
                    R2.ustawPrzeście(true);

                }
                else if(rezystor2.Bounds.IntersectsWith(elektronbox.Bounds)) /// utrata proby
                {
                    P1.stracProbe();
                    this.ProbyNapis.Text = "Pozostało prób:" + P1.Getproby().ToString();
                    this.Rezystor_1_label.Text = "R=500R";
                    elektronbox.Location = new Point(9, 191);
                    R1.ustawPrzeście(false);
                    R2.ustawPrzeście(false);
                    R3.ustawPrzeście(false);

                    player.Play();

                    if (P1.koniec == true)
                    {
                        elektronbox.Location = new Point(9, 231);
                        elektronbox.Visible = false;
                        isDragging = false;
                        wyzerujCzas();
                        R1.ustawPrzeście(false);
                        R2.ustawPrzeście(false);
                        R3.ustawPrzeście(false);
                        tabControl1.SelectTab(0);
                        
                    }

                }
            }

            if (R2.sprawdzPrzejscie() == true && U1.sprawdzPrzejscie()==false)
            {
                if (kondensator.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    P1.stracProbe();
                    this.ProbyNapis.Text = "Pozostało prób:" + P1.Getproby().ToString();
                    this.Rezystor_1_label.Text = "R=500R";
                    this.rezystor3_label.Text = "R=120R";
                    elektronbox.Location = new Point(9, 191);
                    R1.ustawPrzeście(false);
                    R2.ustawPrzeście(false);
                    R3.ustawPrzeście(false);
                    player.Play();

                    if (P1.koniec == true)
                    {
                        elektronbox.Location = new Point(9, 231);
                        elektronbox.Visible = false;
                        isDragging = false;
                        wyzerujCzas();
                        R1.ustawPrzeście(false);
                        R2.ustawPrzeście(false);
                        R3.ustawPrzeście(false);
                        tabControl1.SelectTab(0);

                    }

                }
                else if (zrodlo.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    U1.ustawPrzeście(true);
                    int p1punkty = P1.ObliczPunkty(countdownTime, P1.Getproby(),trudnosc);
                    elektronbox.Visible = false;
                    elektronbox.Location = new Point(9, 191);
                    isDragging = false;
                    Menuglowna.DodajPunkty(p1punkty);
                    wynikPo1.Visible = true;
                    PrzejscieDo2.Visible= true;
                    wynikPo1.Text = "Wynik Poziomu:" + p1punkty.ToString() + " Wynik Całkowity:" + Menuglowna.getPunktySuma();
                    timer1.Stop();
                    wyzerujCzas();
                }
            }



        }
        /// <summary>
        /// kontrola poziomu 2
        /// </summary>
        /// <param name="elektronbox">picturebox który jest sterowany w poziomie</param>
        /// <param name="e">obiekt myszy</param>
        /// <param name="mousePosition">pozycja myszy</param>
        public void SprawdzCzyblednyPoziom2(PictureBox elektronbox, MouseEventArgs e, Point mousePosition) /// kontrola poziomu 2
        {
            if (R1.sprawdzPrzejscie() == false)
            {
                if (rezystor4.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    this.rezystor_4_label.Text = rezystor_4_label.Text + " V ";
                    R1.ustawPrzeście(true);

                }
            }

            if (R1.sprawdzPrzejscie() == true && R2.sprawdzPrzejscie() == false)
            {
                if (rezystor6.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    this.rezystor_6_label.Text = rezystor_6_label.Text + " V ";
                    R2.ustawPrzeście(true);

                }
                else if (rezystor5.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    P1.stracProbe();
                    this.Proby2.Text = "Pozostało prób:" + P1.Getproby().ToString();
                    this.rezystor_4_label.Text = "R=1000R";
                    elektronbox.Location = new Point(9, 131);
                    R1.ustawPrzeście(false);
                    R2.ustawPrzeście(false);
                    R3.ustawPrzeście(false);
                    R4.ustawPrzeście(false);

                    player.Play();
                    if (P1.koniec == true)
                    {
                        elektronbox.Location = new Point(9, 131);
                        elektronbox.Visible = false;
                        isDragging = false;
                        wyzerujCzas();
                        R1.ustawPrzeście(false);
                        R2.ustawPrzeście(false);
                        R3.ustawPrzeście(false);
                        tabControl1.SelectTab(0);

                    }

                }
            }

            if (R2.sprawdzPrzejscie() == true && R3.sprawdzPrzejscie() == false)
            {
                if (rezystor7.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    this.rezystor_7_label.Text = rezystor_7_label.Text + " V ";
                    R3.ustawPrzeście(true);

                }

            }
            if(R3.sprawdzPrzejscie() == true && U1.sprawdzPrzejscie() == false)
            {
                if (kondensator2.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    P1.stracProbe();
                    this.Proby2.Text = "Pozostało prób:" + P1.Getproby().ToString();
                    this.rezystor_5_label.Text = "R=1000R";
                    this.rezystor_6_label.Text = "R=300R";
                    this.rezystor_7_label.Text = "R=640R";
                    elektronbox.Location = new Point(9, 191);
                    R1.ustawPrzeście(false);
                    R2.ustawPrzeście(false);
                    R3.ustawPrzeście(false);
                    player.Play();

                    if (P1.koniec == true)
                    {
                        elektronbox.Location = new Point(9, 231);
                        elektronbox.Visible = false;
                        isDragging = false;
                        wyzerujCzas();
                        R1.ustawPrzeście(false);
                        R2.ustawPrzeście(false);
                        R3.ustawPrzeście(false);
                        tabControl1.SelectTab(0);

                    }

                }
                else if (zrodlo2.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    U1.ustawPrzeście(true);
                    int p1punkty = P1.ObliczPunkty(countdownTime, P1.Getproby(),trudnosc);
                    elektronbox.Visible = false;
                    elektronbox.Location = new Point(9, 191);
                    isDragging = false;
                    Menuglowna.DodajPunkty(p1punkty);
                    wynikPo2.Visible = true;
                    PrzejscieDo3.Visible = true;
                    wynikPo2.Text = "Wynik Poziomu:" + p1punkty.ToString() + " Wynik Całkowity:" + Menuglowna.getPunktySuma();
                    timer1.Stop();
                    wyzerujCzas();
                }
            }



        }

        /// <summary>
        /// kontrola poziomu 3
        /// </summary>
        /// <param name="elektronbox">picturebox który jest sterowany w poziomie</param>
        /// <param name="e">obiekt myszy</param>
        /// <param name="mousePosition">pozycja myszy</param>
        public void SprawdzCzyblednyPoziom3(PictureBox elektronbox, MouseEventArgs e, Point mousePosition) /// kontrola poziomu 3
        {
            if (R1.sprawdzPrzejscie() == false)
            {
                if (rezystor10.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    this.rezystor_10_label.Text = rezystor_10_label.Text + " V ";
                    R1.ustawPrzeście(true);

                }
                else if(rezystor9.Bounds.IntersectsWith(elektronbox.Bounds) || rezystor8.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    P1.stracProbe();
                    this.ProbyNapis.Text = "Pozostało prób:" + P1.Getproby().ToString();
                   
                   
                    elektronbox.Location = new Point(9, 191);
                    R1.ustawPrzeście(false);
                    R2.ustawPrzeście(false);
                    R3.ustawPrzeście(false);
                    player.Play();

                    if (P1.koniec == true)
                    {
                        elektronbox.Location = new Point(9, 231);
                        elektronbox.Visible = false;
                        isDragging = false;
                        wyzerujCzas();
                        R1.ustawPrzeście(false);
                        R2.ustawPrzeście(false);
                        R3.ustawPrzeście(false);
                        tabControl1.SelectTab(0);

                    }
                }            
              }


            if (R1.sprawdzPrzejscie() == true && U1.sprawdzPrzejscie() == false)
            {
               if (zrodlo3.Bounds.IntersectsWith(elektronbox.Bounds))
                {
                    U1.ustawPrzeście(true);
                    int p1punkty = P1.ObliczPunkty(countdownTime, P1.Getproby(),trudnosc);
                    elektronbox.Visible = false;
                    elektronbox.Location = new Point(9, 191);
                    isDragging = false;
                    Menuglowna.DodajPunkty(p1punkty);
                    wynikPo3.Visible = true;
                    zamknijPrzycisk.Visible = true;
                    wynikPo3.Text = "Wynik Poziomu:" + p1punkty.ToString() + " Wynik Całkowity:" + Menuglowna.getPunktySuma();
                    timer1.Stop();
                    wyzerujCzas();
                }
            }



        }

        /// <summary>
        /// liczenie czasu w poziomach
        /// </summary>
        /// <param name="sender">obiekt timera</param>
        /// <param name="e"></param>

        private void zliaczanie(object sender, EventArgs e) 
        {
           
                // Uaktualnij tekst w elemencie label
                this.CzasWskaznik.Text = "Pozostały czas:" + countdownTime.ToString();
            this.CzasWskaznik2.Text = "Pozostały czas:" + countdownTime.ToString();
            this.CzasWskaznik3.Text = "Pozostały czas:" + countdownTime.ToString();
            // Odśwież widok formularza
            this.CzasWskaznik.Refresh();
            this.CzasWskaznik2.Refresh();
            this.CzasWskaznik3.Refresh();
            // Zmniejsz licznik o 1 sekundę
            countdownTime--;
            // Zatrzymaj wykonanie pętli na 1 sekundę
            // Thread.Sleep(1000);
            if (countdownTime == 0)
            {
                this.Rezystor_1_label.Text = "R=500R";
                this.rezystor3_label.Text = "R=120R";
                this.rezystor_5_label.Text = "R=1000R";
                this.rezystor_6_label.Text = "R=300R";
                this.rezystor_7_label.Text = "R=640R";
                this.rezystor_10_label.Text = "R=300R";
                R1.Location = rezystor1.Location;
                R2.Location = rezystor2.Location;
                R3.Location = rezystor3.Location;
                R4.Location = rezystor4.Location;
                R1.ustawPrzeście(false);
                R2.ustawPrzeście(false);
                R3.ustawPrzeście(false);
                R4.ustawPrzeście(false);
                U1.ustawPrzeście(false);
                tabControl1.SelectTab(0);
                timer1.Stop();
            }
        }

        /// <summary>
        /// rysowanie poziomu 1
        /// </summary>
        /// <param name="sender">Pole Gry które ma być zamalowane</param>
        /// <param name="e">obiket Grafiki</param>
        private void PoleGry_Paint(object sender, PaintEventArgs e) 
        {
            Pen pen = new Pen(Color.Black,8);
            Point[] points = { new Point(50, 100), new Point(50, 50), new Point(300, 50), new Point(300, 270), new Point(300, 50), new Point(400, 50), new Point(400, 120) };
            e.Graphics.DrawLines(pen, points);
            Point[] points2 = { new Point(400, 150), new Point(400, 400), new Point(500, 400), new Point(400, 400), new Point(400, 500), new Point(50, 500), new Point(50, 150) };
            e.Graphics.DrawLines(pen, points2);
            Point[] points3 = { new Point(300, 250), new Point(300, 500)};
            e.Graphics.DrawLines(pen, points3);
        }
        /// <summary>
        /// start poziomów i odliczania czasu
        /// </summary>
        /// <param name="sender">PicturBox startujacy czas odliczania</param>
        /// <param name="e"></param>
        private void zrodlo_Click(object sender, EventArgs e) 
        {
            timer1.Start();
            electron.Visible = true;
            electron2.Visible = true;
            electron3.Visible = true;

            // zliaczanie(this.CzasWskaznik, 300);

        }
        /// <summary>
        /// reset zegara
        /// </summary>
        private void wyzerujCzas() 
        {
            timer1.Stop();
            countdownTime = Menuglowna.UstawOpcje(trudnosc);
            this.CzasWskaznik.Text = "Pozostały czas:" + countdownTime.ToString();
            this.CzasWskaznik2.Text = "Pozostały czas:" + countdownTime.ToString();
            this.CzasWskaznik3.Text = "Pozostały czas:" + countdownTime.ToString();
        }

        
        
     

        private void tabPoziom1_Enter(object sender, EventArgs e) /// start gry
        {
            P1.RozpoczecieGry();
        }

        private void PrzejscieDo2_Click(object sender, EventArgs e) /// zmiana na poziom 2
        {
            P1.RozpoczecieGry();
            wyzerujCzas();
            Menuglowna.Poziom2();
            R1.Location = rezystor1.Location;
            R2.Location = rezystor2.Location;
            R3.Location = rezystor3.Location;
            R4.Location = rezystor4.Location;
            R1.ustawPrzeście(false);
            R2.ustawPrzeście(false);
            R3.ustawPrzeście(false);
            R4.ustawPrzeście(false);
            U1.ustawPrzeście(false);
            tabControl1.SelectTab(2);
            electron2.Visible = false;
        }

        private void PrzejscieDo3_Click(object sender, EventArgs e) /// zmiana na poziom 3
        {
            P1.RozpoczecieGry();
            wyzerujCzas();
            Menuglowna.Poziom3();
            R1.Location = rezystor1.Location;
            R2.Location = rezystor2.Location;
            R3.Location = rezystor3.Location;
            R4.Location = rezystor4.Location;
            R1.ustawPrzeście(false);
            R2.ustawPrzeście(false);
            R3.ustawPrzeście(false);
            R4.ustawPrzeście(false);
            U1.ustawPrzeście(false);
            tabControl1.SelectTab(3);
            electron3.Visible = false;
        }
        /// <summary>
        /// rysowanie poziomu 2
        /// </summary>
        /// <param name="sender">Pole Gry które ma być zamalowane</param>
        /// <param name="e">obiket Grafiki</param>
        private void PoleGry2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 8);
            Point[] points = { new Point(50, 430), new Point(50, 50), new Point(300, 50), new Point(300, 170), new Point(200,170 ), new Point(200, 350), new Point(500, 350), new Point(500, 170), new Point(300, 170) };
            e.Graphics.DrawLines(pen, points);
            Point[] points2 = { new Point(50, 430), new Point(500, 430)};
            e.Graphics.DrawLines(pen, points2);
        
        }

        ///<summary>
        /// rysowanie poziomu 3
        /// </summary>
        /// <param name="sender">Pole Gry które ma być zamalowane</param>
        /// <param name="e">obiket Grafiki</param>
        private void PoleGry3_Paint(object sender, PaintEventArgs e) 
        {
            Pen pen = new Pen(Color.Black, 8);
            Point[] points = { new Point(50, 500), new Point(50, 50), new Point(350, 50), new Point(350, 500), new Point(50, 500) };
            e.Graphics.DrawLines(pen, points);
            Point[] points2 = { new Point(200, 400), new Point(200, 200), new Point(500, 200), new Point(500, 400), new Point(200, 400) };
            e.Graphics.DrawLines(pen, points2);
        }

        private void zamknijPrzycisk_Click(object sender, EventArgs e) /// wychodzenie do menu
        {
            electron.Visible = false;
            electron2.Visible = false;
            electron3.Visible = false;
            this.Rezystor_1_label.Text = "R=500R";
            this.rezystor3_label.Text = "R=120R";
            this.rezystor_5_label.Text = "R=1000R";
            this.rezystor_6_label.Text = "R=300R";
            this.rezystor_7_label.Text = "R=640R";
            this.rezystor_10_label.Text = "R=300R";
            wyzerujCzas();
            Menuglowna.Poziom3();
            R1.Location = rezystor1.Location;
            R2.Location = rezystor2.Location;
            R3.Location = rezystor3.Location;
            R4.Location = rezystor4.Location;
            R1.ustawPrzeście(false);
            R2.ustawPrzeście(false);
            R3.ustawPrzeście(false);
            R4.ustawPrzeście(false);
            U1.ustawPrzeście(false);
            tabControl1.SelectTab(0);
        }

        private void powrót_Click(object sender, EventArgs e) /// powrót do menu z opcji
        {
            tabControl1.SelectTab(0);
        }

        private void TrudnoscŁatwy_Click(object sender, EventArgs e) /// wybieranie trdunosci łatwy
        {
            trudnosc = 1;
        }

        private void TrudnoscŚredni_Click(object sender, EventArgs e)/// wybieranie trdunosci średni
        {
            trudnosc = 2;
        }

        private void TrudnosćTrudny_Click(object sender, EventArgs e)/// wybieranie trdunosci trudny
        {
            trudnosc = 3;
        }
    }
}


        /*
private void OPenForm(object obj)
{
Application.Run(new Form2());
}
*/
