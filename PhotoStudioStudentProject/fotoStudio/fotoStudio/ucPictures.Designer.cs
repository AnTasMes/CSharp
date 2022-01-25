namespace fotoStudio
{
    partial class ucPictures
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbComm = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkForDeletion = new System.Windows.Forms.Timer(this.components);
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(114)))), ((int)(((byte)(121)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(527, 364);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(533, 24);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(264, 31);
            this.tbUsername.TabIndex = 1;
            // 
            // tbComm
            // 
            this.tbComm.Location = new System.Drawing.Point(533, 93);
            this.tbComm.Name = "tbComm";
            this.tbComm.Size = new System.Drawing.Size(264, 31);
            this.tbComm.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Transparent;
            this.btnShow.Location = new System.Drawing.Point(533, 180);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(264, 39);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show photos";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comment:";
            // 
            // checkForDeletion
            // 
            this.checkForDeletion.Tick += new System.EventHandler(this.checkForDeletion_Tick);
            // 
            // cbChoose
            // 
            this.cbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Items.AddRange(new object[] {
            "All",
            "Selected"});
            this.cbChoose.Location = new System.Drawing.Point(533, 130);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(264, 31);
            this.cbChoose.TabIndex = 6;
            this.cbChoose.SelectedIndexChanged += new System.EventHandler(this.cbChoose_SelectedIndexChanged);
            // 
            // ucPictures
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.cbChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.tbComm);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucPictures";
            this.Size = new System.Drawing.Size(800, 364);
            this.Load += new System.EventHandler(this.ucPictures_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbComm;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer checkForDeletion;
        private System.Windows.Forms.ComboBox cbChoose;
    }
}
