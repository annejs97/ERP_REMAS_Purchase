using REMAS.Forms.Custom;
using REMAS.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace REMAS.Forms.Account
{
    public partial class fmLogin : Form
    {
        string sql, sPass, sEsc = "N";
        int iSetExpired, iExpired, iStockOpname;
        Form form = new Form();
        Security crypto;
        RunQuery qu_All;
        CallForm callForm;
        DataTable myData, myData2;
        myMsgBox messageBox;

        [Obsolete]
        public fmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            callForm = new CallForm();
            //this.Width = 800;
            //this.Height = 600;
        }

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);        

        private void fmLogin_Load(object sender, EventArgs e)
        {            
            // System Config
            sql = " Select KeyField, KeyValue from SystemConfig Where KeyField in ('SetExpiredPassword','ExpiredPassword','StockOpname') ";
            qu_All = new RunQuery();
            myData = qu_All.OpenAdoQuery(sql);
            if (myData.Rows.Count > 0)
            {
                iSetExpired = Convert.ToInt32(myData.Rows[0]["KeyValue"].ToString().Trim());
                iExpired = Convert.ToInt32(myData.Rows[1]["KeyValue"].ToString().Trim());
                iStockOpname = Convert.ToInt32(myData.Rows[2]["KeyValue"].ToString().Trim());
            }
            pictureBox1.Select();
            SendMessage(txtUserName.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(txtPassword.Handle, EM_SETCUEBANNER, 0, "Password");
        }

        private void fmLogin_Resize(object sender, EventArgs e)
        {
            //pnLogin.Location = new Point(this.ClientSize.Width / 2 - pnLogin.Size.Width / 2,
            //    this.ClientSize.Height / 2 - pnLogin.Size.Height / 2);
            //pnLogin.Anchor = AnchorStyles.None;
        }

        private void fmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape)) { Application.Exit(); }

            if ((e.KeyChar == (char)Keys.Enter) | (e.KeyChar == (char)Keys.Tab))
            {
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    messageBox = new myMsgBox();
                    messageBox.ShowBox(0, "User required !", "Warning");
                }
                else if (txtPassword.CanFocus) { txtPassword.Select(); }
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            //if (sEsc == "Y") { sEsc = "N";  return; }

            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                messageBox = new myMsgBox();
                messageBox.ShowBox(0, "User required, please click Esc to cancel login !", "Warning");
                if (txtUserName.CanFocus) { txtUserName.Select(); }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                if (!IsPasswordValid(txtPassword.Text.Trim()))
                {
                    lbWarning.Visible = true;
                }
                else
                {
                    lbWarning.Visible = false;
                }
            }
            else
            {
                lbWarning.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(255, 64, 64);
            btnLogin.ForeColor = Color.GhostWhite;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.GhostWhite;
            btnLogin.ForeColor = Color.FromArgb(255, 64, 64);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape)) { Application.Exit(); }

            if ((e.KeyChar == (char)Keys.Enter) | (e.KeyChar == (char)Keys.Tab))
            {
                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    messageBox = new myMsgBox();
                    messageBox.ShowBox(0, "Password required !", "Warning");
                }
                else
                {
                    btnLogin.PerformClick();
                }
            }
        }
        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                if (!IsPasswordValid(txtPassword.Text.Trim()))
                {
                    messageBox = new myMsgBox();
                    messageBox.ShowBox(0, "Password Not Valid !", "Warning");
                    if (txtPassword.CanFocus) { txtPassword.Select(); }
                }
            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        [Obsolete]
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() == "") { messageBox = new myMsgBox();  messageBox.ShowBox(0, "Username Required !", "Warning"); if (txtUserName.CanFocus) { txtUserName.Focus(); } return; }
            if(txtPassword.Text.Trim() == "") { messageBox = new myMsgBox();  messageBox.ShowBox(0, "Password Required !", "Warning"); if (txtPassword.CanFocus) { txtPassword.Focus(); } return; }
            // Stock Opname
            if (iStockOpname == 1)
            {
                // IT can login
                sql = "Select GroupCd from SystemUser Where NIK = '" + txtUserName.Text.Trim() + "'";
                qu_All = new RunQuery();
                myData = qu_All.OpenAdoQuery(sql);
                if (myData.Rows[0]["GroupCd"].ToString() != "1")
                {
                    messageBox = new myMsgBox();
                    messageBox.ShowBox(0, "Login Fail, Stock Opname Being Done !", "Warning");
                    return;
                }                
            }

            //// Check Set Expired Password
            //if (iSetExpired == 1)
            //{
            //    try
            //    {
            //        // Get Data User
            //        crypto = new Security();
            //        sPass = crypto.Hashing(txtPassword.Text.Trim());
            //        sql = " Select DateDiff(Month, PasswordChange,  GetDate()) as Months, * from SystemUser " +
            //              " Where NIK = '" + txtUserName.Text.Trim() + "' And UserPass = '" + sPass + "' ";
            //        qu_All = new RunQuery();
            //        myData2 = qu_All.OpenAdoQuery(sql);

            //        if (Convert.ToInt16(myData.Rows[0]["KeyValue"].ToString()) == 1) // true
            //        {

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        messageBox = new myMsgBox();
            //        messageBox.ShowBox(0, "Login Fail " + ex.Message, "Warning");
            //    }
            //}

            try
            {
                crypto = new Security();
                sPass = crypto.Hashing(txtPassword.Text.Trim());
                sql = " Select DateDiff(Month, PasswordChange,  GetDate()) as Months, * from SystemUser " +
                      " Where NIK = '" + txtUserName.Text.Trim() + "' And UserPass = '" + sPass + "' ";
                qu_All = new RunQuery();
                myData = qu_All.OpenAdoQuery(sql);
                if (myData.Rows.Count > 0)
                {
                    // Check Set Expired
                    if (iSetExpired == 1)
                    {
                        // Expired Validate
                        if (Convert.ToInt16(myData.Rows[0]["Months"].ToString()) >= iExpired)
                        {
                            messageBox = new myMsgBox();
                            string result = messageBox.ShowBox(1, " Password has expired, please change your password now !", "Warning");
                            if (result == "YES")
                            {
                                Hide();

                                form = new fmChangePassword("N", txtUserName.Text.Trim());
                                form.ShowDialog();
                            }
                        }
                        else
                        {
                            Properties.Settings.Default.Username = txtUserName.Text.Trim();
                            Properties.Settings.Default.Save();
                            Hide();
                            callForm.fmNames(typeof(fmREMAS));
                        }
                    }
                }
                else
                {
                    messageBox = new myMsgBox();
                    messageBox.ShowBox(0, "Username and Password Not Valid !", "Warning");
                }
            }
            catch (Exception ex)
            {
                messageBox = new myMsgBox();
                messageBox.ShowBox(0, "Login Fail " + ex.Message, "Warning");
            }
        }

        private bool IsPasswordValid(string Password)
        {
            var regex = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
            if (!regex.IsMatch(Password))
            {
                return false;
            }

            return true;
        }
    }
}
