using REMAS.Forms.Account;
using REMAS.Forms.Custom;
using REMAS.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS
{
    public partial class fmREMAS : Form
    {
        string sql, sDirZip, sModGrpCd, sRoot, sProgName, sUserCd;
        int si, x, y;
        Button b;
        CallForm callForm;
        RunQuery qu_All; 
        DataTable myData;
        myMsgBox messageBox;
        private Form activeForm;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [Obsolete]
        public fmREMAS()
        {
            InitializeComponent();
            sUserCd = Properties.Settings.Default.Username;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }        

        private void OpenChildForm(Form childForm)
        {
            //if (activeForm != null)
            //    activeForm.Close();
            ////ActivateButton(btnSender);
            //activeForm = childForm;
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //this.splitC.Panel2.Controls.Add(childForm);
            //this.splitC.Panel2.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
            //lbTitle.Text = childForm.Text;

            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //childForm.Size = new Size(800,600);
            this.splitC.Panel2.Controls.Add(childForm);
            this.splitC.Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        private void VisiblePanelMain(Panel panel)
        {
            // panel report tidak usah close
            string name = panel.Name;
            name = name.Substring(name.Length - 3, 3);

            if (name.ToLower() != "rpt")
            {
                foreach (var c in pnMain.Controls)
                {
                    if (c is Panel)
                    {
                        ((Panel)c).Visible = false;
                    }
                }
            }

            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sql = " Select GetDate() as DateNow ";
            qu_All = new RunQuery();
            myData = qu_All.OpenAdoQuery(sql);
            //lbDate.Text = string.Format("{0:dd-MMM-yyyy hh:mm:ss tt}", myData.Rows[0]["DateNow"]);
        }

        [Obsolete]
        private void fmREMAS_Load(object sender, EventArgs e)
        {
            //
        }

        private void fmREMAS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            VisiblePanelMain(pnMaster);
        }

        private void btnGenSetup_Click(object sender, EventArgs e)
        {
            VisiblePanelMain(pnGenSetup);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            VisiblePanelMain(pnSales);
        }

        private void btnSalesRpt_Click(object sender, EventArgs e)
        {
            VisiblePanelMain(pnSalesRpt);
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            VisiblePanelMain(pnBP);
        }

        [Obsolete]
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Account.fmUser());
        }
    }
}
