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
using System.Net.Mail;

namespace fotoStudio
{
    public partial class mainPanel : Form
    { //U admin panelu promeniti sofija u soce.prokic i sifru staviti Soche123
        MySqlConnection conn = new MySqlConnection(clsConnection.connection);
        public mainPanel()
        {
            InitializeComponent();
            DataSet ds = getServices();
            //DataSet imageDS = imageSet();
            createButtons(ds);
            //if (picturesExist == true) { createPBs(imageDS); }
            fillComboBox(ds);            
            conn.Close();
            dtpDate.MinDate = DateTime.Now;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pbSettings.BackColor = Color.FromArgb(108, 122, 137);
            Cursor.Current = Cursors.Hand;
        }

        private void pbSettings_MouseLeave(object sender, EventArgs e)
        {
            pbSettings.BackColor = default;
            Cursor.Current = Cursors.Default;
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            pbMinimize.BackColor = Color.FromArgb(108, 122, 137);
            Cursor.Current = Cursors.Hand;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackColor = default;
            Cursor.Current = default;
        }

        private void pbClose_MouseMove(object sender, MouseEventArgs e)
        {
            pbClose.BackColor = Color.Red;
            Cursor.Current = Cursors.Hand;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = default;
            Cursor.Current = default;
        }

        private void mainPanel_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.role == "User")
            {
                btnUpload.Enabled = false;
                btnUpload.Visible = false;
                tabControl1.TabPages.Remove(tpUpload);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            frm1 f1 = new frm1();
            tmrAnimator.Start();
            f1.Show();
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

        private void btnServices_Click(object sender, EventArgs e)
        {
            pnlSelect.Height = btnServices.Height;
            pnlSelect.Top = btnServices.Top;
            tabControl1.SelectedIndex = 0;
            tmrCheckForSelection.Stop();
        }

        private void btnPictures_Click(object sender, EventArgs e) // Create pictureBoxes
        {
            pnlSelect.Height = btnPictures.Height;
            pnlSelect.Top = btnPictures.Top;
            tabControl1.SelectedIndex = 1;
            btnSelect.Enabled = true;
            tmrCheckForSelection.Start();
            showUCs();
        }

        public void showUCs()
        {
            accountInfo.counter = 0;
            foreach (UserControl uc in flowLayoutPanel2.Controls)
            {
                uc.Visible = false;
            }            
            int num = picCount();
            for (int i = 0; i < num; i++)
            {
                galleryPictures gp = new galleryPictures();
                flowLayoutPanel2.Controls.Add(gp);
            }
        }

        public int picCount()
        {
            int cnt = 0;
            conn.Open();
            DataSet ds = new DataSet();
            string count = "SELECT id, (SELECT count(*) FROM `image` WHERE username=@username) as ct" +
                " FROM `image` WHERE username=@username";
            MySqlCommand cmd = new MySqlCommand(count, conn);
            cmd.Parameters.AddWithValue("@username", accountInfo.Encrypt(accountInfo.Username));
            MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
            if (reader.HasRows)
            {
                reader.Close();
                da2.Fill(ds);
                cnt = Convert.ToInt32(ds.Tables[0].Rows[0]["ct"]);
                for (int i = 0; i < cnt; i++)
                {
                    accountInfo.index[i] = Convert.ToInt32(ds.Tables[0].Rows[i]["id"]);
                }
            }
            else
            {
                MessageBox.Show("No Pictures");
            }
            conn.Close();
            return cnt;
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            pnlSelect.Height = btnReservations.Height;
            pnlSelect.Top = btnReservations.Top;
            tabControl1.SelectedIndex = 2;
            tmrCheckForSelection.Stop();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {            
            pnlSelect.Height = btnUpload.Height;
            pnlSelect.Top = btnUpload.Top;
            getUsernameList();
            tabControl1.SelectedIndex = 3;            
            moveLeft();
            tmrCheckForSelection.Stop();
        }

        public void getUsernameList() //pretraga korisnika zbog suggest opcije za admina
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
            catch (Exception)
            {
                throw;
            }
            conn.Close();
        }
        
        public DataSet getServices()
        {
            conn.Open();
            string _getSString = "SELECT name, info, price, length, comm, (SELECT count(*) from `service`) as `count` " +
                "FROM `service` GROUP BY name, info, price, length, comm";
            MySqlCommand cmdServices = new MySqlCommand(_getSString, conn);
            MySqlDataAdapter daServices = new MySqlDataAdapter(cmdServices);
            DataSet dsServices = new DataSet();
            daServices.Fill(dsServices);
            conn.Close();
            return dsServices;            
        }

        Button addButton(int i, DataSet ds, int number) 
        {
            float[] length = new float[number];
            string[] name = new string[number];
            string[] comm = new string[number];
            string[] info = new string[number];
            float[] price = new float[number];
            info[i] = ds.Tables[0].Rows[i]["info"].ToString();
            name[i] = ds.Tables[0].Rows[i]["name"].ToString();
            comm[i] = ds.Tables[0].Rows[i]["comm"].ToString();
            price[i] = (float)ds.Tables[0].Rows[i]["price"];
            length[i] = (float)ds.Tables[0].Rows[i]["length"];

            Button btn = new Button();               
            btn.Name = $"button{i}".ToString();
            btn.Text = name[i];
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Corbel", 24, FontStyle.Regular);
            btn.AutoSize = true;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Margin = new Padding(5);

            btn.Click += (s, e) => 
            { infoTransfer.comm = comm[i];
                infoTransfer.price = price[i];
                infoTransfer.length = length[i];
                infoTransfer.info = info[i];
                infoForm iForm = new infoForm();
                if(iForm.ShowDialog() == DialogResult.OK)
                {
                    iForm.Close();
                }
            };
            return btn;
        }

        public void createButtons(DataSet ds)
        {
            Int32 number;
            number = Convert.ToInt32(ds.Tables[0].Rows[0]["count"]);
            for (int i=0; i<number; i++)
            {                
                Button btn = addButton(i, ds, number);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        // ---- PICTURE UPLOAD SECTION ---- //

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            moveLeft();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg Files(*.jpg)|*.jpg|png Files(*.png)|*.png";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                infoTransfer.picturePath = openFileDialog.FileName.ToString();
                pictureBox1.ImageLocation = infoTransfer.picturePath;
                pictureBox1.BackColor = default;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool accounExist = false;
            byte[] images = null;
            moveRight();
            if (!string.IsNullOrEmpty(infoTransfer.picturePath))
            {
                FileStream fileStream = new FileStream(infoTransfer.picturePath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                images = binaryReader.ReadBytes((int)fileStream.Length);
                try
                {
                    conn.Open();
                    infoTransfer.username = tbUsername.Text;
                    infoTransfer.comm = cbComm.Text;
                    accounExist = accountCheck();
                    if (accounExist == true)
                    {
                        string insertString = "INSERT INTO `image` (img, comm, username, uniqueUse) VALUES (@image, @comm, @username, @uniqueUse);";
                        MySqlCommand cmdImageInsert = new MySqlCommand(insertString, conn);
                        cmdImageInsert.Parameters.AddWithValue("@comm", infoTransfer.comm);
                        cmdImageInsert.Parameters.AddWithValue("@uniqueUse", tbUniqueUse.Text);
                        cmdImageInsert.Parameters.AddWithValue("@username", accountInfo.Encrypt(infoTransfer.username));
                        cmdImageInsert.Parameters.AddWithValue("@image", images);
                        cmdImageInsert.ExecuteNonQuery();
                        MessageBox.Show("Upload successful");
                        pictureBox1.Image = null;
                        pictureBox1.BackColor = Color.FromArgb(96, 109, 118);
                        infoTransfer.picturePath = string.Empty;
                        moveLeft();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while uploading a photo: {ex}");
                }
            }   
            else
            {
                MessageBox.Show("Choose a photo");
            }
        }

        public bool accountCheck()
        {
            bool acExist = false;
            string checkString = "SELECT username FROM `user` WHERE username = @username";
            MySqlCommand cmdCheck = new MySqlCommand(checkString, conn);
            try
            {
                cmdCheck.Parameters.AddWithValue("@username", accountInfo.Encrypt(infoTransfer.username));
                MySqlDataReader dr = cmdCheck.ExecuteReader();
                if (dr.HasRows)
                {
                    acExist = true;
                    errorProvider1.SetError(tbUsername, "");
                }
                else
                {                    
                    errorProvider1.SetError(tbUsername, "Username does not exist");
                    errorProvider1.SetIconPadding(tbUsername, -20);
                    acExist = false;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            return acExist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoTransfer.picturePath = string.Empty;
            pictureBox1.Image = null;
            pictureBox1.BackColor = Color.FromArgb(96, 109, 118);
            moveLeft();
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            moveRight();
        }

        private void tbComment_Click(object sender, EventArgs e)
        {
            moveRight();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            moveLeft();
        }

        public void moveRight() //Napravljena univerazalna metoda za svaki panel sa promenom boje
        {
            foreach(TabPage tbp in tabControl1.TabPages) //Pretrazujemo prvo postojece tabove
            {
                foreach(Control c in tbp.Controls) //Onda pretrazujemo sve kontrole u tabovima
                {
                    if (c is Panel) //Pregledamo da li je kontrola panel
                    {
                        c.BackColor = Color.FromArgb(246, 146, 114); //Svakom takvom panelu menjamo boju
                    }
                } //Ovo ogranicava tabove na po jedan panel ali za ovakav vid aplikacije to je sasvim dovoljno
                tbp.BackColor = Color.FromArgb(35, 46, 49); 
            }
            //panel1.BackColor = Color.FromArgb(246, 146, 114);            
            btnSave.Enabled = true;
        }

        public void moveLeft() //Napravljena univerzalna metoda za svaki panel sa promenom boje
        {
            foreach (TabPage tbp in tabControl1.TabPages)
            {
                foreach (Control c in tbp.Controls)
                {
                    if (c is Panel)
                    {
                        c.BackColor = Color.FromArgb(35, 46, 49);
                    }
                }
                tbp.BackColor = Color.FromArgb(246, 146, 114);
            }            
            btnSave.Enabled = false;
        }

        public void fillComboBox(DataSet ds)
        {
            cbComm.DataSource = ds.Tables[0].DefaultView;
            cbServices.DataSource = ds.Tables[0].DefaultView;
            cbComm.DisplayMember = "comm";
            cbServices.DisplayMember = "name";
        }

        private void cbComm_Click(object sender, EventArgs e)
        {
            moveRight();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbComm.Text = string.Empty;
        }

        // ---- PICTURE UPLOAD SECTION END ---- //


        // ---- PICTURE GET SECTION ----- //

        //int niz = 0;
        ////int imageIndex = 0;
        //PictureBox getPictureBox(int i, DataSet ds, int count, bool[] selected, string[] use)
        //{
        //    byte[] bytes = null;            
        //    bytes = (byte[])ds.Tables[0].Rows[i]["img"];
        //    MemoryStream ms = new MemoryStream(bytes);
        //    Image img = Image.FromStream(ms);
        //    PictureBox pb = new PictureBox();
        //    pb.Name = $"pb{i}";
        //    pb.BackColor = Color.Black;
        //    pb.Padding = new Padding(2);
        //    pb.Margin = new Padding(4, 10, 4, 0);
        //    pb.BorderStyle = BorderStyle.FixedSingle;
        //    pb.SizeMode = PictureBoxSizeMode.AutoSize;
        //    pb.BackgroundImageLayout = ImageLayout.Center;                       
        //    pb.Image = img;
        //    pb.Click += (s, e) =>
        //    {                
        //        accountInfo.ImageIndex[niz] = ds.Tables[0].Rows[i]["uniqueUse"].ToString();
        //        selected[i] =  selectPB(pb, selected[i]);
                
        //        if(niz<=0)
        //        {
        //            btnSelect.Enabled = false;
        //        }
        //        else
        //        {
        //            btnSelect.Enabled = true;
        //        }
        //    };
        //    return pb;
        //}
        //bool[] selected = new bool[100];
        //public void createPBs(DataSet ds)
        //{
        //    Int32 count;
        //    count = Convert.ToInt32(ds.Tables[0].Rows[0]["countt"]);
        //    string[] use = new string[count];
        //    for (int i=0; i<count; i++)
        //    {
        //        use[i] = ds.Tables[0].Rows[i]["uniqueUse"].ToString();
                
        //        PictureBox pb = getPictureBox(i, ds, count, selected, use);                
        //        flowLayoutPanel2.Controls.Add(pb);
        //    }
        //}
        //bool picturesExist = false;
        //public DataSet imageSet()
        //{
        //    DataSet dsServices = new DataSet();
        //    try
        //    {
        //        conn.Open();
        //        string _getSString = "SELECT img, image.username, image.uniqueUse," +
        //            "(SELECT count(*) FROM image WHERE username = @username) as countt from image " +
        //            "JOIN user on user.username=image.username " +
        //            "WHERE user.username=@username ";                
        //        MySqlCommand cmdServices = new MySqlCommand(_getSString, conn);
        //        cmdServices.Parameters.AddWithValue("@username", accountInfo.Encrypt(accountInfo.Username));
        //        MySqlDataReader dr = cmdServices.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            dr.Close();
        //            MySqlDataAdapter daServices = new MySqlDataAdapter(cmdServices);
        //            daServices.Fill(dsServices);
        //            picturesExist = true;
        //        } 
        //        else
        //        {
        //            picturesExist = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex}");
        //    }
        //    conn.Close();
        //    return dsServices;
        //} 
        
        //public bool selectPB(PictureBox pb, bool selected) //Ovom metodom pictureBox funkcionise kao checkbox sada
        //{
        //    switch (selected)
        //    {
        //        case false:
        //            pb.BackgroundImageLayout = ImageLayout.Center;
        //            pb.BackColor = Color.Red;
        //            pb.Padding = new Padding(2);
        //            selected = true;
        //            niz++;
        //            //imageIsSelected++;
        //            break;
        //        case true:
        //            pb.BackgroundImageLayout = ImageLayout.Center;
        //            pb.BackColor = Color.Black;
        //            pb.Padding = new Padding(2);
        //            selected = false;
        //            niz--;
        //            //imageIsSelected--;
        //            break;
        //    }
        //    return selected;
        //}

        // ---- PICTURE GET SECTION END ---- //

        private void panel1_Click(object sender, EventArgs e)
        {
            moveRight();
        }

        private void tpUpload_Click(object sender, EventArgs e)
        {
            moveLeft();
        }

        // ---- RESERVATION SECTION ---- //

        private void panel2_Click(object sender, EventArgs e)
        {
            moveRight();
        }

        private void tpReservations_Click(object sender, EventArgs e)
        {
            moveLeft();
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {            
            foreach(Control c in tpReservations.Controls)
            {
                if(c is TextBox)
                {
                    if(string.IsNullOrEmpty(c.Text))
                    {
                        errorProvider1.SetError(c, "Polje mora biti popunjeno");
                        errorProvider1.SetIconPadding(c, -20);
                    }
                    else
                    {
                        errorProvider1.SetError(c, "");
                        checkDate();
                    }
                }
            }                      
        }

        public void insertReservation(string username, string email, string serviceName, DateTime date)
        {
            string inputString = "INSERT INTO `reservation` (`username`, `serviceName`, `date`, `email`) " +
                "VALUES (@username, @serviceName, @date, @email)";
            MySqlCommand cmdInput = new MySqlCommand(inputString, conn);
            try
            {
                conn.Open();
                cmdInput.Parameters.AddWithValue("@username", username);
                cmdInput.Parameters.AddWithValue("@serviceName", serviceName);
                cmdInput.Parameters.AddWithValue("@date", date);
                cmdInput.Parameters.AddWithValue("@email", email);
                cmdInput.ExecuteNonQuery();
                conn.Close();
                sendMail(email, username, serviceName, date);
                MessageBox.Show("Reservation made");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            conn.Close();
        }
        int i = 0;
        public void checkDate() 
        {
            
            string checkDateString = "SELECT date FROM reservation WHERE date = @date";
            MySqlCommand cmdCheckDate = new MySqlCommand(checkDateString, conn);
            try
            {
                conn.Open();
                cmdCheckDate.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                MySqlDataReader rdr = cmdCheckDate.ExecuteReader();
                if(rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        i++;
                        if(i>1) //Dan moze da se popuni dva puta maksimum
                        {
                            MessageBox.Show("Ovaj dan je vec popunjen");
                            break;
                        }
                        else
                        {
                            rdr.Close();
                            string username = accountInfo.Encrypt(accountInfo.Username);
                            string email = tbEmail.Text;
                            string serviceName = cbServices.Text;
                            DateTime date = dtpDate.Value.Date;
                            conn.Close();
                            insertReservation(username, email, serviceName, date);
                            break;
                        }
                    }
                }
                else
                {
                    rdr.Close();
                    string username = accountInfo.Encrypt(accountInfo.Username);
                    string email = tbEmail.Text;
                    string serviceName = cbServices.Text;
                    DateTime date = dtpDate.Value.Date;
                    conn.Close();
                    insertReservation(username, email, serviceName, date);
                }
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
        }

        public void sendMail(string email, string username, string serviceName, DateTime date)
        {
            DataSet ds = new DataSet();            
            ds = getInfo(); //Dobijamo informacije o servisu
            string num = ds.Tables[0].Rows[0]["c_num"].ToString();
            string c_mail = ds.Tables[0].Rows[0]["email"].ToString();
            string price = ds.Tables[0].Rows[0]["price"].ToString();
            string length = ds.Tables[0].Rows[0]["length"].ToString();
            try
            {
                var mail = new MailMessage();
                var smtpServer = new SmtpClient("smtp.gmail.com", 587);//google smtp klijent port za slanje mejla

                smtpServer.UseDefaultCredentials = false;
                smtpServer.Credentials = new System.Net.NetworkCredential("akitasevski113@gmail.com", "159763248");//ko salje
                smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;//metoda slanja
                smtpServer.EnableSsl = true;//ssl zastita

                mail.From = new MailAddress("akitasevski113@gmail.com");//ko salje
                mail.To.Add(email);//kome
                mail.Subject = "Rezervacija";//sta
                mail.IsBodyHtml = true;//html ispis u mejlu


                //Info o korisniku
                string clientInfo = "<th>" +
                                    "<h1>Your reservation:</h1>" +
                                    "<p>AnTas photo studio</p>" +
                                    "<br>" +
                                    $"<p> Username: {accountInfo.Decrypt(username)}</p>" +
                                    $"<p> Email: {email}</p>" +
                                    "<hr>" +
                                    $"<p> Selected service: {serviceName}</p>" +
                                    $"<p> Date and time of the reservation: {date}</p>" +
                                    "<p> </p>" +
                                    $"<p> Time needed to finish the project: {length}h</p>" +
                                    "<br>" +
                                    $"<p> Price: {price}e</p>" +
                                    "<hr>" +
                                    $"<p> Contact number: {num}</p>" +
                                    $"<p> Contact Email: {c_mail}</p>" +
                                    $"<p> Current date: {DateTime.Now}</p>" +
                                    "<hr>" +
                                    "</th>" +
                                    " </table> ";

                //Bottom Calculation Value.

                mail.Body = clientInfo;
                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }

        // ---- RESERVATION SECTION END ---- //

        // ---- PICTURE SELECTION ---- //

        private void btnSelect_Click(object sender, EventArgs e)
        {
            conn.Open();
            bool isSent = false;
            int ins = 0;
            foreach(String s in infoTransfer.FullComm)
            {
                if(!string.IsNullOrEmpty(s))
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        string selectedPhotos = "INSERT INTO `selectedphotos` (`username`, `uniqueUse`, `comm`) VALUES (@username, @uniqueUse, @comm) ";
                        MySqlCommand cmdSelPhotos = new MySqlCommand(selectedPhotos, conn);
                        cmdSelPhotos.Parameters.AddWithValue("@username", accountInfo.Encrypt(accountInfo.Username));
                        cmdSelPhotos.Parameters.AddWithValue("@uniqueUse", accountInfo.ImageIndex[ins]);
                        cmdSelPhotos.Parameters.AddWithValue("@comm", infoTransfer.FullComm[ins]);
                        try
                        {                            
                            cmdSelPhotos.ExecuteNonQuery();
                            isSent = true;
                        }
                        catch (Exception ex)
                        {
                            isSent = false;
                            MessageBox.Show($"Error: {ex}");
                            break;
                        }
                    }                    
                }
                ins++;
            }
            conn.Close();
            if (isSent == true)
                {
                    MessageBox.Show("Your selected photos were sent");
                }
        }

        // ----- PICTURE SELECTION END ----- //

        public DataSet getInfo()
        {
            DataSet ds = new DataSet();
            string getAll = "SELECT service.length, gen_info.c_num, service.price, gen_info.email " +
                "FROM `service`, `gen_info` WHERE service.name = @name";
            MySqlCommand cmd = new MySqlCommand(getAll, conn);
            cmd.Parameters.AddWithValue("@name", cbServices.Text);
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            conn.Close();
            return ds;
        }

        private void btnCheckReservation_Click(object sender, EventArgs e)
        {
            moveLeft();
            DataSet ds = new DataSet();
            ds = getInfo();
            string num = ds.Tables[0].Rows[0]["c_num"].ToString();
            string mail = ds.Tables[0].Rows[0]["email"].ToString();
            string price = ds.Tables[0].Rows[0]["price"].ToString();            
            string length = ds.Tables[0].Rows[0]["length"].ToString();
            
            // ---- TEXT FORMAT ---- //

            rtbBIll.Text = $"AnTas photo studio:\n\nUsername: {accountInfo.Username}\n" +
                $"Email: {tbEmail.Text}\n";
            rtbBIll.Text += "_____________________________________________\n"; //spacer
            rtbBIll.Text += $"Selected service: {cbServices.Text}\nDate and time of the reservation:\n{dtpDate.Value.Date}\n" +
                $"Time needed to finish the project: {length}\n\nPrice: {price}\n";
            rtbBIll.Text += "_____________________________________________\n"; //spacer
            rtbBIll.Text += $"Contact number: {num}\nContact Email: {mail}\n" +
                $"Current date: {DateTime.Now}"; //spacer

            // ---- TEXT FORMAT ---- //
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            adminPanel adm = new adminPanel();
            adm.ShowDialog();
        }

        private void tmrCheckForSelection_Tick(object sender, EventArgs e)
        {
            if(infoTransfer.isSelected == false)
            {
                btnSelect.Enabled = false;
                printRtb();
            }
            else
            {
                btnSelect.Enabled = true;
                printRtb();
            }
        }

        public void printRtb()
        {
            rtbSlct.Text = "------------------------------" +
                            $"Selected photos: {infoTransfer.slcCount}\n" +
                            "------------------------------" +
                            "Add a comment to select a photo.\n" +
                            "Removing the comment will deselect the photo.\n" +
                            "------------------------------" +
                            "You cannot remove the already uploaded selections";
        }



    }
}
