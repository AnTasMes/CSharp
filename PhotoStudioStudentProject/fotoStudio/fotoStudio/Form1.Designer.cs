namespace fotoStudio
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.menu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegFinal = new System.Windows.Forms.Button();
            this.tbUsernameRegister = new System.Windows.Forms.TextBox();
            this.lblReg1 = new System.Windows.Forms.Label();
            this.lblReg3 = new System.Windows.Forms.Label();
            this.tbPasswordRegister = new System.Windows.Forms.TextBox();
            this.lblreg2 = new System.Windows.Forms.Label();
            this.tbCheckPassword = new System.Windows.Forms.TextBox();
            this.tbUsernameLogin = new System.Windows.Forms.TextBox();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnSee = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.btnLogFinal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.tmrAnimator = new System.Windows.Forms.Timer(this.components);
            this.conCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.menu.Controls.Add(this.pictureBox2);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(726, 29);
            this.menu.TabIndex = 0;
            this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(666, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(694, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.panelSelect);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 394);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(17, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "AnTas";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(205)))));
            this.panelSelect.Location = new System.Drawing.Point(141, 147);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(10, 109);
            this.panelSelect.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.Location = new System.Drawing.Point(0, 146);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 109);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegister.Location = new System.Drawing.Point(0, 254);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(145, 103);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 356);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(145, 38);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnRegFinal);
            this.panel1.Controls.Add(this.tbUsernameRegister);
            this.panel1.Controls.Add(this.lblReg1);
            this.panel1.Controls.Add(this.lblReg3);
            this.panel1.Controls.Add(this.tbPasswordRegister);
            this.panel1.Controls.Add(this.lblreg2);
            this.panel1.Controls.Add(this.tbCheckPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(430, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 394);
            this.panel1.TabIndex = 0;
            // 
            // btnRegFinal
            // 
            this.btnRegFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegFinal.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegFinal.Location = new System.Drawing.Point(47, 311);
            this.btnRegFinal.Name = "btnRegFinal";
            this.btnRegFinal.Size = new System.Drawing.Size(204, 97);
            this.btnRegFinal.TabIndex = 7;
            this.btnRegFinal.Text = "Register";
            this.btnRegFinal.UseVisualStyleBackColor = true;
            this.btnRegFinal.Click += new System.EventHandler(this.btnRegFinal_Click);
            this.btnRegFinal.MouseLeave += new System.EventHandler(this.btnRegFinal_MouseLeave);
            this.btnRegFinal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRegFinal_MouseMove);
            // 
            // tbUsernameRegister
            // 
            this.tbUsernameRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbUsernameRegister.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameRegister.Location = new System.Drawing.Point(47, 71);
            this.tbUsernameRegister.Name = "tbUsernameRegister";
            this.tbUsernameRegister.Size = new System.Drawing.Size(204, 31);
            this.tbUsernameRegister.TabIndex = 4;
            this.tbUsernameRegister.Click += new System.EventHandler(this.tbUsernameRegister_Click);
            // 
            // lblReg1
            // 
            this.lblReg1.AutoSize = true;
            this.lblReg1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg1.ForeColor = System.Drawing.Color.Transparent;
            this.lblReg1.Location = new System.Drawing.Point(43, 45);
            this.lblReg1.Name = "lblReg1";
            this.lblReg1.Size = new System.Drawing.Size(95, 23);
            this.lblReg1.TabIndex = 10;
            this.lblReg1.Text = "Username:";
            // 
            // lblReg3
            // 
            this.lblReg3.AutoSize = true;
            this.lblReg3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg3.ForeColor = System.Drawing.Color.Transparent;
            this.lblReg3.Location = new System.Drawing.Point(43, 197);
            this.lblReg3.Name = "lblReg3";
            this.lblReg3.Size = new System.Drawing.Size(149, 23);
            this.lblReg3.TabIndex = 8;
            this.lblReg3.Text = "Repeat password:";
            // 
            // tbPasswordRegister
            // 
            this.tbPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPasswordRegister.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordRegister.Location = new System.Drawing.Point(47, 146);
            this.tbPasswordRegister.Name = "tbPasswordRegister";
            this.tbPasswordRegister.PasswordChar = '•';
            this.tbPasswordRegister.Size = new System.Drawing.Size(204, 31);
            this.tbPasswordRegister.TabIndex = 5;
            this.tbPasswordRegister.Click += new System.EventHandler(this.tbPasswordRegister_Click);
            this.tbPasswordRegister.TextChanged += new System.EventHandler(this.tbPasswordRegister_TextChanged);
            // 
            // lblreg2
            // 
            this.lblreg2.AutoSize = true;
            this.lblreg2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg2.ForeColor = System.Drawing.Color.Transparent;
            this.lblreg2.Location = new System.Drawing.Point(43, 120);
            this.lblreg2.Name = "lblreg2";
            this.lblreg2.Size = new System.Drawing.Size(91, 23);
            this.lblreg2.TabIndex = 7;
            this.lblreg2.Text = "Password:";
            // 
            // tbCheckPassword
            // 
            this.tbCheckPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbCheckPassword.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheckPassword.Location = new System.Drawing.Point(47, 223);
            this.tbCheckPassword.Name = "tbCheckPassword";
            this.tbCheckPassword.PasswordChar = '•';
            this.tbCheckPassword.Size = new System.Drawing.Size(204, 31);
            this.tbCheckPassword.TabIndex = 6;
            this.tbCheckPassword.Click += new System.EventHandler(this.tbCheckPassword_Click);
            this.tbCheckPassword.TextChanged += new System.EventHandler(this.tbCheckPassword_TextChanged);
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbUsernameLogin.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameLogin.Location = new System.Drawing.Point(182, 175);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(204, 31);
            this.tbUsernameLogin.TabIndex = 1;
            this.tbUsernameLogin.Click += new System.EventHandler(this.tbUsernameLogin_Click);
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPasswordLogin.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordLogin.Location = new System.Drawing.Point(182, 252);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.Size = new System.Drawing.Size(204, 31);
            this.tbPasswordLogin.TabIndex = 2;
            this.tbPasswordLogin.Click += new System.EventHandler(this.tbPasswordLogin_Click);
            // 
            // btnSee
            // 
            this.btnSee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSee.ForeColor = System.Drawing.Color.Transparent;
            this.btnSee.Image = ((System.Drawing.Image)(resources.GetObject("btnSee.Image")));
            this.btnSee.Location = new System.Drawing.Point(357, 255);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(25, 25);
            this.btnSee.TabIndex = 0;
            this.btnSee.UseVisualStyleBackColor = false;
            this.btnSee.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Transparent;
            this.lblLogin.Location = new System.Drawing.Point(178, 149);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(95, 23);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Username:";
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin2.ForeColor = System.Drawing.Color.Transparent;
            this.lblLogin2.Location = new System.Drawing.Point(178, 226);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(91, 23);
            this.lblLogin2.TabIndex = 4;
            this.lblLogin2.Text = "Password:";
            // 
            // btnLogFinal
            // 
            this.btnLogFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogFinal.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogFinal.Location = new System.Drawing.Point(182, 340);
            this.btnLogFinal.Name = "btnLogFinal";
            this.btnLogFinal.Size = new System.Drawing.Size(204, 97);
            this.btnLogFinal.TabIndex = 3;
            this.btnLogFinal.Text = "Login";
            this.btnLogFinal.UseVisualStyleBackColor = true;
            this.btnLogFinal.Click += new System.EventHandler(this.btnLogFinal_Click);
            this.btnLogFinal.MouseLeave += new System.EventHandler(this.btnLogFinal_MouseLeave);
            this.btnLogFinal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLogFinal_MouseMove);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemember.ForeColor = System.Drawing.Color.Transparent;
            this.cbRemember.Location = new System.Drawing.Point(182, 283);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(125, 23);
            this.cbRemember.TabIndex = 12;
            this.cbRemember.Text = "Remember me";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // tmrAnimator
            // 
            this.tmrAnimator.Interval = 10;
            this.tmrAnimator.Tick += new System.EventHandler(this.tmrAnimator_Tick);
            // 
            // conCheckTimer
            // 
            this.conCheckTimer.Interval = 10000;
            this.conCheckTimer.Tick += new System.EventHandler(this.conCheckTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(177, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "*CONN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tmrBlink
            // 
            this.tmrBlink.Tick += new System.EventHandler(this.tmrBlink_Tick);
            // 
            // frm1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(726, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.btnLogFinal);
            this.Controls.Add(this.lblLogin2);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.tbUsernameLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbUsernameLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLogin2;
        private System.Windows.Forms.TextBox tbUsernameRegister;
        private System.Windows.Forms.Label lblReg1;
        private System.Windows.Forms.Label lblReg3;
        private System.Windows.Forms.TextBox tbPasswordRegister;
        private System.Windows.Forms.Label lblreg2;
        private System.Windows.Forms.TextBox tbCheckPassword;
        private System.Windows.Forms.Button btnLogFinal;
        private System.Windows.Forms.Button btnRegFinal;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.Timer tmrAnimator;
        private System.Windows.Forms.Timer conCheckTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrBlink;
    }
}

