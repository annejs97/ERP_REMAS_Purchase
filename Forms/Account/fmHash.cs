using REMAS.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS.Forms.Account
{
    public partial class fmHash : Form
    {
        Security crypto;
        public fmHash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crypto = new Security();
            textBox2.Text = crypto.Hashing(textBox1.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crypto = new Security();
            textBox3.Text = crypto.GeneratePassword();
        }
    }
}
