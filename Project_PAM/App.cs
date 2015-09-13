using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Runtime.InteropServices;
using System.IO;

namespace Project_PAM
{
    public partial class App : Form
    {
        private Capture capture;
        private HaarCascade haarCascade;
        private FullScreen fullScreen = new FullScreen();
        DispatcherTimer timer;
        DispatcherTimer timerSlider;
        private Boolean cameraState = true;
        public Slider slider = new Slider();
        public Image[] images;
        public int sliderCount = 0;

        public App(Boolean cameraTurn)
        {
            InitializeComponent();
            images = slider.Images();
            pictureBox2.Image = images[0];
            if (!cameraTurn)
            {
                cameraState = false;
                pictureBox1.Hide();
            }
            else
            {
                pictureBox2.Hide();
            }

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Start();

            timer2.Interval = 1000;
            timer2.Start();

            //picturebox jest rozciągany na cały screen
            pictureBox1.Dock = DockStyle.Fill;
            // a następnie zawartosc jest rozciagana na całego pictureboxa
            fullScreen.EnterFullScreen(this);

            //pictureBox1.Hide();
            capture = new Capture();
            haarCascade = new HaarCascade(@"haarcascade_frontalface_alt_tree.xml");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image<Bgr, Byte> currentFrame = capture.QueryFrame();

            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;

            if (currentFrame != null && cameraState)
            {
                Image<Gray, Byte> grayFrame = currentFrame.Convert<Gray, Byte>();

                var detectedFaces = grayFrame.DetectHaarCascade(haarCascade)[0];

                int i = 0; 
                foreach (var face in detectedFaces)
                {
                    currentFrame.Draw(face.rect, new Bgr(0, double.MaxValue, 0), 3);
                    i++;
                }

                if(i > 0)
                {
                    pictureBox1.Show();
                    start.Hide();
                    right.Hide();
                    left.Hide();
                    power.Hide();
                    pictureBox2.Hide();
                }
                else
                {
                    pictureBox1.Hide();
                    start.Show();
                    right.Show();
                    left.Show();
                    power.Show();
                    pictureBox2.Show();
                }
                
                pictureBox1.Image = BitmapFromSource(ToBitmapSource(currentFrame));
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        [DllImport("gdi32")]
        private static extern int DeleteObject(IntPtr o);

        public static BitmapSource ToBitmapSource(IImage image)
        {
            using (System.Drawing.Bitmap source = image.Bitmap)
            {
                IntPtr ptr = source.GetHbitmap(); //obtain the Hbitmap

                BitmapSource bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    ptr,
                    IntPtr.Zero,
                    Int32Rect.Empty,
                    System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());

                DeleteObject(ptr); //release the HBitmap
                return bs;
            }
        }

        private System.Drawing.Bitmap BitmapFromSource(BitmapSource bitmapsource)
        {
            System.Drawing.Bitmap bitmap;
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();

                enc.Frames.Add(BitmapFrame.Create(bitmapsource));
                enc.Save(outStream);
                bitmap = new System.Drawing.Bitmap(outStream);
            }
            return bitmap;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            pictureBox2.Image = slider.LoadNextImage(sliderCount);
            sliderCount++;

            pictureBox2.Width = this.Width-100;
            pictureBox2.Height = this.Height;

            start.Height = this.Height / 4;     start.Width = 120;      start.Location = new System.Drawing.Point(0, 0);
            right.Height = this.Height / 4;     right.Width = 120;      right.Location = new System.Drawing.Point(0, this.Height / 4);
            left.Height = this.Height / 4;      left.Width = 120;       left.Location = new System.Drawing.Point(0, 2 * this.Height / 4);
            power.Height = this.Height / 4;     power.Width = 120;      power.Location = new System.Drawing.Point(0, 3 * this.Height / 4);

        }

        private void start_Click(object sender, EventArgs e)
        {

        }

        private void right_Click(object sender, EventArgs e)
        {

        }

        private void left_Click(object sender, EventArgs e)
        {

        }

        private void power_Click(object sender, EventArgs e)
        {

        }
    }
}
