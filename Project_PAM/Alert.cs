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
    public partial class Alert : Form
    {
        Boolean cameraTurn = true;

        public Alert()
        {
            InitializeComponent();
            
        }

        private void Alert_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cameraTurn = true;
            App app = new App(cameraTurn);
            app.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cameraTurn = false;
            App app = new App(cameraTurn);
            app.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
