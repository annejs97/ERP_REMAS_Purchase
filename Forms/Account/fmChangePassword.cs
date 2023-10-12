using REMAS.Forms.Custom;
using REMAS.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS.Forms.Account
{
    public partial class fmChangePassword : Form
    {
        //public fmChangePassword form { get; set; }
        string sql, sUserCd, sReset, sPasswordOld, sPassword, sLastPass, sIPAddr, sHostName;
        bool bResult;
        Security crypto;
        RunQuery qu_All;
        ExecSqlServer acmExec;
        DataTable myData;
        MyMessageBox messageBox;

        [Obsolete]
        public fmChangePassword(string reset, string user)
        {
            InitializeComponent();
            sReset = reset;
            txtUserCd.Text = user;
            sHostName = Dns.GetHostName();
            sIPAddr = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            //txtPasswordOld.UseSystemPasswordChar = true;
            //txtPasswordNew.UseSystemPasswordChar = true;
            //txtPasswordConfirm.UseSystemPasswordChar = true;
        }

        private void fmChangePassword_Load(object sender, EventArgs e)
        {
            // Check User Already
            sql = " Select * from SystemUser Where UserCd = '"+ txtUserCd.Text.Trim() +"' ";
            qu_All = new RunQuery();
            myData = qu_All.OpenAdoQuery(sql);
            if (myData.Rows.Count <= 0)
            {
                messageBox = new MyMessageBox();
                messageBox.ShowBox(0, "User Code not Exist !", "Warning");
                return;
            }
            else 
            {
                txtUserName.Text = myData.Rows[0]["UserName"].ToString().Trim();
                sLastPass = myData.Rows[0]["LastPassword"].ToString().Trim();
            }

            // Jika Perintah Reset
            if (sReset == "Y")
            {
                // Get Last Password
                lbHeader.Text = "Reset Password";
                txtPasswordOld.Text = myData.Rows[0]["UserPass"].ToString().Trim();
                txtPasswordOld.ReadOnly = true;
                txtPasswordNew.Select();
            }
            else
            {
                lbHeader.Text = "Change Password";
                sPasswordOld = myData.Rows[0]["UserPass"].ToString().Trim();
                txtPasswordOld.ReadOnly = false;
                txtPasswordOld.Select();
            }
        }

        private void txtPasswordOld_ButtonClick(object sender, EventArgs e)
        {
            if (txtPasswordOld.UseSystemPasswordChar == true)
            {
                txtPasswordOld.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordOld.UseSystemPasswordChar = true;
            }
        }

        [Obsolete]
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePassword();
            Hide();
            Form fm = new fmLogin();
            fm.ShowDialog();
        }

        void UpdatePassword()
        {
            if (sReset == "N")
            {
                // Check previous password
                crypto = new Security();
                bResult = crypto.VerifyPassword(txtPasswordOld.Text.Trim(), sPasswordOld);
                if (bResult == false)
                {
                    messageBox = new MyMessageBox();
                    messageBox.ShowBox(0, "Previous Password did not Match, please check again !", "Warning");
                    if (txtPasswordOld.CanFocus) { txtPasswordOld.Select(); }
                    return;
                }

                // Check new password
                bResult = crypto.VerifyPassword(txtPasswordConfirm.Text.Trim(), sPassword);
                if (bResult == false)
                {
                    messageBox = new MyMessageBox();
                    messageBox.ShowBox(0, "New Password did not Match, please check again !", "Warning");
                    if (txtPasswordOld.CanFocus) { txtPasswordOld.Select(); }
                    return;
                }

                // Check last password
                bResult = crypto.VerifyPassword(txtPasswordConfirm.Text.Trim(), sLastPass);
                if (bResult == false)
                {
                    // Update
                    try
                    {
                        sql = " Update SystemUser set " +
                              " UserPass = '" + sPassword + "', " +
                              " LastPassword = '" + sPasswordOld + "', " +
                              " PasswordChange = GetDate(), " +
                              " UpdateBy = '" + sUserCd + "', " +
                              " UpdateDate = GetDate(), " +
                              " IPAddr = '" + sIPAddr + "', " +
                              " UpdateMachine = '" + sHostName + "' " +
                              " Where UserCd = '" + txtUserCd.Text.Trim() + "' ";
                        acmExec = new ExecSqlServer();
                        acmExec.ExecSql(sql);

                        messageBox = new MyMessageBox();
                        messageBox.ShowBox(0, "Password changed successfully, please login again ton enter Test", "Warning");
                    }
                    catch (Exception ex)
                    {
                        messageBox = new MyMessageBox();
                        messageBox.ShowBox(0, "Save Error ! " + ex.Message, "Warning");
                    }
                }
                else
                {
                    messageBox = new MyMessageBox();
                    messageBox.ShowBox(0, "This password has already been used, please use another password !", "Warning");
                    if (txtPasswordNew.CanFocus) { txtPasswordNew.Select(); return; }
                }
            }

            // Jika Reset
            else
            {
                // Check new password
                crypto = new Security();
                bResult = crypto.VerifyPassword(txtPasswordConfirm.Text.Trim(), sPassword);
                if (bResult == false)
                {
                    messageBox = new MyMessageBox();
                    messageBox.ShowBox(0, "New Password did not Match, please check again !", "Warning");
                    if (txtPasswordOld.CanFocus) { txtPasswordOld.Select(); }
                    return;
                }

                // Check last password
                bResult = crypto.VerifyPassword(txtPasswordConfirm.Text.Trim(), sLastPass);
                if (bResult == false)
                {
                    // Update
                    try
                    {
                        sql = " Update SystemUser set " +
                              " UserPass = '" + sPassword + "', " +
                              " LastPassword = '" + sPasswordOld + "', " +
                              " PasswordChange = GetDate(), " +
                              " UpdateBy = '" + sUserCd + "', " +
                              " UpdateDate = GetDate(), " +
                              " IPAddr = '" + sIPAddr + "', " +
                              " UpdateMachine = '" + sHostName + "' " +
                              " Where UserCd = '" + txtUserCd.Text.Trim() + "' ";
                        acmExec = new ExecSqlServer();
                        acmExec.ExecSql(sql);

                        messageBox = new MyMessageBox();
                        messageBox.ShowBox(0, "Password changed successfully, please login again ton enter Test", "Warning");
                    }
                    catch (Exception ex)
                    {
                        messageBox = new MyMessageBox();
                        messageBox.ShowBox(0, "Save Error ! " + ex.Message, "Warning");
                    }
                }
                else
                {
                    messageBox = new MyMessageBox();
                    messageBox.ShowBox(0, "This password has already been used, please use another password !", "Warning");
                    if (txtPasswordNew.CanFocus) { txtPasswordNew.Select(); return; }
                }
            }
        }

        [Obsolete]
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Form fm = new fmLogin();
            fm.ShowDialog();
        }

        private void txtPasswordOld_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPasswordOld.Text.Trim()))
            {
                crypto = new Security();
                bResult = crypto.VerifyPassword(txtPasswordOld.Text.Trim(), sPasswordOld);
                if (bResult == false)
                {
                    messageBox = new MyMessageBox();
                    messageBox.ShowBox(0, "Previous Password did not Match, please check again !", "Warning");
                    if (txtPasswordOld.CanFocus) { txtPasswordOld.Select(); }
                }
            }
        }

        private void txtPasswordConfirm_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPasswordOld.Text.Trim()))
            {
                crypto = new Security();
                sPassword = crypto.Hashing(txtPasswordNew.Text.Trim());
                bResult = crypto.VerifyPassword(txtPasswordConfirm.Text.Trim(), sPassword);
                if (bResult == false)
                {
                    messageBox = new MyMessageBox();
                    messageBox.ShowBox(0, "New Password did not Match, please check again !", "Warning");
                    if (txtPasswordConfirm.CanFocus) { txtPasswordConfirm.Select(); }
                }
            }
        }

        private void txtPasswordNew_ButtonClick(object sender, EventArgs e)
        {
            if (txtPasswordNew.UseSystemPasswordChar == true)
            {
                txtPasswordNew.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordNew.UseSystemPasswordChar = true;
            }
        }

        private void txtPasswordConfirm_ButtonClick(object sender, EventArgs e)
        {
            if (txtPasswordConfirm.UseSystemPasswordChar == true)
            {
                txtPasswordConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
