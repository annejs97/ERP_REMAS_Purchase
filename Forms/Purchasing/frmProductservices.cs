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
    public partial class frmProductservices : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBREMASFixed;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        string sql, sAction;
        int iID;
        public frmProductservices()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = " Select * from HTA_PurchaseService ";
                cmd = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvProducts.Rows.Clear();
                dgvProducts.Rows.Add(dt.Rows.Count);
                for (int n = 0; n <= dt.Rows.Count - 1; n++)
                {
                    dgvProducts.Rows[n].Cells["journal"].Value = dt.Rows[n]["Journal"].ToString().Trim();
                    dgvProducts.Rows[n].Cells["period"].Value = dt.Rows[n]["Period"].ToString().Trim();
                    dgvProducts.Rows[n].Cells["date"].Value = dt.Rows[n]["Date"].ToString().Trim();
                    dgvProducts.Rows[n].Cells["partner"].Value = dt.Rows[n]["Partner"].ToString().Trim();
                    dgvProducts.Rows[n].Cells["company"].Value = dt.Rows[n]["Company"].ToString().Trim();
                    dgvProducts.Rows[n].Cells["internalDesc"].Value = dt.Rows[n]["internal_description"].ToString().Trim();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
                conn.Close();
                return;
            }
        }

        private void frmProductservices_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnPlusPrdct_Click(object sender, EventArgs e)
        {

        }
    }
}
