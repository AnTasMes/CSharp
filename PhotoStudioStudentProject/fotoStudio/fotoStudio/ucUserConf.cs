using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace fotoStudio
{
    public partial class ucUserConf : UserControl
    {
        MySqlConnection conn = new MySqlConnection(clsConnection.connection);
        public ucUserConf()
        {
            InitializeComponent();
        }

        public void setUsernames()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            try
            {
                int num = 0;
                conn.Open();
                string getUsername = "SELECT username, (SELECT count(*) FROM `user`) as countt FROM `user` GROUP BY username;";
                MySqlCommand cmdGetUsername = new MySqlCommand(getUsername, conn);
                MySqlDataReader rdr = cmdGetUsername.ExecuteReader();
                rdr.Close();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmdGetUsername);
                da.Fill(ds);
                num = Convert.ToInt32(ds.Tables[0].Rows[0]["countt"]);
                for (int i = 0; i < num; i++) //Izvrsena optimizacija
                {
                    collection.Add(accountInfo.Decrypt(ds.Tables[0].Rows[i]["Username"].ToString()));
                }
                tbUsername.AutoCompleteMode = AutoCompleteMode.Suggest;
                tbUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbUsername.AutoCompleteCustomSource = collection;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            conn.Close();
        }

        private void ucUserConf_Load(object sender, EventArgs e)
        {
            setUsernames();            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(tbChangePassword.Text != string.Empty)
            {
                accountInfo.ChangedPwd = tbChangePassword.Text;
            }
            else
            {
                accountInfo.ChangedPwd = accountInfo.Password;
            }
            if(tbChangeUsername.Text != string.Empty)
            {
                accountInfo.ChangedUsername = tbChangeUsername.Text;
            }
            else
            {
                accountInfo.ChangedUsername = tbUsername.Text;
            }
            string update = "UPDATE user SET username = @username, password = @password WHERE username=@username";
            MySqlCommand cmdUpdate = new MySqlCommand(update, conn);
            try
            {
                conn.Open();
                cmdUpdate.Parameters.AddWithValue("@username", accountInfo.Encrypt(accountInfo.ChangedUsername));
                cmdUpdate.Parameters.AddWithValue("@password", accountInfo.Encrypt(accountInfo.ChangedPwd));
                cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Update finished");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            conn.Close();
        }
    }
}
