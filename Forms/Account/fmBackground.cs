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
    public partial class fmBackground : Form
    {
        CallForm callForm;
        public fmBackground()
        {
            InitializeComponent();
            callForm = new CallForm();
        }

        private void fmBackground_Load(object sender, EventArgs e)
        {
            callForm.fmNames(typeof(fmLogin));
        }
    }
}
