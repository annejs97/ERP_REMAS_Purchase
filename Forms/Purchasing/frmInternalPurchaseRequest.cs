using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace REMAS.Forms.Purchasing
{
    public partial class frmInternalPurchaseRequest : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBREMASFixed;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        string sql, sAction;
        int iID;
        public frmInternalPurchaseRequest()
        {
            InitializeComponent();
            LoadCompany();
            LoadStockLocation();
            LoadSupplier();
        }
        private string GenerateNextReferenceCode()
        {
            string prefix = "IPO";
            int nextNumber = 1;

            string query = "SELECT MAX(ref_InternalPO) FROM HTA_InternalPO WHERE ref_InternalPO LIKE @Prefix + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Prefix", prefix);

            if (conn.State == ConnectionState.Closed) conn.Open();
            var result = cmd.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                string lastCode = result.ToString();
                string numberPart = lastCode.Substring(prefix.Length);
                if (int.TryParse(numberPart, out int lastNumber))
                {
                    nextNumber = lastNumber + 1;
                }
            }
            conn.Close();

            // Determine the required padding length based on the next number
            int paddingLength = Math.Max(4, nextNumber.ToString().Length);
            return $"{prefix}{nextNumber.ToString().PadLeft(paddingLength, '0')}";
        }

        private void frmInternalPurchaseRequest_Load(object sender, EventArgs e)
        {
            //uctInternalPR1.Hide();
        }

        private void btndescription_Click(object sender, EventArgs e)
        {
            //uctInternalPR1.Show();
            //uctInternalPR1.BringToFront();
        }

        public void LoadCompany()
        {
            var categories = new List<Company>();

            try
            {
                conn.Open();
                const string query = "SELECT id_CompanyAssociated, CompanyAssociated_name FROM HTA_cmb_CompanyAssociated";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Company
                        {
                            Id = (int)reader["id_CompanyAssociated"],
                            Name = reader["CompanyAssociated_name"].ToString()
                        });
                    }
                }

                cmbCompany.DisplayMember = "Name";
                cmbCompany.ValueMember = "Id";
                cmbCompany.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading company: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        public void LoadStockLocation()
        {
            var categories = new List<StockLocation>();

            try
            {
                conn.Open();
                const string query = "SELECT id_StockLocation, StockLocation FROM HTA_cmb_StockLocation";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new StockLocation
                        {
                            Id = (int)reader["id_StockLocation"],
                            Name = reader["StockLocation"].ToString()
                        });
                    }
                }

                cmbStockLocation.DisplayMember = "Name";
                cmbStockLocation.ValueMember = "Id";
                cmbStockLocation.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock location: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        public void LoadSupplier()
        {
            var categories = new List<SupplierIntPO>();

            try
            {
                conn.Open();
                const string query = "SELECT [Id supplier] AS idSupply,[Ref supplier] AS refSupplier, [Company name] AS compName FROM HTA_Information";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new SupplierIntPO
                        {
                            Id = (int)reader["idSupply"],
                            RefSupplier = reader["refSupplier"].ToString(),
                            Name = reader["compName"].ToString()
                        });
                    }
                }

                cmbSupplier.DisplayMember = "Display";
                cmbSupplier.ValueMember = "Id";
                cmbSupplier.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplier: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private string currentRefCode;
        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string refCode = GenerateNextReferenceCode();
                string status = lblRequested.Text;  // Get the status from the label's text

                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "HTA_sp_InsertInternalPO";
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ref_InternalPO", refCode);
                cmd.Parameters.AddWithValue("@supplier", ((SupplierIntPO)cmbSupplier.SelectedItem).Id);
                cmd.Parameters.AddWithValue("@refSupplier", ((SupplierIntPO)cmbSupplier.SelectedItem).RefSupplier);
                cmd.Parameters.AddWithValue("@compName", ((Company)cmbCompany.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@stockLoc", ((StockLocation)cmbStockLocation.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@supplierName", ((SupplierIntPO)cmbSupplier.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@status", status);  // Use the status from the label
                cmd.Parameters.AddWithValue("@descNote", rtbDescNotes.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Insert data successfully", "Information");

                currentRefCode = refCode;

                btnDraft.Visible = false;
                btnRequest.Visible = false;
                btnAccepted.Visible = true;
                btnPurchased.Visible = false;
                btnPartialDelivery.Visible = false;
                btnReceived.Visible = false;

                //change color
                lblDraft.BackColor = Color.DarkGray;
                pnlDraft.ArrowColor = Color.DarkGray;
                lblRequested.BackColor = Color.RoyalBlue;
                pnlRequested.ArrowColor = Color.RoyalBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsRecordReceived(currentRefCode))
                {
                    MessageBox.Show("Make new data record first", "Information");
                    return;
                }
                string status = lblCanceled.Text;  // Get the status from lblCanceled

                // Update the status in the database
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "UPDATE HTA_InternalPO SET status = @status WHERE ref_InternalPO = @ref_InternalPO";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@ref_InternalPO", currentRefCode);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Status updated successfully", "Information");

                btnDraft.Visible = true;
                btnRequest.Visible = false;
                btnAccepted.Visible = false;
                btnPurchased.Visible = false;
                btnPartialDelivery.Visible = false;
                btnReceived.Visible = false;
                btnCancel.Visible = false;
                btnRefused.Visible = false;

                lblDraft.BackColor = Color.DarkGray;
                pnlDraft.ArrowColor = Color.DarkGray;
                lblRequested.BackColor = Color.DarkGray;
                pnlRequested.ArrowColor = Color.DarkGray;
                lblAccepted.BackColor = Color.DarkGray;
                pnlAccepted.ArrowColor = Color.DarkGray;
                lblPurchased.BackColor = Color.DarkGray;
                pnlPurchased.ArrowColor = Color.DarkGray;
                lblPartialDelivery.BackColor = Color.DarkGray;
                pnlPartialDelivery.ArrowColor = Color.DarkGray;
                lblCanceled.BackColor = Color.RoyalBlue;
                pnlCanceled.ArrowColor = Color.RoyalBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }

        }

        private bool IsRecordReceived(string refCode)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT status FROM HTA_InternalPO WHERE ref_InternalPO = @ref_InternalPO";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ref_InternalPO", refCode);

                var result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null && result.ToString() == lblReceived.Text)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        private void btnRefused_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsRecordReceived(currentRefCode))
                {
                    MessageBox.Show("Make new data record first", "Information");
                    return;
                }
                string status = lblRefused.Text;  // Get the status from lblCanceled

                // Update the status in the database
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "UPDATE HTA_InternalPO SET status = @status WHERE ref_InternalPO = @ref_InternalPO";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@ref_InternalPO", currentRefCode);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Status updated successfully", "Information");

                btnDraft.Visible = true;
                btnRequest.Visible = false;
                btnAccepted.Visible = false;
                btnPurchased.Visible = false;
                btnPartialDelivery.Visible = false;
                btnReceived.Visible = false;
                btnCancel.Visible = false;
                btnRefused.Visible = false;

                lblDraft.BackColor = Color.DarkGray;
                pnlDraft.ArrowColor = Color.DarkGray;
                lblRequested.BackColor = Color.DarkGray;
                pnlRequested.ArrowColor = Color.DarkGray;
                lblAccepted.BackColor = Color.DarkGray;
                pnlAccepted.ArrowColor = Color.DarkGray;
                lblPurchased.BackColor = Color.DarkGray;
                pnlPurchased.ArrowColor = Color.DarkGray;
                lblPartialDelivery.BackColor = Color.DarkGray;
                pnlPartialDelivery.ArrowColor = Color.DarkGray;
                lblRefused.BackColor = Color.RoyalBlue;
                pnlRefused.ArrowColor = Color.RoyalBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }

        }


        public class Company
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class StockLocation
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void btnDraft_Click(object sender, EventArgs e)
        {
            cmbCompany.SelectedIndex = -1;
            cmbStockLocation.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            rtbDescNotes.Clear();


            btnDraft.Visible = false;
            btnRequest.Visible = true;
            btnAccepted.Visible = false;
            btnPurchased.Visible = false;
            btnPartialDelivery.Visible = false;
            btnReceived.Visible = false;
            btnCancel.Visible = true;
            btnRefused.Visible = true;

            lblDraft.BackColor = Color.RoyalBlue;
            pnlDraft.ArrowColor = Color.RoyalBlue;
            lblReceived.BackColor = Color.DarkGray;
            pnlReceived.ArrowColor = Color.DarkGray;
            lblCanceled.BackColor = Color.DarkGray;
            pnlCanceled.ArrowColor = Color.DarkGray;
            lblRefused.BackColor = Color.DarkGray;
            pnlRefused.ArrowColor = Color.DarkGray;

            if (IsRecordReceived(currentRefCode))
            {
                MessageBox.Show("The previous record is finished. Ready to create a new purchase quotation. Please enter the new details and click 'Request'.", "Information");
            }
            else
            {
                MessageBox.Show("Ready to create a new purchase quotation. Please enter the new details and click 'Request'.", "Information");
            }
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            try
            {
                string status = lblAccepted.Text;  // Get the status from lblCanceled

                // Update the status in the database
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "UPDATE HTA_InternalPO SET status = @status WHERE ref_InternalPO = @ref_InternalPO";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@ref_InternalPO", currentRefCode);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Status updated successfully", "Information");

                btnDraft.Visible = false;
                btnRequest.Visible = false;
                btnAccepted.Visible = false;
                btnPurchased.Visible = true;
                btnPartialDelivery.Visible = false;
                btnReceived.Visible = false;

                lblRequested.BackColor = Color.DarkGray;
                pnlRequested.ArrowColor = Color.DarkGray;
                lblAccepted.BackColor = Color.RoyalBlue;
                pnlAccepted.ArrowColor = Color.RoyalBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private void btnPurchased_Click(object sender, EventArgs e)
        {
            try
            {
                string status = lblPurchased.Text;  // Get the status from lblCanceled

                // Update the status in the database
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "UPDATE HTA_InternalPO SET status = @status WHERE ref_InternalPO = @ref_InternalPO";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@ref_InternalPO", currentRefCode);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Status updated successfully", "Information");

                btnDraft.Visible = false;
                btnRequest.Visible = false;
                btnAccepted.Visible = false;
                btnPurchased.Visible = false;
                btnPartialDelivery.Visible = true;
                btnReceived.Visible = false;

                lblAccepted.BackColor = Color.DarkGray;
                pnlAccepted.ArrowColor = Color.DarkGray;
                lblPurchased.BackColor = Color.RoyalBlue;
                pnlPurchased.ArrowColor = Color.RoyalBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private void btnPartialDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                string status = lblPurchased.Text;  // Get the status from lblCanceled

                // Update the status in the database
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "UPDATE HTA_InternalPO SET status = @status WHERE ref_InternalPO = @ref_InternalPO";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@ref_InternalPO", currentRefCode);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Status updated successfully", "Information");

                btnDraft.Visible = false;
                btnRequest.Visible = false;
                btnAccepted.Visible = false;
                btnPurchased.Visible = false;
                btnPartialDelivery.Visible = false;
                btnReceived.Visible = true;

                lblPurchased.BackColor = Color.DarkGray;
                pnlPurchased.ArrowColor = Color.DarkGray;
                lblPartialDelivery.BackColor = Color.RoyalBlue;
                pnlPartialDelivery.ArrowColor = Color.RoyalBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }

        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            try
            {
                string status = lblReceived.Text;  // Get the status from lblCanceled

                // Update the status in the database
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "UPDATE HTA_InternalPO SET status = @status WHERE ref_InternalPO = @ref_InternalPO";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@ref_InternalPO", currentRefCode);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Status updated successfully", "Information");

                btnDraft.Visible = true;
                btnRequest.Visible = false;
                btnAccepted.Visible = false;
                btnPurchased.Visible = false;
                btnPartialDelivery.Visible = false;
                btnReceived.Visible = false;
                btnCancel.Visible = false;
                btnRefused.Visible = false;

                lblPartialDelivery.BackColor = Color.DarkGray;
                pnlPartialDelivery.ArrowColor = Color.DarkGray;
                lblReceived.BackColor = Color.RoyalBlue;
                pnlReceived.ArrowColor = Color.RoyalBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }

        }

        public class SupplierIntPO
        {
            public int Id { get; set; }
            public string RefSupplier { get; set; }
            public string Name { get; set; }
            public string Display => $"{RefSupplier} - {Name}";
        }

    }
}