using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static REMAS.Forms.Purchasing.frmInternalPurchaseRequest;

namespace REMAS
{
    public partial class frmPurchaseQuotations : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBREMASFixed;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd;
        SqlDataReader reader;
        string sql, sAction, check;
        int iID, idSupplier;

        public frmPurchaseQuotations()
        {
            InitializeComponent();
            cmbSupplier.OnSelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
        }

        private void frmPurchaseQuotations_Load(object sender, EventArgs e)
        {
            LoadCompany();
            LoadSupplier();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {

            try
            {
               
                string refCode = GenerateNextReferenceCode();
                string status = lblRequested.Text;
                var selectedContact = (ContactQ)cmbContact.SelectedItem;
                string refContact = selectedContact.RefContact;
                string contactName = selectedContact.FirstName;

                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "HTA_sp_InsertPurchaseQuotations";
                using (cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ref_PurchaseQuotations", refCode);
                    cmd.Parameters.AddWithValue("@compName", ((CompanyQ)cmbCompany.SelectedItem).Name);
                    cmd.Parameters.AddWithValue("@refSupplier", ((SupplyQ)cmbSupplier.SelectedItem).RefSupplier);
                    cmd.Parameters.AddWithValue("@supplierName", ((SupplyQ)cmbSupplier.SelectedItem).Name);
                    cmd.Parameters.AddWithValue("@currency", cmbCurrency.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@priceList", cmbPriceList.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@refContact", refContact);
                    cmd.Parameters.AddWithValue("@contact", contactName);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@descNote", txbInternalnot.Text);
                    cmd.Parameters.AddWithValue("@checklist", check);
                    cmd.Parameters.AddWithValue("@supplier", idSupplier);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Insert data successfully", "Information");

                currentRefCode = refCode;

                btnValidated.Visible = true;
                btnRequest.Visible = false;
                btnDraft.Visible = false;
                btnFinished.Visible = false;

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


        private void btnValidated_Click(object sender, EventArgs e)
        {
            try
            {
                string status = lblValidated.Text;  // Get the status from lblCanceled

                // Update the status in the database
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "UPDATE HTA_PurchaseQuotations SET status = @status WHERE ref_PurchaseQuotations = @ref_PurchaseQuotations";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@ref_PurchaseQuotations", currentRefCode);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Status updated successfully", "Information");

                btnValidated.Visible = false;
                btnRequest.Visible = false;
                btnDraft.Visible = false;
                btnFinished.Visible = true;

                lblRequested.BackColor = Color.DarkGray;
                pnlRequested.ArrowColor = Color.DarkGray;
                lblValidated.BackColor = Color.RoyalBlue;
                pnlValidated.ArrowColor = Color.RoyalBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            try
            {
                string status = lblFinished.Text;  // Get the status from lblCanceled

                // Update the status in the database
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "UPDATE HTA_PurchaseQuotations SET status = @status WHERE ref_PurchaseQuotations = @ref_PurchaseQuotations";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@ref_PurchaseQuotations", currentRefCode);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Status updated successfully", "Information");

                btnValidated.Visible = false;
                btnRequest.Visible = false;
                btnDraft.Visible = true;
                btnFinished.Visible = false;
                btnCancel.Visible = false;

                lblValidated.BackColor = Color.DarkGray;
                pnlValidated.ArrowColor = Color.DarkGray;
                lblFinished.BackColor = Color.RoyalBlue;
                pnlFinished.ArrowColor = Color.RoyalBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private bool IsRecordFinished(string refCode)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT status FROM HTA_PurchaseQuotations WHERE ref_PurchaseQuotations = @refCode";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@refCode", refCode);

                var result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null && result.ToString() == lblFinished.Text)
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

        private void btnDraft_Click(object sender, EventArgs e)
        {
            
            // Clear all input fields
            cmbCompany.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            cmbCurrency.SelectedIndex = -1;
            cmbPriceList.SelectedIndex = -1;
            cmbContact.SelectedIndex = -1;
            txbInternalnot.Clear();
            check = string.Empty;

            btnRequest.Visible = true;
            btnValidated.Visible = false;
            btnDraft.Visible = false;
            btnFinished.Visible = false;
            btnCancel.Visible = true;

            lblDraft.BackColor = Color.RoyalBlue;
            pnlDraft.ArrowColor = Color.RoyalBlue;
            lblFinished.BackColor = Color.DarkGray;
            pnlFinished.ArrowColor = Color.DarkGray;
            lblCanceled.BackColor = Color.DarkGray;
            pnlCanceled.ArrowColor = Color.DarkGray;

            if (IsRecordFinished(currentRefCode))
            {
                MessageBox.Show("The previous record is finished. Ready to create a new purchase quotation. Please enter the new details and click 'Request'.", "Information");
            }
            else
            {
                MessageBox.Show("Ready to create a new purchase quotation. Please enter the new details and click 'Request'.", "Information");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (IsRecordFinished(currentRefCode))
                {
                    MessageBox.Show("Make new data record first", "Information");
                    return;
                }
                string status = lblCanceled.Text;  // Get the status from lblCanceled

                // Update the status in the database
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "UPDATE HTA_PurchaseQuotations SET status = @status WHERE ref_PurchaseQuotations = @ref_PurchaseQuotations";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@ref_PurchaseQuotations", currentRefCode);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Status updated successfully", "Information");

                btnValidated.Visible = false;
                btnRequest.Visible = false;
                btnDraft.Visible = true;
                btnFinished.Visible = false;

                lblRequested.BackColor = Color.DarkGray;
                pnlRequested.ArrowColor = Color.DarkGray;
                lblDraft.BackColor = Color.DarkGray;
                pnlDraft.ArrowColor = Color.DarkGray;
                lblValidated.BackColor = Color.DarkGray;
                pnlValidated.ArrowColor = Color.DarkGray;
                lblFinished.BackColor = Color.DarkGray;
                pnlFinished.ArrowColor = Color.DarkGray;
                lblCanceled.BackColor = Color.RoyalBlue;
                pnlCanceled.ArrowColor = Color.RoyalBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
        }

        private string GenerateNextReferenceCode()
        {
            string prefix = "PQ";
            int nextNumber = 1;

            string query = "SELECT MAX(ref_PurchaseQuotations) FROM HTA_PurchaseQuotations WHERE ref_PurchaseQuotations LIKE @Prefix + '%'";
            using (cmd = new SqlCommand(query, conn))
            {
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
            }

            int paddingLength = Math.Max(4, nextNumber.ToString().Length);
            return $"{prefix}{nextNumber.ToString().PadLeft(paddingLength, '0')}";
        }

        public void LoadCompany()
        {
            var companies = new List<CompanyQ>();

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                const string query = "SELECT id_CompanyAssociated, CompanyAssociated_name FROM HTA_cmb_CompanyAssociated";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        companies.Add(new CompanyQ
                        {
                            Id = (int)reader["id_CompanyAssociated"],
                            Name = reader["CompanyAssociated_name"].ToString()
                        });
                    }
                }

                cmbCompany.DisplayMember = "Name";
                cmbCompany.ValueMember = "Id";
                cmbCompany.DataSource = companies;
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

        private string currentRefCode;

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedItem != null)
            {
                var selectedSupplier = (SupplyQ)cmbSupplier.SelectedItem;
                int supplierId = selectedSupplier.Id;
                idSupplier = selectedSupplier.Id;
                LoadCurrency(supplierId);
                LoadPriceList(supplierId);
                LoadContact(supplierId);
            }
        }

        private void chbInATI_CheckedChanged(object sender, EventArgs e)
        {
            check = "In ATI";
        }


        public void LoadSupplier()
        {
            var suppliers = new List<SupplyQ>();

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                const string query = "SELECT [Id supplier] AS idSupply, [Ref supplier] AS refSupplier, [Company name] AS compName FROM HTA_Information";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(new SupplyQ
                        {
                            Id = (int)reader["idSupply"],
                            RefSupplier = reader["refSupplier"].ToString(),
                            Name = reader["compName"].ToString()
                        });
                    }
                }

                cmbSupplier.DisplayMember = "Display";
                cmbSupplier.ValueMember = "Id";
                cmbSupplier.DataSource = suppliers;
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

        public void LoadCurrency(int supplierId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT [Currency] FROM HTA_InvoicingPayment WHERE id_supplier = @SupplierId";

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                    using (reader = cmd.ExecuteReader())
                    {
                        cmbCurrency.Items.Clear();
                        if (reader.Read())
                        {
                            cmbCurrency.Items.Add(reader["Currency"].ToString());
                            cmbCurrency.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbCurrency.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading currency data: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public void LoadPriceList(int supplierId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT [purchase_pList] FROM HTA_Supplier WHERE id_supplier = @SupplierId";

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                    using (reader = cmd.ExecuteReader())
                    {
                        cmbPriceList.Items.Clear();
                        if (reader.Read())
                        {
                            cmbPriceList.Items.Add(reader["purchase_pList"].ToString());
                            cmbPriceList.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbPriceList.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading price list data: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public void LoadContact(int supplierId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT Reference, first_name FROM HTA_ContactInformation WHERE id_supplier = @SupplierId";

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                    using (reader = cmd.ExecuteReader())
                    {
                        cmbContact.Items.Clear();
                        while (reader.Read())
                        {
                            string refContact = reader["Reference"].ToString();
                            string firstName = reader["first_name"].ToString();
                            cmbContact.Items.Add(new ContactQ { RefContact = refContact, FirstName = firstName });
                        }

                        if (cmbContact.Items.Count > 0)
                            cmbContact.SelectedIndex = 0;
                        else
                            cmbContact.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contact data: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
    }

    public class CompanyQ
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SupplyQ
    {
        public int Id { get; set; }
        public string RefSupplier { get; set; }
        public string Name { get; set; }
        public string Display => $"{RefSupplier} - {Name}";
    }

    public class CurrenciesQ
    {
        public string Name { get; set; }
    }

    public class PriceListQ
    {
        public string Name { get; set; }
    }

    public class ContactQ
    {
        public string RefContact { get; set; }
        public string FirstName { get; set; }

        public override string ToString()
        {
            return $"{RefContact} - {FirstName}";
        }
    }
}
