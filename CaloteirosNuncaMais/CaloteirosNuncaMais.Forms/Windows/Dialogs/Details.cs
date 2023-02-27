using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaloteirosNuncaMais.Forms.Windows.Dialogs
{
    public partial class Details : Form
    {
        private bool _mouseClicked = false;
        private Point _clickedAt;

        public Details()
        {
            InitializeComponent();
        }

        private void roundedButtonExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            _mouseClicked = true;
            _clickedAt = e.Location;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseClicked)
                this.Location = new Point(Cursor.Position.X - _clickedAt.X, Cursor.Position.Y - _clickedAt.Y);
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void roundedButtonSetPay_Click(object sender, EventArgs e)
        {
            this.pictureBoxChecked.Image = Properties.Resources.check;
        }
    }
}
