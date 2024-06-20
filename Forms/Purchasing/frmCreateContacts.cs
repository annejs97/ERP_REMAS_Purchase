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
    
    public partial class frmCreateContacts : Form
    {
    
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=DBREMASFixed;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        string sql, sAction;
        int iID, idSupplier;

        public frmCreateContacts()
        {
            InitializeComponent();
            LoadCivility();
            LoadFunction();
            LoadManager();
            LoadLanguageContact();
            LoadCompanyName();
            LoadAccountOwner();
            LoadTeam();
            LoadCompanyAssociated();
            
        }

        private string GenerateNextReferenceCode()
        {
            string prefix = "P";
            int nextNumber = 1;

            string query = "SELECT MAX(Reference) FROM HTA_ContactInformation WHERE Reference LIKE @Prefix + '%'";
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
        public void LoadLanguageContact()
        {
            var categories = new List<LanguageContact>();

            try
            {
                conn.Open();
                const string query = "SELECT id_Language, Language_name FROM HTA_cmb_Language";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new LanguageContact
                        {
                            Id = (int)reader["id_Language"],
                            Name = reader["Language_name"].ToString()
                        });
                    }
                }

                cmbLangContact.DisplayMember = "Name";
                cmbLangContact.ValueMember = "Id";
                cmbLangContact.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading  language contact: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        public void LoadCompanyName()
        {
            var categories = new List<CompanyName>();

            try
            {
                conn.Open();
                const string query = "SELECT [Id supplier] AS IdSupplier, [Company name] AS CompanyName FROM HTA_Information";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new CompanyName
                        {
                            Id = (int)reader["IdSupplier"],
                            Name = reader["CompanyName"].ToString()
                        });
                    }
                }

                cmbCompanyName.DisplayMember = "Name";
                cmbCompanyName.ValueMember = "Id";
                cmbCompanyName.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading company name: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        public void LoadAccountOwner()
        {
            var categories = new List<AccOwner>();

            try
            {
                conn.Open();
                const string query = "SELECT id_employee, employee_name FROM HTA_cmb_Employee";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new AccOwner
                        {
                            Id = (int)reader["id_employee"],
                            Name = reader["employee_name"].ToString()
                        });
                    }
                }

                cmbAccountOwner.DisplayMember = "Name";
                cmbAccountOwner.ValueMember = "Id";
                cmbAccountOwner.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading account owner: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        public void LoadTeam()
        {
            var categories = new List<Team>();

            try
            {
                conn.Open();
                const string query = "SELECT id_team, team_name FROM HTA_cmb_Team";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Team
                        {
                            Id = (int)reader["id_team"],
                            Name = reader["team_name"].ToString()
                        });
                    }
                }

                cmbTeam.DisplayMember = "Name";
                cmbTeam.ValueMember = "Id";
                cmbTeam.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading team: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        public void LoadCompanyAssociated()
        {
            var categories = new List<CompanyAssociated>();

            try
            {
                conn.Open();
                const string query = "SELECT id_CompanyAssociated, CompanyAssociated_name FROM HTA_cmb_CompanyAssociated";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new CompanyAssociated
                        {
                            Id = (int)reader["id_CompanyAssociated"],
                            Name = reader["CompanyAssociated_name"].ToString()
                        });
                    }
                }

                cmbCompaniesAssoci.DisplayMember = "Name";
                cmbCompaniesAssoci.ValueMember = "Id";
                cmbCompaniesAssoci.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading associated company: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadCivility()
        {
            var categories = new List<Civility>();

            try
            {
                conn.Open();
                const string query = "SELECT id_civility, civility_name FROM HTA_cmb_Civility";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Civility
                        {
                            Id = (int)reader["id_civility"],
                            Name = reader["civility_name"].ToString()
                        });
                    }
                }

                cmbCivility.DisplayMember = "Name";
                cmbCivility.ValueMember = "Id";
                cmbCivility.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading civility: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadFunction()
        {
            var categories = new List<Functions>();

            try
            {
                conn.Open();
                const string query = "SELECT id_Function, function_name FROM HTA_cmb_Functions";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Functions
                        {
                            Id = (int)reader["id_Function"],
                            Name = reader["function_name"].ToString()
                        });
                    }
                }

                cmbFunction.DisplayMember = "Name";
                cmbFunction.ValueMember = "Id";
                cmbFunction.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading functions: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadManager()
        {
            var categories = new List<Manager>();

            try
            {
                conn.Open();
                const string query = "SELECT id_manager, manager_name FROM HTA_cmb_Manager";

                using (cmd = new SqlCommand(query, conn))
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Manager
                        {
                            Id = (int)reader["id_manager"],
                            Name = reader["manager_name"].ToString()
                        });
                    }
                }

                cmbRepTo.DisplayMember = "Name";
                cmbRepTo.ValueMember = "Id";
                cmbRepTo.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading manager: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmCreateContacts_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string refCode = GenerateNextReferenceCode();
                if (conn.State == ConnectionState.Closed) conn.Open();
                sql = "HTA_sp_InsertContact";
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@reference", refCode);
                cmd.Parameters.AddWithValue("@civility", ((Civility)cmbCivility.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@name", txbName.Texts);
                cmd.Parameters.AddWithValue("@firstName", txbFirstName.Texts);
                cmd.Parameters.AddWithValue("@main_comp", ((CompanyName)cmbCompanyName.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@function", ((Functions)cmbFunction.SelectedItem).Name);  // Ensure this is the ID
                cmd.Parameters.AddWithValue("@reportsTo", ((Manager)cmbRepTo.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@fixedPhone", txbFixeductCont.Texts);
                cmd.Parameters.AddWithValue("@mobilephone", txbMobileuctCont.Texts);
                cmd.Parameters.AddWithValue("@email", txbEmailuctCont.Texts);
                cmd.Parameters.AddWithValue("@fax", txbFaxuctCont.Texts);
                cmd.Parameters.AddWithValue("@address", txbAddress.Texts);
                cmd.Parameters.AddWithValue("@timeSlot", rtbTimeSlot.Text);
                cmd.Parameters.AddWithValue("@lang", ((LanguageContact)cmbLangContact.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@acc_owner", ((AccOwner)cmbAccountOwner.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@team", ((Team)cmbTeam.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@comp_to", ((CompanyAssociated)cmbCompaniesAssoci.SelectedItem).Name);
                cmd.Parameters.AddWithValue("@notes", rtbNotes.Text);
                cmd.Parameters.AddWithValue("@supplier", idSupplier); // Use the idSupplier obtained from cmbCompanyName

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Insert data successfully", "Information");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
                conn.Close();
            }
        }

        private void btnLanguageCont_Click(object sender, EventArgs e)
        {

        }

        private void pnlSettingCont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCompanyName_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompanyName.SelectedItem != null)
            {
                // Get the selected company name
                string companyName = ((CompanyName)cmbCompanyName.SelectedItem).Name;

                try
                {
                    // Open the connection if it's not already open
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    // Query to fetch the Id of the selected company from HTA_Information
                    string query = "SELECT [Id supplier] FROM HTA_Information WHERE [Company name] = @CompanyName";

                    using (cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter for the company name
                        cmd.Parameters.AddWithValue("@CompanyName", companyName);

                        // Execute the query
                        object result = cmd.ExecuteScalar();

                        // Check if a result is obtained
                        if (result != null && result != DBNull.Value)
                        {
                            // Store the Id supplier in a variable for later use
                            idSupplier = (int)result;
                        }
                        else
                        {
                            // If no result is obtained, show a message
                            MessageBox.Show("No supplier found for the selected company.", "Information");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Show error message if an exception occurs
                    MessageBox.Show($"Error fetching supplier information: {ex.Message}", "Error");
                }
                finally
                {
                    // Close the connection
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Civility
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Functions
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CompanyName
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class LanguageContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
