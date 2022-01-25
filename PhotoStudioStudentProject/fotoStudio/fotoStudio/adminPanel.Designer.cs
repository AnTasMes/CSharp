namespace fotoStudio
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            this.menu = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditServices = new System.Windows.Forms.Button();
            this.btnUserConf = new System.Windows.Forms.Button();
            this.btnPictures = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.menu.Controls.Add(this.pbMinimize);
            this.menu.Controls.Add(this.pbClose);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 29);
            this.menu.TabIndex = 1;
            this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(740, 2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(25, 25);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 2;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            this.pbMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMinimize_MouseMove);
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(766, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            this.pbClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbClose_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.btnEditServices);
            this.panel1.Controls.Add(this.btnUserConf);
            this.panel1.Controls.Add(this.btnPictures);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 3;
            // 
            // btnEditServices
            // 
            this.btnEditServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditServices.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditServices.Location = new System.Drawing.Point(545, 0);
            this.btnEditServices.Name = "btnEditServices";
            this.btnEditServices.Size = new System.Drawing.Size(243, 57);
            this.btnEditServices.TabIndex = 3;
            this.btnEditServices.Text = "Edit Services";
            this.btnEditServices.UseVisualStyleBackColor = true;
            this.btnEditServices.Click += new System.EventHandler(this.btnEditServices_Click);
            // 
            // btnUserConf
            // 
            this.btnUserConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserConf.ForeColor = System.Drawing.Color.Transparent;
            this.btnUserConf.Location = new System.Drawing.Point(279, 0);
            this.btnUserConf.Name = "btnUserConf";
            this.btnUserConf.Size = new System.Drawing.Size(243, 57);
            this.btnUserConf.TabIndex = 2;
            this.btnUserConf.Text = "User Configurations";
            this.btnUserConf.UseVisualStyleBackColor = true;
            this.btnUserConf.Click += new System.EventHandler(this.btnUserConf_Click);
            // 
            // btnPictures
            // 
            this.btnPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPictures.ForeColor = System.Drawing.Color.Transparent;
            this.btnPictures.Location = new System.Drawing.Point(12, 0);
            this.btnPictures.Name = "btnPictures";
            this.btnPictures.Size = new System.Drawing.Size(243, 57);
            this.btnPictures.TabIndex = 1;
            this.btnPictures.Text = "Pictures";
            this.btnPictures.UseVisualStyleBackColor = true;
            this.btnPictures.Click += new System.EventHandler(this.btnPictures_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 364);
            this.panel2.TabIndex = 4;
            // 
            // adminPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminPanel";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditServices;
        private System.Windows.Forms.Button btnUserConf;
        private System.Windows.Forms.Button btnPictures;
        private System.Windows.Forms.Panel panel2;
    }
}