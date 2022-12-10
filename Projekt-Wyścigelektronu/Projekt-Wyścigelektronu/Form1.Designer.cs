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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PoleGry = new System.Windows.Forms.Panel();
            this.gwiazdka = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabPoziom1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PoleGry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwiazdka)).BeginInit();
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1003, 731);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-4, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 143);
            this.panel1.TabIndex = 1;
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
            // PoleGry
            // 
            this.PoleGry.Controls.Add(this.gwiazdka);
            this.PoleGry.Location = new System.Drawing.Point(208, 54);
            this.PoleGry.Name = "PoleGry";
            this.PoleGry.Size = new System.Drawing.Size(558, 524);
            this.PoleGry.TabIndex = 2;
            this.PoleGry.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // gwiazdka
            // 
            this.gwiazdka.Image = global::Projekt_Wyścigelektronu.Properties.Resources.pngtree_blue_technology_digital_electronic_product_image_7451_e;
            this.gwiazdka.Location = new System.Drawing.Point(110, 65);
            this.gwiazdka.Name = "gwiazdka";
            this.gwiazdka.Size = new System.Drawing.Size(60, 59);
            this.gwiazdka.TabIndex = 0;
            this.gwiazdka.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.tabPoziom1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PoleGry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwiazdka)).EndInit();
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
        private System.Windows.Forms.PictureBox gwiazdka;
    }

    
}

