using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS.Forms.Purchasing
{
    public partial class frmContacts : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBREMASFixed;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        string sql, sAction;
        int iID;

        public frmContacts()
        {
            InitializeComponent();
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            LoadData(); // Call the LoadData method when the form is loaded
        }

        void LoadData()
        {
            try
            {
                // Open connection if it's not already open
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Select data from HTA_ContactInformation table
                sql = "SELECT * FROM HTA_ContactInformation";
                cmd = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                // Clear DataGridView and add rows from DataTable
                dgvContacts.Rows.Clear();
                dgvContacts.Rows.Add(dt.Rows.Count);
                for (int n = 0; n < dt.Rows.Count; n++)
                {
                    dgvContacts.Rows[n].Cells["Ref"].Value = dt.Rows[n]["Reference"].ToString().Trim();
                    dgvContacts.Rows[n].Cells["Name"].Value = dt.Rows[n]["Name"].ToString().Trim();
                    dgvContacts.Rows[n].Cells["fixedPhone"].Value = dt.Rows[n]["Fixed Phone"].ToString().Trim();
                    dgvContacts.Rows[n].Cells["mobilePhone"].Value = dt.Rows[n]["Mobile Phone"].ToString().Trim();
                    dgvContacts.Rows[n].Cells["email"].Value = dt.Rows[n]["Email"].ToString().Trim();
                    dgvContacts.Rows[n].Cells["mainCompany"].Value = dt.Rows[n]["Main Company"].ToString().Trim();
                    dgvContacts.Rows[n].Cells["function"].Value = dt.Rows[n]["Function"].ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error");
            }
            finally
            {
                // Close connection even if an exception occurs
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnPlusCont_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (frmCreateContacts uu = new frmCreateContacts())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0.70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in btnPlusCont_Click: " + ex.ToString(), "Error");
            }
            finally
            {
                formBackground.Dispose(); // Dispose the form outside the using block
                LoadData(); // Load data after the form is closed
            }
        }
    }
}
