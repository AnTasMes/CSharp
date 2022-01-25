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
    public partial class galleryPictures : UserControl
    {
        MySqlConnection conn = new MySqlConnection(clsConnection.connection);
        DataSet imageDS = new DataSet();
        public galleryPictures()
        {
            InitializeComponent();
            pictureBox1.Padding = new Padding(2);
        }

        private void galleryPictures_Load(object sender, EventArgs e)
        {
            btnAddComment.Name = default;
            string showPic = "SELECT img, uniqueUse FROM image WHERE username=@username and id=@id";
            byte[] images = null;
            try
            {
                conn.Open();
                MySqlCommand cmdGetPicture = new MySqlCommand(showPic, conn);
                cmdGetPicture.Parameters.AddWithValue("@id", accountInfo.index[accountInfo.counter]);
                cmdGetPicture.Parameters.AddWithValue("@username", accountInfo.Encrypt(accountInfo.Username));
                MySqlDataReader imageDR = cmdGetPicture.ExecuteReader();
                if (imageDR.HasRows)
                {
                    imageDR.Close();                    
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
            btnAddComment.Name = $"{accountInfo.counter}";
            accountInfo.counter++;
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            frmComment comment = new frmComment();
            if (comment.ShowDialog() == DialogResult.OK)
            {                
                int indexer = Convert.ToInt32(btnAddComment.Name);
                infoTransfer.FullComm[indexer] = infoTransfer.PhotoComment;
                accountInfo.ImageIndex[indexer] = imageDS.Tables[0].Rows[0]["uniqueUse"].ToString();
                MessageBox.Show(accountInfo.ImageIndex[indexer]);
                pictureBox1.BackgroundImageLayout = ImageLayout.Center;
                pictureBox1.BackColor = Color.Red;
                pictureBox1.Padding = new Padding(2);
                infoTransfer.isSelected = true;
                infoTransfer.slcCount++;
            }
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            int indexer = Convert.ToInt32(btnAddComment.Name);
            pictureBox1.BackColor = default;
            infoTransfer.FullComm[indexer] = string.Empty;
            infoTransfer.isSelected = false;
            infoTransfer.slcCount--;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
