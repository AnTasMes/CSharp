using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace fotoStudio
{
    //Srediti label u InfoPanelu
    public partial class frm1 : Form
    {
        MySqlConnection conn = new MySqlConnection(clsConnection.connection);
        Regex passValid = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.{8,})");
        bool goLog = true;
        public frm1()
        {
            InitializeComponent();
            connError = checkConn();
            label2.Text = "";
            conCheckTimer.Start();
            panelSelect.Height = btnLogin.Height;
            panelSelect.Top = btnLogin.Top;
            btnLogin.Focus();
            tbPasswordLogin.PasswordChar = '•';
            btnRegFinal.Enabled = false;
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if(cbRemember.Checked == false) //ako korisnik odluci da iskljuci remember me, ne mora jos jednom da se uloguje kako bi to potvrdio
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            Application.Exit();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = default;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(108, 122, 137);
            Cursor.Current = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = default;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logColor();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            regColor();
        }

        bool pwChar = true;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (pwChar)
            {
                case true:
                    tbPasswordLogin.PasswordChar = '\0';
                    btnSee.BackColor = Color.FromArgb(192, 192, 0);
                    pwChar = false;
                    break;
                case false:
                    tbPasswordLogin.PasswordChar = '•';
                    btnSee.BackColor = Color.FromArgb(224, 224, 224);
                    pwChar = true;
                    break;
                default:
                    break;
            }
        }

        private void btnLogFinal_MouseMove(object sender, MouseEventArgs e)
        {
            btnLogFinal.BackColor = Color.FromArgb(252, 186, 127);
        }

        private void btnLogFinal_MouseLeave(object sender, EventArgs e)
        {
            btnLogFinal.BackColor = default;
        }

        private void btnRegFinal_MouseMove(object sender, MouseEventArgs e)
        {
            btnRegFinal.BackColor = Color.FromArgb(252, 186, 127);
        }

        private void btnRegFinal_MouseLeave(object sender, EventArgs e)
        {
            btnRegFinal.BackColor = default;
        }

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public void regColor()
        {
            if(connError == true)
            {
                btnLogFinal.Enabled = false;
                btnRegFinal.Enabled = true;
            }
            panelSelect.Height = btnRegister.Height;
            panelSelect.Top = btnRegister.Top;
            panel1.BackColor = Color.FromArgb(246, 146, 114);
            this.BackColor = Color.FromArgb(35, 46, 49);
            goLog = false;
        }

        public void logColor()
        {
            if (connError == true)
            {
                btnRegFinal.Enabled = false;
                btnLogFinal.Enabled = true;
            }
            panelSelect.Height = btnLogin.Height;
            panelSelect.Top = btnLogin.Top;
            this.BackColor = Color.FromArgb(246, 146, 114);
            panel1.BackColor = Color.FromArgb(35, 46, 49);
            goLog = true;
        }

        private void tbUsernameRegister_Click(object sender, EventArgs e)
        {
            regColor();
        }

        private void tbPasswordRegister_Click(object sender, EventArgs e)
        {
            regColor();
        }

        private void tbCheckPassword_Click(object sender, EventArgs e)
        {
            regColor();
        }

        private void tbUsernameLogin_Click(object sender, EventArgs e)
        {
            logColor();
        }

        private void tbPasswordLogin_Click(object sender, EventArgs e)
        {
            logColor();
        }
        info f1 = new info();
        private void button1_Click_1(object sender, EventArgs e)
        {
            panelSelect.Height = btnInfo.Height;
            panelSelect.Top = btnInfo.Top;            
            f1.ShowDialog();
            f1.Opacity = 0.95;
        }

        private void frm1_Load(object sender, EventArgs e) //Implementiramo ubacivanje lokalnih podataka u text box-ove (podaci se dekriptuju)
        {
            if(Properties.Settings.Default.Username != string.Empty)
            {
                tbUsernameLogin.Text = accountInfo.Decrypt(Properties.Settings.Default.Username);
                tbPasswordLogin.Text = accountInfo.Decrypt(Properties.Settings.Default.Password);
                cbRemember.Checked = true;
            }
        }

        
        private void tbPasswordRegister_TextChanged(object sender, EventArgs e)
        {
            if (tbPasswordRegister.Text != null)
            {
                if (passValid.IsMatch(tbPasswordRegister.Text))
                {
                    errorProvider1.SetError(tbPasswordRegister, "");
                }
                else
                {
                    this.errorProvider1.SetIconPadding(this.tbPasswordRegister, -20);
                    errorProvider1.SetError(tbPasswordRegister, "Sifra mora imati:\n-Minimum 8 karaktera\n-Minimum jedno veliko slovo\n-Minimum jedan broj");
                }
            }
        }

        private void tbCheckPassword_TextChanged(object sender, EventArgs e)
        {
            if(tbCheckPassword.Text != null && (tbCheckPassword.Text != tbPasswordRegister.Text))
            {
                errorProvider1.SetError(tbCheckPassword, "Sifre se ne poklapaju");
                errorProvider1.SetIconPadding(tbCheckPassword, -20);
            }
            else
            {
                errorProvider1.SetError(tbCheckPassword, "");
            }
        }

        private void btnRegFinal_Click(object sender, EventArgs e)
        {
            bool accountCheck = false;
            if(tbUsernameRegister.Text != string.Empty && tbPasswordRegister.Text == tbCheckPassword.Text && passValid.IsMatch(tbPasswordRegister.Text))
            {
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox && c.Text == string.Empty)
                    {
                        errorProvider1.SetError(c, "");
                    }
                }
                accountInfo.Username = tbUsernameRegister.Text;
                accountInfo.Password = tbPasswordRegister.Text;    
                
                try //Provera da li username postoji
                {
                    string _checkString = "SELECT `username` from `user` WHERE username = @username";
                    MySqlCommand checkCommand = new MySqlCommand(_checkString, conn);
                    conn.Open();
                    checkCommand.Parameters.AddWithValue("@username", accountInfo.Encrypt(accountInfo.Username));
                    MySqlDataReader dr = checkCommand.ExecuteReader();
                    if(dr.HasRows)
                    {
                        errorProvider1.SetError(tbUsernameRegister, "Username vec postoji");
                        errorProvider1.SetIconPadding(tbUsernameRegister, -20);
                        accountCheck = false;
                    }
                    else
                    {
                        errorProvider1.SetError(tbUsernameRegister, "");
                        accountCheck = true;
                    }
                    conn.Close();
                }
                catch (Exception)
                {
                    throw;
                }
                if(accountCheck == true)
                {
                    try //Ubacivanje vrednosti u bazu
                    {
                        string _registerString = "INSERT INTO `user` VALUES (NULL, @username, @password, null, NULL, 'usr')";
                        MySqlCommand registerCommand = new MySqlCommand(_registerString, conn);
                        conn.Open();
                        registerCommand.Parameters.AddWithValue("@username", accountInfo.Encrypt(accountInfo.Username));
                        registerCommand.Parameters.AddWithValue("@password", accountInfo.Encrypt(accountInfo.Password));
                        registerCommand.ExecuteNonQuery();
                        conn.Close();
                        tbCheckPassword.Text = "";
                        tbPasswordRegister.Text = "";
                        tbUsernameRegister.Text = "";
                        MessageBox.Show("Profil je kreiran, mozete se ulogovati");
                        logColor();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }
                }               
            }
            else
            {
                foreach(Control c in panel1.Controls)
                {
                    if(c is TextBox && c.Text == string.Empty)
                    {
                        errorProvider1.SetError(c, "Polje mora biti popunjeno");
                        errorProvider1.SetIconPadding(c, -20);
                    }
                }
            }
        }

        private void btnLogFinal_Click(object sender, EventArgs e)
        {
            accountInfo.Username = tbUsernameLogin.Text;
            accountInfo.Password = tbPasswordLogin.Text;
            try
            {
                conn.Open();
                string _checkAccount = "SELECT username, CASE WHEN role = 'adm' THEN 'Admin' " +
                    "WHEN role = 'usr' THEN 'User' ELSE 'nista' END as role FROM `user` " +
                    "WHERE username = @username and password = @password"; //Ovom komandom proveravamo dve stvari, prvo da li korisnik postoji, pa onda odvajamo da li je korisnik ili admin
                MySqlCommand cmdCheckAccount = new MySqlCommand(_checkAccount, conn);
                var ds = new DataSet();
                cmdCheckAccount.Parameters.AddWithValue("@username", accountInfo.Encrypt(accountInfo.Username));
                cmdCheckAccount.Parameters.AddWithValue("@password", accountInfo.Encrypt(accountInfo.Password));
                MySqlDataReader dr = cmdCheckAccount.ExecuteReader();              
                if (dr.HasRows)
                {
                    dr.Close(); //DataReader mora da se ugasi kako bi DataAdapter mogao da radi.
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdCheckAccount);
                    da.Fill(ds);
                    Properties.Settings.Default.role = ds.Tables[0].Rows[0]["role"].ToString();
                    Remember();
                    
                    //Paljenje druge forme
                    mainPanel mP = new mainPanel();
                    mP.Show();
                    if(mP.Visible == true)
                    {
                        this.Visible = false;
                    }                    
                }
                else
                {
                    MessageBox.Show("Uneti podaci nisu dobri");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            
        }

        public void Remember() //Metoda za proveru remember me check boxa
        {
            if(cbRemember.Checked == true) 
            {
                Properties.Settings.Default.Username = accountInfo.Encrypt(accountInfo.Username); //Ovde menjamo lokalna podesavanja programa i u cache ubacujemo vrednosti
                Properties.Settings.Default.Password = accountInfo.Encrypt(accountInfo.Password); //Vrednosti su enkriptovane
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
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
            }
        }

        // ---- CHECKING CONNECTION ---- //

        bool connError = false;
        int _blinkFrequency = 250;
        int _numberOfBlinks = 5;
        int _blinkCount = 0;
        public bool checkConn()
        {
            try
            {
                conn.Open();
            }
            catch
            {
                connError = false;
                if (connError == false)
                {
                    btnRegFinal.Enabled = false;
                    btnLogFinal.Enabled = false;
                    tmrBlink.Interval = _blinkFrequency;
                    tmrBlink.Start();
                }
                conn.Close();
            }
            if (conn.State == ConnectionState.Open)
            {
                connError = true;
                if (goLog == false)
                {
                    btnRegFinal.Enabled = false;
                    btnLogFinal.Enabled = true;
                }
                else
                {
                    btnLogFinal.Enabled = true;
                    btnRegFinal.Enabled = false;
                }
                
                
                label2.Text = "";
            }
            conn.Close();
            return connError;
        }

        private void conCheckTimer_Tick(object sender, EventArgs e)
        {
            checkConn();
        }

        private void tmrBlink_Tick(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
            label2.Text = "⚠ Connection error";
            this.label2.Visible = !this.label2.Visible;

            _blinkCount++;
            if (_blinkCount == _numberOfBlinks * 2)
            {
                tmrBlink.Stop();
                _blinkCount = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // ---- CHECKING CONNECTION END ---- //
    }
}
