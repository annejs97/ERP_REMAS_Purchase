using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class frmLogin : Form
    {
        private const string connectionString = "Data Source=localhost;Initial Catalog=DBREMASFixed;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtUserName.KeyDown += txtUsername_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        
        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM dbo.Login WHERE id = @username AND Password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            frmDashboard form3 = new frmDashboard(username);
                            form3.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah. Silahkan coba lagi.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                        
                }
            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
