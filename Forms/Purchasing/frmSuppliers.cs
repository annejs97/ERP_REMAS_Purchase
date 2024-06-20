using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace REMAS.Forms.Purchasing
{
    public partial class frmSuppliers : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBREMASFixed;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        frmNewSuppliers Plus;
        string selectedReference;

        public frmSuppliers()
        {
            InitializeComponent();
            conn.Open();

        }

        void LoadData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "SELECT [Id Supplier], [Ref Supplier] AS RefSupplier, [Company Name] AS CompanyName FROM HTA_Information";
                cmd = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvSupplier.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int rowIndex = dgvSupplier.Rows.Add();
                    dgvSupplier.Rows[rowIndex].Cells["Ref"].Value = row["RefSupplier"].ToString().Trim();
                    dgvSupplier.Rows[rowIndex].Cells["Supplier"].Value = row["CompanyName"].ToString().Trim();
                    dgvSupplier.Rows[rowIndex].Tag = row["Id Supplier"].ToString().Trim();
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

        private void AddDeleteButtonColumn()
        {
            if (dgvSupplier.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dgvSupplier.Columns.Add(deleteButtonColumn);
            }
        }

        private void btnPlusCont_Click(object sender, EventArgs e)
        {
            if (Plus == null)
            {
                Plus = new frmNewSuppliers();
                Plus.FormClosed += Plus_FormClosed;
                Plus.MdiParent = this.ParentForm;
                Plus.Dock = DockStyle.Fill;
                Plus.Show();
            }
            else
            {
                Plus.Activate();
            }
            LoadData();
        }

        private void Plus_FormClosed(object sender, EventArgs e)
        {
            Plus = null;
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            LoadData();
            AddDeleteButtonColumn();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the reference value from the clicked row (assuming reference is in the "Ref" column)
                selectedReference = dgvSupplier.Rows[e.RowIndex].Cells["Ref"].Value.ToString();

                // Check if the clicked cell is the "Delete" button
                if (dgvSupplier.Columns[e.ColumnIndex].Name == "Delete")
                {
                    string idSupplier = dgvSupplier.Rows[e.RowIndex].Tag.ToString(); // Get Id Supplier from Tag

                    var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        DeleteSupplier(idSupplier);
                        LoadData();
                    }
                }
            }
        }

        private void DeleteSupplier(string idSupplier)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Hapus data terkait di tabel HTA_ContactInformation
                string deleteRelatedQuery1 = "DELETE FROM HTA_ContactInformation WHERE id_Supplier = @IdSupplier";
                using (SqlCommand deleteRelatedCommand1 = new SqlCommand(deleteRelatedQuery1, conn))
                {
                    deleteRelatedCommand1.Parameters.AddWithValue("@IdSupplier", idSupplier);
                    deleteRelatedCommand1.ExecuteNonQuery();
                }

                // Hapus data terkait di tabel HTA_AccountinSituation
                string deleteRelatedQuery2 = "DELETE FROM HTA_AccountingSituation WHERE id_Supplier = @IdSupplier";
                using (SqlCommand deleteRelatedCommand2 = new SqlCommand(deleteRelatedQuery2, conn))
                {
                    deleteRelatedCommand2.Parameters.AddWithValue("@IdSupplier", idSupplier);
                    deleteRelatedCommand2.ExecuteNonQuery();
                }

                // Hapus data terkait di tabel HTA_InvoicingPayment
                string deleteRelatedQuery3 = "DELETE FROM HTA_InvoicingPayment WHERE id_Supplier = @IdSupplier";
                using (SqlCommand deleteRelatedCommand3 = new SqlCommand(deleteRelatedQuery3, conn))
                {
                    deleteRelatedCommand3.Parameters.AddWithValue("@IdSupplier", idSupplier);
                    deleteRelatedCommand3.ExecuteNonQuery();
                }

                // Hapus data terkait di tabel HTA_Blocking
                string deleteRelatedQuery4 = "DELETE FROM HTA_Blocking WHERE id_Supplier = @IdSupplier";
                using (SqlCommand deleteRelatedCommand4 = new SqlCommand(deleteRelatedQuery4, conn))
                {
                    deleteRelatedCommand4.Parameters.AddWithValue("@IdSupplier", idSupplier);
                    deleteRelatedCommand4.ExecuteNonQuery();
                }

                // Hapus data terkait di tabel HTA_Delivery
                string deleteRelatedQuery5 = "DELETE FROM HTA_Delivery WHERE id_Supplier = @IdSupplier";
                using (SqlCommand deleteRelatedCommand5 = new SqlCommand(deleteRelatedQuery5, conn))
                {
                    deleteRelatedCommand5.Parameters.AddWithValue("@IdSupplier", idSupplier);
                    deleteRelatedCommand5.ExecuteNonQuery();
                }

                // Hapus data utama di tabel HTA_Information
                string deleteMainQuery = "DELETE FROM HTA_Supplier WHERE [id_supplier] = @IdSupplier";
                using (SqlCommand deleteMainCommand = new SqlCommand(deleteMainQuery, conn))
                {
                    deleteMainCommand.Parameters.AddWithValue("@IdSupplier", idSupplier);
                    deleteMainCommand.ExecuteNonQuery();
                }

                // Hapus data utama di tabel HTA_Supplier
                string deleteSupplierQuery = "DELETE FROM HTA_Information WHERE [Id supplier] = @IdSupplier";
                using (SqlCommand deleteSupplierCommand = new SqlCommand(deleteSupplierQuery, conn))
                {
                    deleteSupplierCommand.Parameters.AddWithValue("@IdSupplier", idSupplier);
                    int rowsAffected = deleteSupplierCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No data found with the provided Id.");
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dgvSupplier_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRepeatCont_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedReference))
            {
                frmNewSuppliers editForm = new frmNewSuppliers(selectedReference);
                editForm.ShowDialog(); // Or use editForm.Show() if you don't want it modal
            }
            else
            {
                MessageBox.Show("Please select a record to edit.", "Error");
            }
        }
    }
}
