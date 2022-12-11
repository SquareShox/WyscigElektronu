using System.Drawing;
namespace Projekt_Wyścigelektronu
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.opcje = new System.Windows.Forms.Button();
            this.zamknij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tabPoziom1 = new System.Windows.Forms.TabPage();
            this.PoleGry = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.rezystor1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wskaźnikPoziomu = new System.Windows.Forms.Label();
            this.CzasWskaznik = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ProbyNapis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.electron = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabPoziom1.SuspendLayout();
            this.PoleGry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezystor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electron)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(385, 156);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(176, 83);
            this.start.TabIndex = 0;
            this.start.Text = "START\r\n";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.StartClick);
            // 
            // opcje
            // 
            this.opcje.Location = new System.Drawing.Point(385, 264);
            this.opcje.Name = "opcje";
            this.opcje.Size = new System.Drawing.Size(176, 83);
            this.opcje.TabIndex = 1;
            this.opcje.Text = "opcje";
            this.opcje.UseVisualStyleBackColor = true;
            // 
            // zamknij
            // 
            this.zamknij.Location = new System.Drawing.Point(385, 367);
            this.zamknij.Name = "zamknij";
            this.zamknij.Size = new System.Drawing.Size(176, 83);
            this.zamknij.TabIndex = 2;
            this.zamknij.Text = "WYJDŹ";
            this.zamknij.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TI-Nspire Sans", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(208, 52);
            this.label1.MinimumSize = new System.Drawing.Size(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "WYŚCIG ELEKTRONU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMenu);
            this.tabControl1.Controls.Add(this.tabPoziom1);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, -22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 757);
            this.tabControl1.TabIndex = 4;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.start);
            this.tabMenu.Controls.Add(this.label1);
            this.tabMenu.Controls.Add(this.opcje);
            this.tabMenu.Controls.Add(this.zamknij);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1003, 731);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "tabMenu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // tabPoziom1
            // 
            this.tabPoziom1.Controls.Add(this.PoleGry);
            this.tabPoziom1.Controls.Add(this.panel1);
            this.tabPoziom1.Controls.Add(this.pictureBox1);
            this.tabPoziom1.Location = new System.Drawing.Point(4, 22);
            this.tabPoziom1.Name = "tabPoziom1";
            this.tabPoziom1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoziom1.Size = new System.Drawing.Size(1003, 731);
            this.tabPoziom1.TabIndex = 1;
            this.tabPoziom1.Text = "tabPage2";
            this.tabPoziom1.UseVisualStyleBackColor = true;
            // 
            // PoleGry
            // 
            this.PoleGry.Controls.Add(this.electron);
            this.PoleGry.Controls.Add(this.label6);
            this.PoleGry.Controls.Add(this.label5);
            this.PoleGry.Controls.Add(this.label4);
            this.PoleGry.Controls.Add(this.label3);
            this.PoleGry.Controls.Add(this.label2);
            this.PoleGry.Controls.Add(this.pictureBox9);
            this.PoleGry.Controls.Add(this.pictureBox8);
            this.PoleGry.Controls.Add(this.pictureBox7);
            this.PoleGry.Controls.Add(this.rezystor1);
            this.PoleGry.Controls.Add(this.pictureBox5);
            this.PoleGry.Controls.Add(this.pictureBox4);
            this.PoleGry.Controls.Add(this.pictureBox3);
            this.PoleGry.Location = new System.Drawing.Point(165, 12);
            this.PoleGry.Name = "PoleGry";
            this.PoleGry.Size = new System.Drawing.Size(629, 566);
            this.PoleGry.TabIndex = 2;
            this.PoleGry.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movePictureBoxWithMouse);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "R=100R";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Projekt_Wyścigelektronu.Properties.Resources.kondensator;
            this.pictureBox9.Location = new System.Drawing.Point(517, 416);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(84, 66);
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Projekt_Wyścigelektronu.Properties.Resources.masa;
            this.pictureBox8.Location = new System.Drawing.Point(517, 497);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(84, 66);
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Projekt_Wyścigelektronu.Properties.Resources.masa;
            this.pictureBox7.Location = new System.Drawing.Point(192, 497);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(84, 66);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // rezystor1
            // 
            this.rezystor1.Image = global::Projekt_Wyścigelektronu.Properties.Resources.rezytor;
            this.rezystor1.Location = new System.Drawing.Point(15, 106);
            this.rezystor1.Name = "rezystor1";
            this.rezystor1.Size = new System.Drawing.Size(84, 105);
            this.rezystor1.TabIndex = 3;
            this.rezystor1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Projekt_Wyścigelektronu.Properties.Resources.rezytor;
            this.pictureBox5.Location = new System.Drawing.Point(404, 106);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 105);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Projekt_Wyścigelektronu.Properties.Resources.rezytor;
            this.pictureBox4.Location = new System.Drawing.Point(266, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 105);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projekt_Wyścigelektronu.Properties.Resources.źródło;
            this.pictureBox3.Location = new System.Drawing.Point(15, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 79);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.wskaźnikPoziomu);
            this.panel1.Controls.Add(this.CzasWskaznik);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ProbyNapis);
            this.panel1.Location = new System.Drawing.Point(-4, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 143);
            this.panel1.TabIndex = 1;
            // 
            // wskaźnikPoziomu
            // 
            this.wskaźnikPoziomu.AutoSize = true;
            this.wskaźnikPoziomu.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wskaźnikPoziomu.Location = new System.Drawing.Point(746, 50);
            this.wskaźnikPoziomu.Name = "wskaźnikPoziomu";
            this.wskaźnikPoziomu.Size = new System.Drawing.Size(113, 29);
            this.wskaźnikPoziomu.TabIndex = 3;
            this.wskaźnikPoziomu.Text = "Poziom 1";
            // 
            // CzasWskaznik
            // 
            this.CzasWskaznik.AutoSize = true;
            this.CzasWskaznik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CzasWskaznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CzasWskaznik.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CzasWskaznik.Location = new System.Drawing.Point(444, 50);
            this.CzasWskaznik.Name = "CzasWskaznik";
            this.CzasWskaznik.Size = new System.Drawing.Size(227, 29);
            this.CzasWskaznik.TabIndex = 2;
            this.CzasWskaznik.Text = "Pozostały czas : 300";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Moccasin;
            this.pictureBox2.Image = global::Projekt_Wyścigelektronu.Properties.Resources.panel_e;
            this.pictureBox2.Location = new System.Drawing.Point(34, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 71);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ProbyNapis
            // 
            this.ProbyNapis.AutoSize = true;
            this.ProbyNapis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProbyNapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProbyNapis.Location = new System.Drawing.Point(178, 50);
            this.ProbyNapis.Name = "ProbyNapis";
            this.ProbyNapis.Size = new System.Drawing.Size(196, 31);
            this.ProbyNapis.TabIndex = 0;
            this.ProbyNapis.Text = "Pozostało prób:3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekt_Wyścigelektronu.Properties.Resources.pngtree_blue_technology_digital_electronic_product_image_7451_e;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1007, 731);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1003, 731);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "R=120R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "R=500R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "V=10V";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "C=10uF";
            // 
            // electron
            // 
            this.electron.Image = global::Projekt_Wyścigelektronu.Properties.Resources.elektron;
            this.electron.Location = new System.Drawing.Point(108, 332);
            this.electron.Name = "electron";
            this.electron.Size = new System.Drawing.Size(70, 79);
            this.electron.TabIndex = 12;
            this.electron.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "WyscigElektronu";
            this.tabControl1.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.tabPoziom1.ResumeLayout(false);
            this.PoleGry.ResumeLayout(false);
            this.PoleGry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezystor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electron)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button opcje;
        private System.Windows.Forms.Button zamknij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabPoziom1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PoleGry;
        private System.Windows.Forms.Label ProbyNapis;
        private System.Windows.Forms.Label CzasWskaznik;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label wskaźnikPoziomu;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox rezystor1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox electron;
    }

    
}

