using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS.Forms.Custom
{
    public partial class myMsgBox : Form
    {
        static myMsgBox messageBox;
        static string btn_Id;

        public myMsgBox()
        {
            InitializeComponent();
        }

        public string ShowBox(int i, string message, string header)
        {
            messageBox = new myMsgBox();
            messageBox.lbHeader.Text = header;
            messageBox.lbMessage.Text = message;
            btnVisible(i);
            messageBox.ShowDialog();
            return btn_Id;
        }

        private void btnVisible(int i)
        {
            // Hanya Tombol Ok
            if (i == 0)
            {
                messageBox.btnYes.Visible = false;
                messageBox.btnNo.Visible = false;
                messageBox.btnOk.Visible = true;
            }
            else // Tombol Yes dan No
            {
                messageBox.btnYes.Visible = true;
                messageBox.btnNo.Visible = true;
                messageBox.btnOk.Visible = false;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            btn_Id = "YES";
            messageBox.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btn_Id = "NO";
            messageBox.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btn_Id = "OK";
            messageBox.Dispose();
        }
    }
}
