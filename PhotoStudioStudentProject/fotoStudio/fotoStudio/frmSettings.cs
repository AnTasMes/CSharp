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
using System.Text.RegularExpressions;

namespace fotoStudio
{
    public partial class frmSettings : Form
    {
        Regex passValid = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.{8,})");
        MySqlConnection conn = new MySqlConnection(clsConnection.connection);
        public frmSettings()
        {
            InitializeComponent();
            if(Properties.Settings.Default.role != "Admin")
            {
                btnAdmin.Visible = false;
                btnAdmin.Enabled = false;
            }
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text != string.Empty)
            {
                if(usernameCheck()==false)
                {
                    updateUsername();
                }
            }
            else if(tbNewPass.Text == tbRpt.Text && passValid.IsMatch(tbNewPass.Text) && currPassIsGood() == true)
            {
                updatePassword();
            }
        }

        public bool currPassIsGood()
        {
            bool pswdGood = false;
            string checkString = "SELECT password FROM `user` WHERE username = @username and password = @password";
            MySqlCommand cmdCheck = new MySqlCommand(checkString, conn);
            try
            {
                conn.Open();
                cmdCheck.Parameters.AddWithValue("@username", accountInfo.Encrypt(tbUsername.Text));
                cmdCheck.Parameters.AddWithValue("@password", accountInfo.Encrypt(tbCurrPass.Text));
                MySqlDataReader dr = cmdCheck.ExecuteReader();
                if (dr.HasRows)
                {
                    errorProvider1.SetError(tbCurrPass, "Password is not correct");
                    errorProvider1.SetIconPadding(tbCurrPass, -20);
                    pswdGood = false;
                }
                else
                {
                    errorProvider1.SetError(tbCurrPass, "");
                    errorProvider1.SetIconPadding(tbCurrPass, -20);
                    pswdGood = true;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            conn.Close();
            return pswdGood;
        }

        public void updatePassword()
        {
            string updatePassword = "UPDATE user SET password=@password WHERE username=@username";
            MySqlCommand cmdUpdatePassword = new MySqlCommand(updatePassword, conn);
            cmdUpdatePassword.Parameters.AddWithValue("@password", accountInfo.Encrypt(tbNewPass.Text));
            cmdUpdatePassword.Parameters.AddWithValue("@username", accountInfo.Encrypt(accountInfo.Username));
            try
            {
                conn.Open();
                cmdUpdatePassword.ExecuteNonQuery();
                MessageBox.Show("Password changed please login again");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            conn.Close();
        }

        public bool usernameCheck()
        {            
            bool usnmTaken = true;
            string checkString = "SELECT username FROM `user` WHERE username = @username";
            MySqlCommand cmdCheck = new MySqlCommand(checkString, conn);
            try
            {
                conn.Open();
                cmdCheck.Parameters.AddWithValue("@username", accountInfo.Encrypt(tbUsername.Text));
                MySqlDataReader dr = cmdCheck.ExecuteReader();
                if (dr.HasRows)
                {
                    errorProvider1.SetError(tbUsername, "Username taken");
                    errorProvider1.SetIconPadding(tbUsername, -20);
                    usnmTaken = true;
                }
                else
                {
                    errorProvider1.SetError(tbUsername, "");
                    errorProvider1.SetIconPadding(tbUsername, -20);
                    usnmTaken = false;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            conn.Close();
            return usnmTaken;
        }

        public void updateUsername()
        {
            string updateUser = "UPDATE user SET username=@username WHERE username= @username2";
            string updateSelected = "UPDATE selectedphotos SET username=@usernamePHT WHERE username= @usernamePHT2";
            string updateReservation = "UPDATE reservation SET username=@usernameRSV WHERE username= @usernameRSV2";
            string updateImage = "UPDATE image SET username=@usernameIMG WHERE username= @usernameIMG2";
            MySqlCommand cmdUpdateUser = new MySqlCommand(updateUser, conn);
            MySqlCommand cmdUpdateSelected = new MySqlCommand(updateSelected, conn);
            MySqlCommand cmdUpdateReservation = new MySqlCommand(updateReservation, conn);
            MySqlCommand cmdUpdateImage = new MySqlCommand(updateImage, conn);
            cmdUpdateUser.Parameters.AddWithValue("@username", accountInfo.Encrypt(tbUsername.Text));
            cmdUpdateUser.Parameters.AddWithValue("@username2", accountInfo.Encrypt(accountInfo.Username));
            cmdUpdateSelected.Parameters.AddWithValue("@usernamePHT", accountInfo.Encrypt(tbUsername.Text));
            cmdUpdateSelected.Parameters.AddWithValue("@usernamePHT2", accountInfo.Encrypt(accountInfo.Username));
            cmdUpdateReservation.Parameters.AddWithValue("@usernameRSV", accountInfo.Encrypt(tbUsername.Text));
            cmdUpdateReservation.Parameters.AddWithValue("@usernameRSV2", accountInfo.Encrypt(accountInfo.Username));
            cmdUpdateImage.Parameters.AddWithValue("@usernameIMG", accountInfo.Encrypt(tbUsername.Text));
            cmdUpdateImage.Parameters.AddWithValue("@usernameIMG2", accountInfo.Encrypt(accountInfo.Username));
            try
            {
                conn.Open();
                cmdUpdateUser.ExecuteNonQuery();
                cmdUpdateSelected.ExecuteNonQuery();
                cmdUpdateReservation.ExecuteNonQuery();
                cmdUpdateImage.ExecuteNonQuery();
                accountInfo.Username = tbUsername.Text;
                MessageBox.Show("Username changed please login again");                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            conn.Close();
        }

        private void tbRpt_TextChanged(object sender, EventArgs e)
        {
            if (tbRpt.Text != null && (tbRpt.Text != tbNewPass.Text))
            {
                errorProvider1.SetError(tbRpt, "Sifre se ne poklapaju");
                errorProvider1.SetIconPadding(tbRpt, -20);
            }
            else
            {
                errorProvider1.SetError(tbRpt, "");
            }
        }

        private void tbNewPass_TextChanged(object sender, EventArgs e)
        {
            if (tbNewPass.Text != null)
            {
                if (passValid.IsMatch(tbNewPass.Text))
                {
                    errorProvider1.SetError(tbNewPass, "");
                }
                else
                {
                    this.errorProvider1.SetIconPadding(this.tbNewPass, -20);
                    errorProvider1.SetError(tbNewPass, "Sifra mora imati:\n-Minimum 8 karaktera\n-Minimum jedno veliko slovo\n-Minimum jedan broj");
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminPanel ap = new adminPanel();
            ap.ShowDialog();      
        }
    }
}
