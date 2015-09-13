using System;
using System.Windows.Forms;
using System.Drawing;

namespace Project_PAM
{
    public class FullScreen
    {
        private FormWindowState winState;
        private FormBorderStyle brdStyle;
        private bool topMost;
        private Rectangle bounds;

        public FullScreen()
        {
            IsFullScreen = false;
        }

        public bool IsFullScreen
        {
            get;
            set;
        }

        public void EnterFullScreen(Form targetForm)
        {
            if (!IsFullScreen)
            {
                Save(targetForm);
                targetForm.WindowState = FormWindowState.Maximized;
                targetForm.FormBorderStyle = FormBorderStyle.None;
                targetForm.TopMost = true;
                targetForm.Bounds = Screen.GetBounds(targetForm);

                IsFullScreen = true;
            }
        }

        private void Save(Form targetForm)
        {
            winState = targetForm.WindowState;
            brdStyle = targetForm.FormBorderStyle;
            topMost = targetForm.TopMost;
            bounds = targetForm.Bounds;
        }

        public void LeaveFullScreen(Form targetForm)
        {
            if (IsFullScreen)
            {
                targetForm.WindowState = winState;
                targetForm.FormBorderStyle = FormBorderStyle.None;
                targetForm.Width = 360;
                targetForm.Height = 465;
                targetForm.TopMost = topMost;
                targetForm.Bounds = bounds;

                IsFullScreen = false;
            }
        }
    }
}