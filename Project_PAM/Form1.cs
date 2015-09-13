using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_PAM
{
    public partial class Form1 : Form
    {
        private Image[] images = new Image[] {
            Properties.Resources.Algorytmy_tekstowe___minimizery___v12,
            Properties.Resources.Algorytmy_tekstowe___wyszukiwanie___v12,
            Properties.Resources.Algorytmy_tekstowe_v12,
            Properties.Resources.IO_1,
            Properties.Resources.IO_2,
            Properties.Resources.IO_3,
            Properties.Resources.IO_4,
            Properties.Resources.IO_5,
            Properties.Resources.IO_6,
            Properties.Resources.monografia,
            Properties.Resources.obszary_badan_med1,
            Properties.Resources.slajd1,
            Properties.Resources.slajd2_zatrudnienie,
            Properties.Resources.slajdy_biol1_ROS,
            Properties.Resources.slajdy_biol2_OCT,
            Properties.Resources.slajdy_biotechnol_1_,
            Properties.Resources.slajdy_grafika1,
            Properties.Resources.slajdy_grafika2,
            Properties.Resources.slajdy_grafika3,
            Properties.Resources.szablon_obszary_badan2_obrazek_tlo_SK1,
            Properties.Resources.szablon_obszary_badan2_obrazek_tlo_SK2,
            Properties.Resources.szablon_obszary_badan2_obrazek_tlo_SK3,
            Properties.Resources.Tomo1,
            Properties.Resources.Tomo2,
            Properties.Resources.Tomo3,
            Properties.Resources.Tomo4            
        };

        private FullScreen fullScreen = new FullScreen();
        int i = 0;
        int counter = 0;


        public Form1()
        {
            InitializeComponent();
            App camera = new App(false);
            camera.Show();
        }
        
        //co sie stanie kiedy klikniemy FULL SCREEN
        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            // jeżeli jest obraz używany na fullscreenie 
            if (!this.fullScreen.IsFullScreen)
            {
                //buttony fullscreen i closeprogram są ukryte
                FullScreenButton.Visible = false;
                CloseButton.Visible = false;
                ProgressBar.Visible = true;

                ButtonStartStop.Visible = true;
                ButtonHome.Visible = true;
                ButtonRight.Visible = true;
                ButtonHome.Visible = true;


                //picturebox jest rozciągany na cały screen
                PictureBox.Dock = DockStyle.Fill;
                // a następnie zawartosc jest rozciagana na całego pictureboxa
                fullScreen.EnterFullScreen(this);
            }
        }

        // obsługa buttonow ESC -> 
        //uaktywnia butoony na visible true
        //zamyka fullscreena i picture boxa przenosi do połozenia top w oknie małej aplikacji
        // lewo prawo przełącza screeny
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if (keyData == Keys.Escape)
            {
                if (this.fullScreen.IsFullScreen)
                {
                    FullScreenButton.Visible = true;
                    CloseButton.Visible = true;
                    ProgressBar.Visible = false;

                    ButtonStartStop.Visible = false;
                    ButtonHome.Visible = false;
                    ButtonRight.Visible = false;
                    ButtonHome.Visible = false;

                    PictureBox.Dock = DockStyle.Top;
                    fullScreen.LeaveFullScreen(this);
                }
                return true;

            }

            // PRAWY KEY
            if (keyData == Keys.Right)
            {
                if (this.fullScreen.IsFullScreen)
                {
                    LoadNextImage();
                }
                return true;
            }

            // LEWY KEY
            if (keyData == Keys.Left)
            {
                if (this.fullScreen.IsFullScreen)
                {
                    LoadPrevImage();
                }
                return true;
            }

            // SPACJA PAUZA
            if (keyData == Keys.Space)
            {
               StartStop();
                    return true;
            }

            else return base.ProcessCmdKey(ref msg, keyData);
        }

        public void LoadPrevImage()
        {
            if (i == 0) i = 25;
            PictureBox.Image = images[i];
            ProgressBar.Value = i;
            i--;
            
        }

        //funkcja wrzuca nstępne zdjęcie
        public void LoadNextImage()
        {        
            
            i++;
            if (i == 26) i = 0;
            PictureBox.Image = images[i];
            ProgressBar.Value = i;
            
        }
    
        //wywołanie tickniecia timera
        //wywołuje funkcje ładującą nextImage
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        //w tym miejscu program startuje, 
        //wrzucany jest obraz pierwszy
        //timer startuje
        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox.Image = images[i];
            timer1.Interval = 1000;
            timer1.Start();

            PauseLabel.Visible = false;
            ProgressBar.Visible = false;
            ProgressBar.Maximum = 25;

            ButtonStartStop.Visible = false;
            ButtonHome.Visible = false;
            ButtonRight.Visible = false;
            ButtonHome.Visible = false;

        }

        //zamyka program
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            i = 0;
            PictureBox.Image = images[i];
            ProgressBar.Value = 0;
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            LoadPrevImage();
        }

        private void ButonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funkcja startująca i stopująca automatyczny pokaz slajdow
        public void StartStop()
        {
            counter++;
            if (this.fullScreen.IsFullScreen)
            {
                if (counter % 2 == 1)
                {
                    timer1.Stop();
                    PauseLabel.Visible = true;
                }
                else
                {
                    PauseLabel.Visible = false;
                    timer1.Start();
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox_Click_1(object sender, EventArgs e)
        {

        }
    }
}
