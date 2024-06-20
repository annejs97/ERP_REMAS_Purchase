using Microsoft.Reporting.Map.WebForms.BingMaps;
using REMAS.Contoller;
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
    public partial class frmNewSuppliers : Form
    {
        private readonly SqlConnection _conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBREMASFixed;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private SqlCommand _cmd;
        private SqlDataReader _reader;
        string Config, Verify, Blocking_Type;
        private string _supplierRef;


        public frmNewSuppliers(string supplierRef = null)
        {
            InitializeComponent();
            ClearInformation();
            LoadComboBoxes();

            if (!string.IsNullOrEmpty(supplierRef))
            {
                _supplierRef = supplierRef;
                LoadSupplierData();
            }
        }

        private void LoadSupplierData()
        {
            try
            {
                string sql = "SELECT * FROM HTA_Information WHERE [Ref supplier] = @SupplierRef";
                _conn.Open();
                using (_cmd = new SqlCommand(sql, _conn))
                {
                    _cmd.Parameters.AddWithValue("@SupplierRef", _supplierRef);
                    using (SqlDataReader reader = _cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txbCompanyName.Texts = reader["Company Name"].ToString();
                            txbAddresses.Texts = reader["Addresses"].ToString();
                            txbFixedPhone.Texts = reader["Fixed Phone"].ToString();
                            txbFaxuctInf.Texts = reader["Fax"].ToString();
                            txbMobileuctInf.Texts = reader["Mobile Phone"].ToString();
                            txbEmailuctInf.Texts = reader["Email"].ToString();
                            txbWebuctInf.Texts = reader["Website"].ToString();
                            txbRegCode.Texts = reader["Registration code"].ToString();
                            txbTaxN.Texts = reader["Tax N"].ToString();
                            cmbLanguage.SelectedItem = reader["Language"].ToString();
                            cmbAccountOwner.SelectedItem = reader["Account owner"].ToString();
                            cmbTeam.SelectedItem = reader["Team"].ToString();
                            cmbCategoryuctInf.SelectedItem = reader["Category"].ToString();
                            cmbIndustryuctInf.SelectedItem = reader["Industri Sector"].ToString();
                            cmbSourceuctInf.SelectedItem = reader["Source"].ToString();
                            txbDeptDiv.Texts = reader["Dept/Div"].ToString();
                            cmbCompaniesAssoci.SelectedItem = reader["Company Associated"].ToString();
                            nudTurnoveructInf.Value = Convert.ToDecimal(reader["Turn Over"]);
                            nudEmployeesuctInf.Value = Convert.ToDecimal(reader["Employee"]);
                            nudPaymentuctInf.Value = Convert.ToDecimal(reader["Payment delay"]);
                            rtbNotes.Text = reader["Note"].ToString();

                            chbSupplier.Checked = reader["Partner type"] != DBNull.Value && reader["Partner type"].ToString() == "Supplier";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplier data: {ex.Message}");
            }
            finally
            {
                _conn.Close();
            }
        }

        #region Clear Text After Save
        private void ClearInformation()
        {
            txbCompanyName.Clear();
            txbAddresses.Clear();
            txbFixedPhone.Clear();
            txbFaxuctInf.Clear();
            txbMobileuctInf.Clear();
            txbEmailuctInf.Clear();
            txbWebuctInf.Clear();
            txbRegCode.Clear();
            txbTaxN.Clear();
            cmbLanguage.SelectedIndex = -1;
            cmbAccountOwner.SelectedIndex = -1;
            cmbTeam.SelectedIndex = -1;
            cmbCategoryuctInf.SelectedIndex = -1;
            cmbIndustryuctInf.SelectedIndex = -1;
            cmbSourceuctInf.SelectedIndex = -1;
            txbDeptDiv.Clear();
            cmbCompaniesAssoci.SelectedIndex = -1;
            nudTurnoveructInf.Value = 0;
            nudEmployeesuctInf.Value = 0;
            nudPaymentuctInf.Value = 0;
            rtbNotes.Clear();
        }
        #endregion



        #region Load ComboBoxes
        private void LoadComboBoxes()
        {
            LoadComboBox("SELECT id_category, Category FROM HTA_cmb_Category", cmbCategoryuctInf, "Category", "id_category");
            LoadComboBox("SELECT id_industrysect, industrySector FROM HTA_cmb_IndustrySector", cmbIndustryuctInf, "industrySector", "id_industrysect");
            LoadComboBox("SELECT id_source, source FROM HTA_cmb_Source", cmbSourceuctInf, "source", "id_source");
            LoadComboBox("SELECT id_Language, Language_name FROM HTA_cmb_Language", cmbLanguage, "Language_name", "id_Language");
            LoadComboBox("SELECT id_employee, employee_name FROM HTA_cmb_Employee", cmbAccountOwner, "employee_name", "id_employee");
            LoadComboBox("SELECT id_team, team_name FROM HTA_cmb_Team", cmbTeam, "team_name", "id_team");
            LoadComboBox("SELECT id_CompanyAssociated, CompanyAssociated_name FROM HTA_cmb_CompanyAssociated", cmbCompaniesAssoci, "CompanyAssociated_name", "id_CompanyAssociated");
            LoadComboBox("SELECT id_InvoiceSend, InvoiceSend_name FROM HTA_cmb_InvoiceSend", cmbInvoiceSending, "InvoiceSend_name", "id_InvoiceSend");
            LoadComboBox("SELECT id_InPayment, InPayment_name FROM HTA_cmb_InPayment", cmbInPayment, "InPayment_name", "id_InPayment");
            LoadComboBox("SELECT id_OutPayment, OutPayment_name FROM HTA_cmb_OutPayment", cmbOutPayment, "OutPayment_name", "id_OutPayment");
            LoadComboBox("SELECT id_PaymentCondition, PaymentCondition_name FROM HTA_cmb_PaymentCondition", cmbPaymentCondition, "PaymentCondition_name", "id_PaymentCondition");
            LoadComboBox("SELECT id_Currency, Currency_name FROM HTA_cmb_Currency", cmbCurrency, "Currency_name", "id_Currency");
            LoadComboBox("SELECT id_FiscalPos, FiscalPos_name FROM HTA_cmb_FiscalPos", cmbFiscalPosition, "FiscalPos_name", "id_FiscalPos");
            LoadComboBox("SELECT id_AnalyticDis, AnalyticDis_name FROM HTA_cmb_AnalyticDis", cmbAnalyticTemp, "AnalyticDis_name", "id_AnalyticDis");
            LoadComboBox("SELECT id_BankDetails, BankDetails_name FROM HTA_cmb_BankDetails", cmbBankDetails, "BankDetails_name", "id_BankDetails");
            LoadComboBox("SELECT id_CompanyAssociated, CompanyAssociated_name FROM HTA_cmb_CompanyAssociated", cmbCompany, "CompanyAssociated_name", "id_CompanyAssociated");
            LoadComboBox("SELECT id_CustomerAccount, CustomerAccount_name FROM HTA_cmb_CustomerAccount", cmbCustomerAcc, "CustomerAccount_name", "id_CustomerAccount");
            LoadComboBox("SELECT contact_id, first_name FROM HTA_ContactInformation", cmbSupplierAcc, "first_name", "contact_id");
            LoadComboBox("SELECT id_employee, employee_name FROM HTA_cmb_Employee", cmbEmployeeAcc, "employee_name", "id_BankDetails");
            LoadComboBox("SELECT id_purchaseQR, quality_rating FROM HTA_cmb_PurchaseQualityRating", cmbSupplQualityRating, "quality_rating", "id_purchaseQR");
            LoadComboBox("SELECT id_purchasePL, pricelistName FROM HTA_cmb_PurchasePriceList", cmbPurchasePriceList, "pricelistName", "id_purchasePL");
            LoadComboBox("SELECT id_ShipmentMode, shipmentMode FROM HTA_cmb_ShipmentMode", cmbShipmentMode, "shipmentMode", "id_ShipmentMode");
            LoadComboBox("SELECT [Id supplier] AS IdSupplier, [Company name] AS CompanyName FROM HTA_Information", cmbCompanies, "CompanyName", "IdSupplier");
            LoadComboBox("SELECT id_blockingReason, blockingReason FROM HTA_cmb_BlockingReason", cmbBlockingReason, "blockingReason", "id_blockingReason");
            LoadComboBox("SELECT id_employee, employee_name FROM HTA_cmb_Employee", cmbBlockingDoneBy, "employee_name", "id_employee");
        }

        private void LoadComboBox(string query, RJComboBox comboBox, string displayMember, string valueMember)
        {
            var categories = new List<dynamic>();

            try
            {
                _conn.Open();
                categories.Add(new { Id = -1, Name = "NULL" });

                using (_cmd = new SqlCommand(query, _conn))
                using (_reader = _cmd.ExecuteReader())
                {
                    while (_reader.Read())
                    {
                        categories.Add(_reader[displayMember].ToString());
                    }
                }

                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "Id";
                comboBox.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading {comboBox.Name}: {ex.Message}");
            }
            finally
            {
                _conn.Close();
            }
        }
        #endregion

        #region Create Data Tab
        private string GenerateNextReferenceCode()
        {
            string prefix = "SP";
            int nextNumber = 1;

            string query = "SELECT MAX([Ref supplier]) FROM HTA_Information WHERE [Ref supplier] LIKE @Prefix + '%'";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@Prefix", prefix);

            if (_conn.State == ConnectionState.Closed) _conn.Open();
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
            _conn.Close();


            int paddingLength = Math.Max(4, nextNumber.ToString().Length);
            return $"{prefix}{nextNumber.ToString().PadLeft(paddingLength, '0')}";
        }
        private void LoadCategories()
        {
            var categories = new List<Category>();

            try
            {
                _conn.Open();
                const string query = "SELECT id_category, Category FROM HTA_cmb_Category";

                categories.Add(new Category { Id = -1, Name = "NULL" });

                using (_cmd = new SqlCommand(query, _conn))
                using (_reader = _cmd.ExecuteReader())
                {
                    while (_reader.Read())
                    {
                        categories.Add(new Category
                        {
                            Id = (int)_reader["id_category"],
                            Name = _reader["Category"].ToString()
                        });
                    }
                }

                cmbCategoryuctInf.DisplayMember = "Name";
                cmbCategoryuctInf.ValueMember = "Id";
                cmbCategoryuctInf.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}");
            }
            finally
            {
                _conn.Close();
            }
        }


        private int SaveDataInformation()
        {
            int supplierId = -1;
            try
            {
                string refCode = GenerateNextReferenceCode();
                _conn.Open();
                string sql = "HTA_sp_InsertInformation";
                _cmd = new SqlCommand(sql, _conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                _cmd.Parameters.AddWithValue("@refSupplier", refCode);
                _cmd.Parameters.AddWithValue("@partnerType", Verify);
                _cmd.Parameters.AddWithValue("@compName", txbCompanyName.Text);
                _cmd.Parameters.AddWithValue("@addresses", txbAddresses.Text);
                _cmd.Parameters.AddWithValue("@fixedphone", txbFixedPhone.Text);
                _cmd.Parameters.AddWithValue("@fax", txbFaxuctInf.Text);
                _cmd.Parameters.AddWithValue("@mobilephone", txbMobileuctInf.Text);
                _cmd.Parameters.AddWithValue("@category", ((Category)cmbCategoryuctInf.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@email", txbEmailuctInf.Text);
                _cmd.Parameters.AddWithValue("@website", txbWebuctInf.Text);
                _cmd.Parameters.AddWithValue("@industrisector", ((IndustrySector)cmbIndustryuctInf.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@turnover", nudTurnoveructInf.Value);
                _cmd.Parameters.AddWithValue("@employee", nudEmployeesuctInf.Value);
                _cmd.Parameters.AddWithValue("@source", ((Source)cmbSourceuctInf.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@deptdiv", txbDeptDiv.Text);
                _cmd.Parameters.AddWithValue("@regcode", txbRegCode.Text);
                _cmd.Parameters.AddWithValue("@taxn", txbTaxN.Text);
                _cmd.Parameters.AddWithValue("@paymentdelay", nudPaymentuctInf.Value);
                _cmd.Parameters.AddWithValue("@lang", ((Language)cmbLanguage.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@accowner", ((AccOwner)cmbAccountOwner.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@team", ((Team)cmbTeam.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@companyassoci", ((CompanyAssociated)cmbCompaniesAssoci.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@note", rtbNotes.Text);

                SqlParameter outputParam = new SqlParameter("@SupplierId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                _cmd.Parameters.Add(outputParam);
                _cmd.ExecuteNonQuery();
                supplierId = Convert.ToInt32(outputParam.Value);

                MessageBox.Show("Insert data information successfully", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
            finally
            {
                _conn.Close();
                ClearInformation();
            }
            return supplierId;
        }

        private void SaveDataInvoicing(int supplierId)
        {
            try
            {
                _conn.Open();
                string sql = "HTA_sp_InPayment";
                _cmd = new SqlCommand(sql, _conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _cmd.Parameters.AddWithValue("@invoiceSendMedia", ((InvoiceSend)cmbInvoiceSending.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@inPaymentMode", ((InPay)cmbInPayment.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@outPaymentMode", ((OutPay)cmbOutPayment.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@paymentCond", ((PayCondi)cmbPaymentCondition.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@currency", ((Currencies)cmbCurrency.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@fiscalPosition", ((FiscalPos)cmbFiscalPosition.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@analyticDist", ((AnalyticDistri)cmbAnalyticTemp.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@bankDetails", ((BankDetails)cmbBankDetails.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@supplier", supplierId);

                _cmd.ExecuteNonQuery();

                MessageBox.Show("Insert Data invoicing Successfully", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
            finally
            {
                _conn.Close();
            }
        }

        private void SaveDataAccountingSituation(int supplierId, string config)
        {
            try
            {
                _conn.Open();
                string sql = "HTA_sp_InsertAccSituation";
                _cmd = new SqlCommand(sql, _conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _cmd.Parameters.AddWithValue("@company", ((CompanyAccSitu)cmbCompany.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@Cust_Acc", ((CustomerAccount)cmbCustomerAcc.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@Supplier_Acc", ((SupplierAccount)cmbSupplierAcc.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@Employee_Acc", ((EmployeeAccount)cmbEmployeeAcc.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@Invoice_Verif", config);
                _cmd.Parameters.AddWithValue("@Payment_Delay", nudPaymentdelay.Value);
                _cmd.Parameters.AddWithValue("@supplier", supplierId);

                _cmd.ExecuteNonQuery();

                MessageBox.Show("Insert Data accounting situation Successfully", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
            finally
            {
                _conn.Close();
            }
        }

        private void SaveDataBlocking(int supplierId)
        {
            try
            {
                _conn.Open();
                string sql = "HTA_sp_Blocking";
                _cmd = new SqlCommand(sql, _conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _cmd.Parameters.AddWithValue("@companies", ((CompaniesBlocking)cmbCompanies.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@blockingType", Blocking_Type);
                _cmd.Parameters.AddWithValue("@blockUntil", dtpBlockUntil.Value);
                _cmd.Parameters.AddWithValue("@blockingReason", ((BlockingReason)cmbBlockingReason.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@blockingDoneBy", ((BlockingDoneBy)cmbBlockingDoneBy.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@supplier", supplierId);

                _cmd.ExecuteNonQuery();

                MessageBox.Show("Insert Data Blocking Successfully", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
            finally
            {
                _conn.Close();
            }
        }

        private void SaveDataSupplier(int supplierId)
        {
            try
            {
                _conn.Open();
                string sql = "HTA_sp_InsertSupplier";
                _cmd = new SqlCommand(sql, _conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _cmd.Parameters.AddWithValue("@notesPO", rtbPurchaseOrderInfo.Text);
                _cmd.Parameters.AddWithValue("@purchPList", ((PurchasePList)cmbPurchasePriceList.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@supplierQRate", ((SupplierQRate)cmbSupplQualityRating.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@supplierArrvQty", nudSupplProductQty.Value);
                _cmd.Parameters.AddWithValue("@supplier", supplierId);

                _cmd.ExecuteNonQuery();

                MessageBox.Show("Insert Data Supplier Successfully", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
            finally
            {
                _conn.Close();
            }
        }

        private void SaveDataDelivery(int supplierId)
        {
            try
            {
                _conn.Open();
                string sql = "HTA_sp_InsertDelivery";
                _cmd = new SqlCommand(sql, _conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _cmd.Parameters.AddWithValue("@deliverDelay", nudDeliveryDelay.Value);
                _cmd.Parameters.AddWithValue("@shipMode", ((ShipmentMode)cmbShipmentMode.SelectedItem).Name);
                _cmd.Parameters.AddWithValue("@supplier", supplierId);

                _cmd.ExecuteNonQuery();

                MessageBox.Show("Insert Data Delivery Successfully", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }
            finally
            {
                _conn.Close();
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_supplierRef))
            {
                UpdateSupplierData();
            }
            else
            {
                int supplierId = SaveDataInformation();
                if (supplierId > 0)
                {
                    SaveDataInvoicing(supplierId);
                    SaveDataAccountingSituation(supplierId, Config);
                    SaveDataBlocking(supplierId);
                    SaveDataSupplier(supplierId);
                    SaveDataDelivery(supplierId);
                }
            }
        }

        private void UpdateSupplierData()
        {
            try
            {
                _conn.Open();
                string sql = "UPDATE HTA_Information SET " +
                             "[Company Name] = @CompanyName, " +
                             "[Addresses] = @Addresses, " +
                             "[Fixed Phone] = @FixedPhone, " +
                             "[Fax] = @Fax, " +
                             "[Mobile Phone] = @MobilePhone, " +
                             "[Email] = @Email, " +
                             "[Website] = @Website, " +
                             "[Registration code] = @RegCode, " +
                             "[Tax N] = @TaxN, " +
                             "[Language] = @Language, " +
                             "[Account owner] = @AccountOwner, " +
                             "[Team] = @Team, " +
                             "[Category] = @Category, " +
                             "[Industri Sector] = @IndustrySector, " +
                             "[Source] = @Source, " +
                             "[Dept/Div] = @DeptDiv, " +
                             "[Company Associated] = @CompanyAssociated, " +
                             "[Turn Over] = @TurnOver, " +
                             "[Employee] = @Employee, " +
                             "[Payment delay] = @PaymentDelay, " +
                             "[Note] = @Note " +
                             "WHERE [Ref supplier] = @SupplierRef";

                using (var _cmd = new SqlCommand(sql, _conn))
                {
                    // Use the null-coalescing operator to handle null values
                    _cmd.Parameters.AddWithValue("@CompanyName", txbCompanyName.Texts);
                    _cmd.Parameters.AddWithValue("@Addresses", txbAddresses.Texts);
                    _cmd.Parameters.AddWithValue("@FixedPhone", txbFixedPhone.Texts);
                    _cmd.Parameters.AddWithValue("@Fax", txbFaxuctInf.Texts);
                    _cmd.Parameters.AddWithValue("@MobilePhone", txbMobileuctInf.Texts);
                    _cmd.Parameters.AddWithValue("@Email", txbEmailuctInf.Texts);
                    _cmd.Parameters.AddWithValue("@Website", txbWebuctInf.Texts);
                    _cmd.Parameters.AddWithValue("@RegCode", txbRegCode.Texts);
                    _cmd.Parameters.AddWithValue("@TaxN", txbTaxN.Texts);
                    _cmd.Parameters.AddWithValue("@Language", cmbLanguage.SelectedItem.ToString());
                    _cmd.Parameters.AddWithValue("@AccountOwner", cmbAccountOwner.SelectedItem.ToString());
                    _cmd.Parameters.AddWithValue("@Team", cmbTeam?.SelectedItem.ToString());
                    _cmd.Parameters.AddWithValue("@Category", cmbCategoryuctInf.SelectedItem.ToString());
                    _cmd.Parameters.AddWithValue("@IndustrySector", cmbIndustryuctInf.SelectedItem.ToString());
                    _cmd.Parameters.AddWithValue("@Source", cmbSourceuctInf.SelectedItem.ToString());
                    _cmd.Parameters.AddWithValue("@DeptDiv", txbDeptDiv.Text);
                    _cmd.Parameters.AddWithValue("@CompanyAssociated", cmbCompaniesAssoci.SelectedItem.ToString());
                    _cmd.Parameters.AddWithValue("@TurnOver", nudTurnoveructInf.Value);
                    _cmd.Parameters.AddWithValue("@Employee", nudEmployeesuctInf.Value);
                    _cmd.Parameters.AddWithValue("@PaymentDelay", nudPaymentuctInf.Value);
                    _cmd.Parameters.AddWithValue("@Note", rtbNotes.Text);
                    _cmd.Parameters.AddWithValue("@SupplierRef", _supplierRef);

                    _cmd.Parameters.AddWithValue("@IsSupplier", chbSupplier?.Checked == true ? "Supplier" : string.Empty);

                    _cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier data updated successfully", "Information");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating supplier data: {ex.Message}");
            }
            finally
            {
                _conn.Close();
            }
        }

        private void btnOkAccountingSituation_Click(object sender, EventArgs e)
        {
            int supplierId = SaveDataInformation();
            if (supplierId > 0)
            {
                SaveDataAccountingSituation(supplierId, Config);
            }
        }

        private void LoadDataTblSupplier()
        {
            try
            {
                _conn.Open();
                string sql = "SELECT * FROM PopupSupl";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPurchaseSupl.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        private void btnPlustbcsupl_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (frmPopupSupl uu = new frmPopupSupl())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
            LoadDataTblSupplier();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Checklist Code
        private void rdbPurchaseBlocking_CheckedChanged(object sender, EventArgs e)
        {
            Blocking_Type = "Purchase blocking";
        }

        private void rdbDebitBlocking_CheckedChanged(object sender, EventArgs e)
        {
            Blocking_Type = "Debit blocking";
        }

        private void rdbReminderBlocking_CheckedChanged(object sender, EventArgs e)
        {
            Blocking_Type = "Reminder blocking";
        }

        private void rdbSaleBlocking_CheckedChanged(object sender, EventArgs e)
        {
            Blocking_Type = "Sale blocking";
        }

        private void rdbInvoicingBlocking_CheckedChanged(object sender, EventArgs e)
        {
            Blocking_Type = "Invoicing blocking";
        }

        private void rdbRefundBlocking_CheckedChanged(object sender, EventArgs e)
        {
            Blocking_Type = "Refund blocking";
        }

        private void chbPrespect_CheckedChanged(object sender, EventArgs e)
        {
            Verify = "Prespect";
        }

        private void chbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            Verify = "Customer";
        }

        private void chbSupplier_CheckedChanged(object sender, EventArgs e)
        {
            Verify = "Supplier";
        }

        private void chbCarrier_CheckedChanged_1(object sender, EventArgs e)
        {
            Verify = "Carrier";
        }

        private void ckbInvoiceVerification_CheckedChanged(object sender, EventArgs e)
        {
            Config = "Send email on invoice verification";
        }
        #endregion

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBlockUntil != null)
                txbBlockUntil.Text = dtpBlockUntil.Value.ToString();
        }
    }

    #region Declare Classes
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Source
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class IndustrySector
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CompanyAssociated
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CompanyAccSitu
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class AccOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class InvoiceSend
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class InPay
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class OutPay
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PayCondi
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Currencies
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class FiscalPos
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class AnalyticDistri
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BankDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CustomerAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SupplierAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CompaniesBlocking
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BlockingReason
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BlockingDoneBy
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PurchasePList
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SupplierQRate
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ShipmentMode
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    #endregion
}