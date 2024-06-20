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
    }
}
