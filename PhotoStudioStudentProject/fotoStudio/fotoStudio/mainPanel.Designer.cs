namespace fotoStudio
{
    partial class mainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPanel));
            this.menu = new System.Windows.Forms.Panel();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.btnServices = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnPictures = new System.Windows.Forms.Button();
            this.tmrAnimator = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpServices = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tpPictures = new System.Windows.Forms.TabPage();
            this.rtbSlct = new System.Windows.Forms.RichTextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tpReservations = new System.Windows.Forms.TabPage();
            this.btnCheckReservation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.rtbBIll = new System.Windows.Forms.RichTextBox();
            this.tpUpload = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUniqueUse = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbComm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdUpload = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmrCheckForSelection = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpServices.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tpPictures.SuspendLayout();
            this.tpReservations.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpUpload.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.menu.Controls.Add(this.pbSettings);
            this.menu.Controls.Add(this.pbMinimize);
            this.menu.Controls.Add(this.pbClose);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 29);
            this.menu.TabIndex = 0;
            this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            // 
            // pbSettings
            // 
            this.pbSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbSettings.Image")));
            this.pbSettings.Location = new System.Drawing.Point(7, 2);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(24, 24);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSettings.TabIndex = 2;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pbSettings.MouseLeave += new System.EventHandler(this.pbSettings_MouseLeave);
            this.pbSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(766, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            this.pbClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbClose_MouseMove);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(741, 2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(25, 25);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 1;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            this.pbMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMinimize_MouseMove);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.pnlMenu.Controls.Add(this.pnlSelect);
            this.pnlMenu.Controls.Add(this.btnServices);
            this.pnlMenu.Controls.Add(this.pictureBox4);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnUpload);
            this.pnlMenu.Controls.Add(this.btnReservations);
            this.pnlMenu.Controls.Add(this.btnPictures);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 29);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(145, 421);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(205)))));
            this.pnlSelect.Location = new System.Drawing.Point(139, 86);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(12, 75);
            this.pnlSelect.TabIndex = 1;
            // 
            // btnServices
            // 
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnServices.Location = new System.Drawing.Point(0, 86);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(145, 75);
            this.btnServices.TabIndex = 0;
            this.btnServices.Text = "View Services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, -8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(127)))));
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(0, 382);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 39);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpload.Location = new System.Drawing.Point(0, 308);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(145, 75);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Picture Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Corbel", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReservations.Location = new System.Drawing.Point(0, 234);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(145, 75);
            this.btnReservations.TabIndex = 2;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnPictures
            // 
            this.btnPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPictures.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPictures.Location = new System.Drawing.Point(0, 160);
            this.btnPictures.Name = "btnPictures";
            this.btnPictures.Size = new System.Drawing.Size(145, 75);
            this.btnPictures.TabIndex = 1;
            this.btnPictures.Text = "Pictures";
            this.btnPictures.UseVisualStyleBackColor = true;
            this.btnPictures.Click += new System.EventHandler(this.btnPictures_Click);
            // 
            // tmrAnimator
            // 
            this.tmrAnimator.Interval = 10;
            this.tmrAnimator.Tick += new System.EventHandler(this.tmrAnimator_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpServices);
            this.tabControl1.Controls.Add(this.tpPictures);
            this.tabControl1.Controls.Add(this.tpReservations);
            this.tabControl1.Controls.Add(this.tpUpload);
            this.tabControl1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(138, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 456);
            this.tabControl1.TabIndex = 5;
            // 
            // tpServices
            // 
            this.tpServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.tpServices.Controls.Add(this.flowLayoutPanel1);
            this.tpServices.Location = new System.Drawing.Point(4, 24);
            this.tpServices.Name = "tpServices";
            this.tpServices.Padding = new System.Windows.Forms.Padding(3);
            this.tpServices.Size = new System.Drawing.Size(662, 428);
            this.tpServices.TabIndex = 0;
            this.tpServices.Text = "tabPage1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(656, 422);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(641, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sve detalje za prilozene usluge mozete videti klikom na dugme";
            // 
            // tpPictures
            // 
            this.tpPictures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.tpPictures.Controls.Add(this.rtbSlct);
            this.tpPictures.Controls.Add(this.btnSelect);
            this.tpPictures.Controls.Add(this.flowLayoutPanel2);
            this.tpPictures.Controls.Add(this.panel4);
            this.tpPictures.Location = new System.Drawing.Point(4, 24);
            this.tpPictures.Name = "tpPictures";
            this.tpPictures.Padding = new System.Windows.Forms.Padding(3);
            this.tpPictures.Size = new System.Drawing.Size(662, 428);
            this.tpPictures.TabIndex = 1;
            this.tpPictures.Text = "tabPage2";
            // 
            // rtbSlct
            // 
            this.rtbSlct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.rtbSlct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSlct.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSlct.ForeColor = System.Drawing.Color.Transparent;
            this.rtbSlct.Location = new System.Drawing.Point(516, 3);
            this.rtbSlct.Name = "rtbSlct";
            this.rtbSlct.ReadOnly = true;
            this.rtbSlct.Size = new System.Drawing.Size(136, 383);
            this.rtbSlct.TabIndex = 0;
            this.rtbSlct.Text = resources.GetString("rtbSlct.Text");
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(9, 392);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(643, 27);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select pictures";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(507, 383);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(656, 40);
            this.panel4.TabIndex = 0;
            // 
            // tpReservations
            // 
            this.tpReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.tpReservations.Controls.Add(this.btnCheckReservation);
            this.tpReservations.Controls.Add(this.label7);
            this.tpReservations.Controls.Add(this.dtpDate);
            this.tpReservations.Controls.Add(this.label6);
            this.tpReservations.Controls.Add(this.label2);
            this.tpReservations.Controls.Add(this.tbEmail);
            this.tpReservations.Controls.Add(this.cbServices);
            this.tpReservations.Controls.Add(this.panel2);
            this.tpReservations.Location = new System.Drawing.Point(4, 24);
            this.tpReservations.Name = "tpReservations";
            this.tpReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservations.Size = new System.Drawing.Size(662, 428);
            this.tpReservations.TabIndex = 2;
            this.tpReservations.Text = "tabPage3";
            this.tpReservations.Click += new System.EventHandler(this.tpReservations_Click);
            // 
            // btnCheckReservation
            // 
            this.btnCheckReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckReservation.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckReservation.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckReservation.Location = new System.Drawing.Point(30, 304);
            this.btnCheckReservation.Name = "btnCheckReservation";
            this.btnCheckReservation.Size = new System.Drawing.Size(294, 96);
            this.btnCheckReservation.TabIndex = 7;
            this.btnCheckReservation.Text = "Show reservation";
            this.btnCheckReservation.UseVisualStyleBackColor = false;
            this.btnCheckReservation.Click += new System.EventHandler(this.btnCheckReservation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(36, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.AllowDrop = true;
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDate.Location = new System.Drawing.Point(36, 237);
            this.dtpDate.MinDate = new System.DateTime(2020, 4, 5, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(255, 25);
            this.dtpDate.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(36, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Service:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(36, 88);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(255, 23);
            this.tbEmail.TabIndex = 3;
            // 
            // cbServices
            // 
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(36, 162);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(255, 23);
            this.cbServices.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.btnMakeReservation);
            this.panel2.Controls.Add(this.rtbBIll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(330, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 422);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.btnMakeReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReservation.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReservation.ForeColor = System.Drawing.Color.Transparent;
            this.btnMakeReservation.Location = new System.Drawing.Point(12, 301);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(294, 96);
            this.btnMakeReservation.TabIndex = 5;
            this.btnMakeReservation.Text = "Send reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = false;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // rtbBIll
            // 
            this.rtbBIll.Enabled = false;
            this.rtbBIll.Location = new System.Drawing.Point(12, 9);
            this.rtbBIll.Name = "rtbBIll";
            this.rtbBIll.ReadOnly = true;
            this.rtbBIll.Size = new System.Drawing.Size(294, 280);
            this.rtbBIll.TabIndex = 6;
            this.rtbBIll.Text = "";
            // 
            // tpUpload
            // 
            this.tpUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.tpUpload.Controls.Add(this.panel1);
            this.tpUpload.Controls.Add(this.button1);
            this.tpUpload.Controls.Add(this.label1);
            this.tpUpload.Controls.Add(this.pictureBox1);
            this.tpUpload.Controls.Add(this.btnBrowse);
            this.tpUpload.Location = new System.Drawing.Point(4, 24);
            this.tpUpload.Name = "tpUpload";
            this.tpUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpload.Size = new System.Drawing.Size(662, 428);
            this.tpUpload.TabIndex = 3;
            this.tpUpload.Text = "tabPage4";
            this.tpUpload.Click += new System.EventHandler(this.tpUpload_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnGoto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbUniqueUse);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.cbComm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(330, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 422);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // btnGoto
            // 
            this.btnGoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoto.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoto.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoto.Location = new System.Drawing.Point(201, 9);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(115, 22);
            this.btnGoto.TabIndex = 13;
            this.btnGoto.Text = "Go to admin panel";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(8, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Name:";
            // 
            // tbUniqueUse
            // 
            this.tbUniqueUse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbUniqueUse.Location = new System.Drawing.Point(12, 164);
            this.tbUniqueUse.Name = "tbUniqueUse";
            this.tbUniqueUse.Size = new System.Drawing.Size(279, 23);
            this.tbUniqueUse.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(12, 248);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 22);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear comment:";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbComm
            // 
            this.cbComm.FormattingEnabled = true;
            this.cbComm.Location = new System.Drawing.Point(12, 219);
            this.cbComm.Name = "cbComm";
            this.cbComm.Size = new System.Drawing.Size(279, 23);
            this.cbComm.TabIndex = 9;
            this.cbComm.Click += new System.EventHandler(this.cbComm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(12, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(294, 96);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Upload picture";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comment:";
            // 
            // tbUsername
            // 
            this.tbUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbUsername.Location = new System.Drawing.Point(12, 107);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(279, 23);
            this.tbUsername.TabIndex = 4;
            this.tbUsername.Click += new System.EventHandler(this.tbUsername_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(201, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Small picture preview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.pictureBox1.Location = new System.Drawing.Point(22, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Location = new System.Drawing.Point(22, 304);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(294, 96);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse pictures";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdUpload
            // 
            this.ofdUpload.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tmrCheckForSelection
            // 
            this.tmrCheckForSelection.Tick += new System.EventHandler(this.tmrCheckForSelection_Tick);
            // 
            // mainPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainPanel";
            this.Load += new System.EventHandler(this.mainPanel_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpServices.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tpPictures.ResumeLayout(false);
            this.tpReservations.ResumeLayout(false);
            this.tpReservations.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tpUpload.ResumeLayout(false);
            this.tpUpload.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnPictures;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer tmrAnimator;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpServices;
        private System.Windows.Forms.TabPage tpPictures;
        private System.Windows.Forms.TabPage tpReservations;
        private System.Windows.Forms.TabPage tpUpload;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbComm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.RichTextBox rtbBIll;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUniqueUse;
        private System.Windows.Forms.Button btnCheckReservation;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.Timer tmrCheckForSelection;
        private System.Windows.Forms.RichTextBox rtbSlct;
    }
}