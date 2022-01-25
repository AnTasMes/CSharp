using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotoStudio
{
    public partial class frmComment : Form
    {
        public frmComment()
        {
            InitializeComponent();
            lblLen.Text = $"{usedChars}/{maxChars}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoTransfer.PhotoComment = rtbComment.Text;
        }
        int maxChars = 1000;
        int usedChars = 0;
        int currLen = 0;
        private void rtbComment_TextChanged(object sender, EventArgs e)
        {
            rtbComment.MaxLength = maxChars;
            if (rtbComment.Text.Length > currLen)
            {
                usedChars = rtbComment.Text.Length;
                lblLen.Text = $"{usedChars}/{maxChars}";
            }
            else if(rtbComment.Text.Length < currLen)
            {
                usedChars = rtbComment.Text.Length;
                lblLen.Text = $"{usedChars}/{maxChars}";
            }
            currLen = rtbComment.Text.Length;
        }
    }
}
