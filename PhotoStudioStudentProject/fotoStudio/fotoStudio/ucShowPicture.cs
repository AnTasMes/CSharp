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
using System.IO;

namespace fotoStudio
{
    public partial class ucShowPicture : UserControl
    {
        MySqlConnection conn = new MySqlConnection(clsConnection.connection);
        public ucShowPicture()
        {
            InitializeComponent();
        }

        public UserControl ParentControl { get; set; }
        //SELECT img FROM image JOIN selectedphotos ON image.uniqueUse=selectedphotos.uniqueUse WHERE image.username='AnTasMes' 
        private void ucShowPicture_Load(object sender, EventArgs e)
        {
            MySqlCommand cmdGetPicture = new MySqlCommand();
            byte[] images = null;
            btnDelete.Name = default;
            if(infoTransfer.table == "image")
            {
                string showPic = "SELECT img FROM image WHERE (username=@username or image.comm=@comm) and id=@id";
                try
                {
                    conn.Open();
                    cmdGetPicture = new MySqlCommand(showPic, conn);
                    cmdGetPicture.Parameters.AddWithValue("@id", clsAdmin.index[clsAdmin.counter]);
                    cmdGetPicture.Parameters.AddWithValue("@comm", infoTransfer.comm);
                    cmdGetPicture.Parameters.AddWithValue("@username", accountInfo.Encrypt(infoTransfer.username));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }
            if (infoTransfer.table == "selectedphotos")
            {
                string showPic = "SELECT img FROM image JOIN selectedphotos ON image.uniqueUse=selectedphotos.uniqueUse WHERE image.username=@username and selectedphotos.id=@id";
                try
                {
                    conn.Open();
                    cmdGetPicture = new MySqlCommand(showPic, conn);
                    cmdGetPicture.Parameters.AddWithValue("@username", accountInfo.Encrypt(infoTransfer.username));
                    cmdGetPicture.Parameters.AddWithValue("@id", clsAdmin.index[clsAdmin.counter]);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
            }

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
            btnDelete.Name = $"{clsAdmin.counter}";
            clsAdmin.counter++;            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure you want to delete this photo", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indexer = Convert.ToInt32(btnDelete.Name);
                string dlt = "";
                if(infoTransfer.table == "image") dlt = "DELETE FROM `image` WHERE `image`.`id` = @id";
                if (infoTransfer.table == "selectedphotos") dlt = "DELETE FROM `selectedphotos` WHERE `selectedphotos`.`id` = @id";
                try
                {
                    conn.Open();
                    MySqlCommand cmdDelete = new MySqlCommand(dlt, conn);
                    cmdDelete.Parameters.AddWithValue("@id", clsAdmin.index[indexer]);
                    cmdDelete.ExecuteNonQuery();
                    clsAdmin.isDeleted = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
                conn.Close();                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(infoTransfer.table == "selectedphotos")
            {
                DataSet ds = new DataSet();
                int indexer = Convert.ToInt32(btnDelete.Name);
                string uniqueUse, comment;
                string showComment = "SELECT comm, uniqueUse FROM selectedphotos WHERE id=@id";
                MySqlCommand cmdShowComment = new MySqlCommand(showComment, conn);
                cmdShowComment.Parameters.AddWithValue("@id", clsAdmin.index[indexer]);
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdShowComment);
                    da.Fill(ds);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}");
                }
                conn.Close();
                uniqueUse = ds.Tables[0].Rows[0]["uniqueUse"].ToString();
                comment = ds.Tables[0].Rows[0]["comm"].ToString();
                MessageBox.Show($"Picture name: {uniqueUse}\nUser comment: {comment}", "Info");
            }            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (infoTransfer.table == "selectedphotos")
            {
                Cursor.Current = Cursors.Hand;
            }            
        }
    }
}
