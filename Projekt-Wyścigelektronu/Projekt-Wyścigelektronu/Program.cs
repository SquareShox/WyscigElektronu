using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
           

        }
    }

    class Menu /// klasa oblugujaca liczenie poziomów
    {
        public int ktoryPoziom = 1;
        bool graRzopoczęta = false;
       // int czaspoziomutrudnosc;
       public int sumapunktów = 0;
        /// <summary>
        /// sumowanie punktów ze wszyastkich poziomów
        /// </summary>
        /// <param name="punkty">punkty z ukończonego poziomu</param>
        public void DodajPunkty(int punkty) 
        {
            sumapunktów = sumapunktów + punkty;

        }

        public int getPunktySuma() /// zwraca sume punktów
        {
            return sumapunktów;
        }

        public void RozpocznijGre() /// informacje który poziom odpalić po starcie
        {
            ktoryPoziom = 1;
            sumapunktów = 0;
        }

        public void Poziom2() /// zmiana na poziom 2
        {
            ktoryPoziom = 2;
        }
        public void Poziom3() /// zmiana na poziom 3
        {
            ktoryPoziom = 3;
        }
        /// <summary>
        ///ustawienie trudnosci zmienia się czas na ukończenie poziomu
        /// </summary>
        /// <param name="trdunosc"> z zakresu od 1 do 3 przyjmuje trudnosc poziomu</param>
        /// <returns> zwraca dokładny czas trwania poziomu</returns>
        public int UstawOpcje(int trdunosc) 
        {
            if (trdunosc == 1) return 200;

            if (trdunosc == 2) return 100;

            if (trdunosc == 3) return 20;

            return 200;

        }


    }

    class StatusPoziomu /// kontrokla błedów użytkownika i ich obliczenie
    {

        int proby = 3;
        
        int punkty = 0;
        public bool koniec = false;
        public StatusPoziomu()
        {
            
            bool poziomWtrakcie = false;
        }

        public void RozpoczecieGry() /// reset prob do nastepnego poziomu
        {

            proby = 3;
            koniec = false;
        }

       public int Getproby() /// zwracanie ilości pozostałych prób
        {
            return proby;
        }
        /// <summary>
        /// liczenie punktów z poziomu
        /// </summary>
        /// <param name="czasPoziomu">czas w jakim poziom został ukończony</param>
        /// <param name="proby">ilośc pozostałych prób</param>
        /// <param name="trudnosc"> stopień trudnosci</param>
        /// <returns></returns>
        public int ObliczPunkty(int czasPoziomu,int proby,int trudnosc) 
        {
             punkty = 20 * czasPoziomu * proby  * trudnosc*trudnosc;

            return punkty;
        }

        public void stracProbe() /// utrata próby
        {
            proby--;
            if(proby == 0)
            {
                koniec = true;
                
            }
        }



    }

    class Rezystor : PictureBox /// obieKt rezytsor 
    {
        int PozX;
        int PozY;
        int Rez;
        bool bledny;
        bool zaliczony = false; 
        public Rezystor(int PozycjaX,int PozycjaY,float Rezystancja,bool bledny) 
        {
           PozX = PozycjaX;
        }
        public int ZwrocPozycje()
        {
            return PozX;
        }

        public float ZwrocRezystancje()
        {
            return Rez;
        }

        public void ustawPrzeście(bool przeszedl) /// sprawdzanie czy obiekt został pokonany
        {
            zaliczony = przeszedl;
        }
        
        public bool sprawdzPrzejscie() { return zaliczony; } /// <summary>
        /// zwracanie tej informacji
        /// </summary>
        /// <returns></returns>

        public bool sprawdzBledny() { return bledny; }

     }


    class Zrodlo : PictureBox /// obiekt źródło napięciowe
    {

        int PozX;
        int PozY;
        float Vol;
        bool zaliczony = false;
        public Zrodlo(int PozycjaX, int PozycjaY, float Napiecie, bool uruchomione)
        {
            PozX = PozycjaX;
        }

        public int ZwrocPozycje()
        {
            return PozX;
        }

        public float ZwrocNapiecie()
        {
            return Vol;
        }

        public void ustawPrzeście(bool przeszedl) /// sprawdzanie czy obiekt został pokonany
        {
            zaliczony = przeszedl;
        }

        public bool sprawdzPrzejscie() { return zaliczony; }/// zwracanie tej informacji

    }

    class Kondensator : PictureBox /// obiekt kondensatora
    {
        int PozX;
        int PozY;
        float Poj;
        bool bledny;
        bool zaliczony = false;
        public Kondensator(int PozycjaX, int PozycjaY, float pojemnosc, bool bledny)
        {
            PozX = PozycjaX;
        }

        public int ZwrocPozycje()
        {
            return PozX;
        }

        public float ZwrocPojemnosc()
        {
            return Poj;
        }

        public void ustawPrzeście(bool przeszedl)
        {
            zaliczony = przeszedl;
        }

        public bool sprawdzPrzejscie() { return zaliczony; } /// <summary>
        /// sprawdzanie czy obiekt został pokonany
        /// </summary>
        /// <returns> CZY OBIEKT ZOSTAŁ ZALICZONY</returns>

        public bool sprawdzBledny() { return bledny; } /// zwracanie tej informacji
    }
}
