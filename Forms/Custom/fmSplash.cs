using REMAS.Forms.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace REMAS.Forms.Custom
{
    public partial class fmSplash : Form
    {
        public fmSplash()
        {
            InitializeComponent();
        }

        private void fmSplash_Load(object sender, EventArgs e)
        {
            timeLeft = 2;
            timer1.Start();
        }

        public int timeLeft { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                timer1.Stop();
                new fmLogin().Show();
                this.Hide();
            }
        }
    }
}
