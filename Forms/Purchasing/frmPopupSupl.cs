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
    public partial class frmPopupSupl : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBREMASFixed;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        string sql, sAction;
        int iID;
        public frmPopupSupl()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                sql = "sp_PopupSupl";
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
              //  cmd.Parameters.AddWithValue("@name", txbSearchPop.Texts.ToString());
                cmd.Parameters.AddWithValue("@product", txbSearch.Texts.ToString());
                cmd.Parameters.AddWithValue("@qualityrating", int.Parse(txbQualityRating.Texts.ToString()));
                cmd.Parameters.AddWithValue("@arrivalproductquantity", (int)nudArrivalProduct.Value);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Insert new data successful", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
                conn.Close();
                return;
            }
        }
    }
}
