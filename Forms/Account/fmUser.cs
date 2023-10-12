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
    public partial class fmUser : Form
    {
        public fmUser()
        {
            InitializeComponent();
        }

        private void fmUser_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.ClientSize.Width / 2 - 800 / 2,
                this.ClientSize.Height / 2 - 600 / 2);
            this.Anchor = AnchorStyles.None;
        }
    }
}
