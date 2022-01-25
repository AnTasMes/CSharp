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
    public partial class ucEditServices : UserControl
    {
        MySqlConnection conn = new MySqlConnection(clsConnection.connection);
        DataSet ds = new DataSet();
        int count = 0;
        public ucEditServices()
        {
            InitializeComponent();
            count++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validate = false;
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        errorProvider1.SetError(c, "Missing info");
                        errorProvider1.SetIconPadding(c, -20);
                        validate = false;
                    }
                    else
                    {
                        errorProvider1.SetError(c, "");
                        errorProvider1.SetIconPadding(c, -20);
                        validate = true;
                    }
                }
            }
            if (validation(validate) == true)
            {
                checkForService();
            }            
        }

        public void insertService()
        {
            try
            {
                string strInsert = "INSERT INTO `service` (`name`, `price`, `length`, `comm`, `info`) VALUES (@name, @price, @length, @comm, @info) ";
                MySqlCommand cmd = new MySqlCommand(strInsert, conn);
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.Parameters.AddWithValue("@price", tbPrice.Text);
                cmd.Parameters.AddWithValue("@length", tbLen.Text);
                cmd.Parameters.AddWithValue("@comm", tbComm.Text);
                cmd.Parameters.AddWithValue("@info", rtbInfo.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Service inserted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            conn.Close();
        }

        public void checkForService()
        {
            string strUpdate = "UPDATE `service` SET name=@name, comm=@comm, info=@info, price=@price, length=@length WHERE comm=@comm";
            string strCheck = "SELECT * FROM `service` WHERE comm=@comm";
            try
            {
                conn.Open();
                MySqlCommand cmdCheck = new MySqlCommand(strCheck, conn);
                cmdCheck.Parameters.AddWithValue("@comm", tbComm.Text);
                MySqlDataReader rdr = cmdCheck.ExecuteReader();
                if (rdr.HasRows) //provera da li postoji servis 
                {
                    rdr.Close();
                    MySqlCommand cmdUpdate = new MySqlCommand(strUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@name", tbName.Text);
                    cmdUpdate.Parameters.AddWithValue("@comm", tbComm.Text);
                    cmdUpdate.Parameters.AddWithValue("@info", rtbInfo.Text);
                    cmdUpdate.Parameters.AddWithValue("@price", tbPrice.Text);
                    cmdUpdate.Parameters.AddWithValue("@length", tbLen.Text);
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Service updated");
                }
                else
                {
                    rdr.Close();
                    insertService(); //Pozivanje insert metode ako ne postoji vec servis
                }
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
        }

        public bool validation(bool valid)
        {
            float parsedValue;
            if(!float.TryParse(tbPrice.Text, out parsedValue) && !float.TryParse(tbLen.Text, out parsedValue) && valid == true)
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;
        }
        // dodati u cb listu servisa i ispisati njihove vrednosti posle u textboxove.
        private void ucEditServices_Load(object sender, EventArgs e)
        {
            ds = getServices();
            fillComboBox(ds);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataSet dsService = new DataSet();
            string name, comm, info;
            float price, len;
            string slct = "SELECT * FROM `service` WHERE name=@name";
            if (count > 1)
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmdSlct = new MySqlCommand(slct, conn);
                    cmdSlct.Parameters.AddWithValue("@name", cbServices.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSlct);
                    da.Fill(dsService);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
                name = dsService.Tables[0].Rows[0]["name"].ToString();
                comm = dsService.Tables[0].Rows[0]["comm"].ToString();
                info = dsService.Tables[0].Rows[0]["info"].ToString();
                price = (float)dsService.Tables[0].Rows[0]["price"];
                len = (float)dsService.Tables[0].Rows[0]["length"];
                conn.Close();
                tbComm.Text = comm;
                tbName.Text = name;
                rtbInfo.Text = info;
                tbLen.Text = len.ToString();
                tbPrice.Text = price.ToString();
            }            
            count++;
        }

        public DataSet getServices()
        {
            DataSet dsServices = new DataSet();
            string strServices = "SELECT * FROM `service` WHERE 1";
            MySqlCommand cmdServices = new MySqlCommand(strServices, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmdServices);
            da.Fill(dsServices);
            return dsServices;
        }

        public void fillComboBox(DataSet ds)
        {
            cbServices.DataSource = ds.Tables[0].DefaultView;
            cbServices.DisplayMember = "name";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        public void clearText()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is RichTextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

        public void deleteService()
        {
            string strDelete = "DELETE FROM `service` WHERE `name`= @name";
            MySqlCommand cmdDelete = new MySqlCommand(strDelete, conn);
            if(MessageBox.Show("Are you sure you want to delete this service", "", MessageBoxButtons.YesNo) == DialogResult.Yes && cbServices.Text != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmdDelete.Parameters.AddWithValue("@name", cbServices.Text);
                    cmdDelete.ExecuteNonQuery();
                    MessageBox.Show("Service deleted");
                    clearText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteService();
        }
    }
}
