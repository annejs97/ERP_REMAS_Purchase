using REMAS.Forms.Account;
using REMAS.Forms.Custom;
using REMAS.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS.Forms.Sales
{
    public partial class fmCustomer : Form
    {
        string sql, sSearch;
        Form form = new Form();
        Security crypto;
        RunQuery qu_All;
        CallForm callForm;
        DataTable myData, myData2;
        myMsgBox messageBox;
        public fmCustomer()
        {
            InitializeComponent();
        }

        private void dgCustList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sSearch = dgCustList.Columns[e.ColumnIndex].Name;
            lbSearch.Text = "Search By " + dgCustList.Columns[e.ColumnIndex].HeaderText;
            txtSearch.Clear();
            if (txtSearch.CanFocus) { txtSearch.Focus(); }                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form = new fmAddMasCust("", "N");
            form.ShowDialog();
        }

        private void fmCustomer_Load(object sender, EventArgs e)
        {
            sSearch = "CustName";
            lbSearch.Text = "Customer";
            GetListCustomer();
        }

        void GetListCustomer()
        {
            sql = " Select Top 1000 * from MsCustomer Where " + sSearch + " like '%" + txtSearch.Text + "%' ";

        }
    }
}
