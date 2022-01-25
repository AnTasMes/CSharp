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
using System.IO;

namespace fotoStudio
{
    public partial class infoForm : Form
    {
        MySqlConnection conn = new MySqlConnection(clsConnection.connection);
        public infoForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void infoForm_Load(object sender, EventArgs e)
        {
            getPicture();
            lblInfo.Text = infoTransfer.info + "\nProsecno trajanje projekta je:\n"+ infoTransfer.length+"h\n";
            lblPrice.Text = "Cena projekta:\n"+infoTransfer.price.ToString()+"e";
        }

        public void getPicture()
        {
            byte[] images = null;
            try
            {
                conn.Open();
                string _getPicture = "SELECT img FROM image JOIN service ON image.comm = service.comm WHERE service.comm=@comm";
                MySqlCommand cmdGetPicture = new MySqlCommand(_getPicture, conn);
                cmdGetPicture.Parameters.AddWithValue("@comm", infoTransfer.comm);
                MySqlDataReader imageDR = cmdGetPicture.ExecuteReader();
                if (imageDR.HasRows)
                {
                    imageDR.Close();
                    DataSet imageDS = new DataSet();
                    MySqlDataAdapter imageDA = new MySqlDataAdapter(cmdGetPicture);
                    imageDA.Fill(imageDS);
                    images = (byte[])imageDS.Tables[0].Rows[0]["img"];
                    MemoryStream ms = new MemoryStream(images);
                    Image img = Image.FromStream(ms);
                    pictureBox1.Image = img;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            
        }

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
