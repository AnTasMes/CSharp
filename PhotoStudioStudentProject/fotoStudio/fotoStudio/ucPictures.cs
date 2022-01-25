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

namespace fotoStudio
{
    public partial class ucPictures : UserControl
    {
        MySqlConnection conn = new MySqlConnection(clsConnection.connection);
        public ucPictures()
        {
            InitializeComponent();
            checkForDeletion.Start();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showUCs();          
        }

        public void showUCs()
        {
            clsAdmin.counter = 0;
            foreach (UserControl uc in flowLayoutPanel1.Controls)
            {
                uc.Visible = false;
            }
            if (string.IsNullOrEmpty(tbUsername.Text) && string.IsNullOrEmpty(tbComm.Text))
            {
                MessageBox.Show("A field must be filled");
            }
            else
            {
                infoTransfer.username = tbUsername.Text;
                infoTransfer.comm = tbComm.Text;
                int num = picCount();
                for (int i = 0; i < num; i++)
                {
                    ucShowPicture showPicture = new ucShowPicture();
                    flowLayoutPanel1.Controls.Add(showPicture);
                }
            }
        }

        public int picCount()
        {
            int cnt = 0;
            infoTransfer.table = "";
            string count = "";
            if(string.IsNullOrEmpty(cbChoose.Text)) //default vrednost je podesena na sve
            {
                count = $"SELECT id, (SELECT count(*) FROM image WHERE username=@username or image.comm=@comm) as ct" +
                $" FROM image WHERE username=@username or image.comm=@comm";
                infoTransfer.table = "image";
                cbChoose.Text = "All";
            }
            else if (cbChoose.Text == "All")
            {
                count = $"SELECT id, (SELECT count(*) FROM image WHERE username=@username or image.comm=@comm) as ct" +
                $" FROM image WHERE username=@username or image.comm=@comm";
                infoTransfer.table = "image";
            }
            else if(cbChoose.Text == "Selected")
            {
                count = $"SELECT id, (SELECT count(*) FROM selectedphotos WHERE username=@username) as ct" +
                $" FROM selectedphotos WHERE username=@username";
                infoTransfer.table = "selectedphotos";
            }
            conn.Open();
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(count, conn);
            cmd.Parameters.AddWithValue("@username", accountInfo.Encrypt(tbUsername.Text));
            cmd.Parameters.AddWithValue("@comm", accountInfo.Encrypt(tbComm.Text));
            MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
            if (reader.HasRows)
            {
                reader.Close();
                da2.Fill(ds);
                cnt = Convert.ToInt32(ds.Tables[0].Rows[0]["ct"]);
                for (int i = 0; i < cnt; i++)
                {
                    clsAdmin.index[i] = Convert.ToInt32(ds.Tables[0].Rows[i]["id"]);
                }
            }
            else
            {
                MessageBox.Show("No Pictures");
            }
            conn.Close();
            return cnt;
        }

        private void checkForDeletion_Tick(object sender, EventArgs e)
        {
            if(clsAdmin.isDeleted == true)
            {
                showUCs();
                clsAdmin.isDeleted = false;
            }
        }

        private void ucPictures_Load(object sender, EventArgs e)
        {
            setUsernames();
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

        private void cbChoose_SelectedIndexChanged(object sender, EventArgs e) //Cisto mala validacija
        {
            if(cbChoose.Text == "Selected")
            {
                tbComm.Text = string.Empty;
                tbComm.Enabled = false;
            }
            if(cbChoose.Text == "All")
            {
                tbComm.Enabled = true;
            }
        }
    }
}
