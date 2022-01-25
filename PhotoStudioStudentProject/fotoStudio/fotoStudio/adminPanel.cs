using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotoStudio
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            ucPictures uc = new ucPictures();
            panel2.Controls.Add(uc);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        } 
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClose_MouseMove(object sender, MouseEventArgs e)
        {
            pbClose.BackColor = Color.Red;
            Cursor.Current = Cursors.Hand;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = default;
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            pbMinimize.BackColor = Color.FromArgb(108, 122, 137);
            Cursor.Current = Cursors.Hand;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackColor = default;
        }

        private void btnUserConf_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in panel2.Controls)
            {
                uc.Visible = false;
            }
            ucUserConf userConf = new ucUserConf();
            userConf.Dock = DockStyle.Fill;
            panel2.Controls.Add(userConf);
        }

        private void ucUserConf1_Load(object sender, EventArgs e)
        {

        }

        private void btnPictures_Click(object sender, EventArgs e)
        {
            foreach(UserControl uc in panel2.Controls)
            {
                uc.Visible = false;
            }
            ucPictures showPicture = new ucPictures();
            showPicture.Dock = DockStyle.Fill;
            panel2.Controls.Add(showPicture);
        }

        private void btnEditServices_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in panel2.Controls)
            {
                uc.Visible = false;
            }
            ucEditServices editServices = new ucEditServices();
            panel2.Controls.Add(editServices);
        }
    }
}
