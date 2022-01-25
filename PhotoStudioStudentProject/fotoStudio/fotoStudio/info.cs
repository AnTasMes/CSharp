using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fotoStudio
{
    public partial class info : Form
    {
        MySqlConnection conn = new MySqlConnection(clsConnection.connection); //Konekcija
        public info()
        {
            InitializeComponent();
            getInfo();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void menu_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tmrAnimator.Start();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = default;
            pictureBox1.BackColor = default;
        }

        public void getInfo()
        {
            string _getInfoString = "SELECT * FROM `gen_info` WHERE 1";
            MySqlCommand getInfoCommand = new MySqlCommand(_getInfoString, conn);
            var dataSet = new DataSet();
            try
            {
                conn.Open();                
                var dataAdapter = new MySqlDataAdapter(getInfoCommand);
                dataAdapter.Fill(dataSet);
                lblLCT.Text = dataSet.Tables[0].Rows[0]["address"].ToString();
                lblCPhone.Text = dataSet.Tables[0].Rows[0]["c_num"].ToString();
                lblWT.Text = dataSet.Tables[0].Rows[0]["worktime"].ToString();
                conn.Close();
            }
            catch (Exception)
            {
                lblCPhone.Text = "";
                lblLCT.Text = "";
                lblWT.Text = "";
            }            
        }

        private void info_Load(object sender, EventArgs e)
        {
            getInfo();
        }

        private void tmrAnimator_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.00)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                tmrAnimator.Stop();
                this.Close();
            }
        }
    }
}
