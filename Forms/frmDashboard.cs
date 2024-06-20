using REMAS.Forms.Purchasing;
using REMAS.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS.Forms
{
    public partial class frmDashboard : Form
    {
        private frmSuppliers suppliers;
        private frmContacts contacts;
        private frmProductservices products;
        private frmInternalPurchaseRequest IPR;
        private frmPurchaseQuotations PQ;
        private frmPurchaseOrders PO;
        private frmFinishOrders FO;
        private frmPurchaseBuyer PB;
        private frmPurchaseManager PM;
        private bool sidebarExpand;
        private bool homecollapse;
        private bool mastercollapse;
        private bool isCollapsed;
        private bool HistoricalCollapsed;
        private bool ReportingsCollapsed;

        public frmDashboard(string username)
        {
            InitializeComponent();
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e) { }

        private void btnDashboard_Click(object sender, EventArgs e) { }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            tmrPurchase.Start();
        }

        private void tmrPurchase_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnPurchase.Image = Resources.collapse_arrow_20;
                pnDropDownPurchase.Height += 10;
                if (pnDropDownPurchase.Size == pnDropDownPurchase.MaximumSize)
                {
                    tmrPurchase.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnPurchase.Image = Resources.expand_arrow_20;
                pnDropDownPurchase.Height -= 10;
                if (pnDropDownPurchase.Size == pnDropDownPurchase.MinimumSize)
                {
                    tmrPurchase.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnSales_Click(object sender, EventArgs e) { }

        private void btnProduction_Click(object sender, EventArgs e) { }

        private void btnHrd_Click(object sender, EventArgs e) { }

        private void pnlTop_Paint(object sender, PaintEventArgs e) { }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e) { }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            if (suppliers == null)
            {
                suppliers = new frmSuppliers();
                suppliers.FormClosed += suppliers_FormClosed;
                suppliers.MdiParent = this;
                suppliers.Dock = DockStyle.Fill;
                suppliers.Show();
            }
            else
            {
                suppliers.Activate();
            }
        }

        private void suppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            suppliers = null;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            tmrSidebar.Start();
        }

        private void tmrSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarPanel.Width -= 10;
                if (sidebarPanel.Width <= 65)
                {
                    sidebarExpand = false;
                    tmrSidebar.Stop();
                }
            }
            else
            {
                sidebarPanel.Width += 10;
                if (sidebarPanel.Width >= 200)
                {
                    sidebarExpand = true;
                    tmrSidebar.Stop();
                }
            }
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            if (contacts == null)
            {
                contacts = new frmContacts();
                contacts.FormClosed += contacts_FormClosed;
                contacts.MdiParent = this;
                contacts.Dock = DockStyle.Fill;
                contacts.Show();
            }
            else
            {
                contacts.Activate();
            }
        }

        private void contacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            contacts = null;
        }

        private void btnProductsServices_Click(object sender, EventArgs e)
        {
            if (products == null)
            {
                products = new frmProductservices();
                products.FormClosed += ProductsServices_FormClosed;
                products.MdiParent = this;
                products.Dock = DockStyle.Fill;
                products.Show();
            }
            else
            {
                products.Activate();
            }
        }

        private void ProductsServices_FormClosed(Object sender, FormClosedEventArgs e)
        {
            products = null;
        }

        private void btnInternalPurchaseRequest_Click(object sender, EventArgs e)
        {
            if (IPR == null)
            {
                IPR = new frmInternalPurchaseRequest();
                IPR.FormClosed += InternalPurchaseRequest_FormClosed;
                IPR.MdiParent = this;
                IPR.Dock = DockStyle.Fill;
                IPR.Show();
            }
            else
            {
                IPR.Activate();
            }
        }
        private void InternalPurchaseRequest_FormClosed(Object sender, FormClosedEventArgs e)
        {
            IPR = null;
        }

        private void btnPurchaseQuotations_Click(object sender, EventArgs e)
        {
            if (PQ == null)
            {
                PQ = new frmPurchaseQuotations();
                PQ.FormClosed += PurchaseQuotations_FormClosed;
                PQ.MdiParent = this;
                PQ.Dock = DockStyle.Fill;
                PQ.Show();
            }
            else
            {
                PQ.Activate();
            }
        }

        private void PurchaseQuotations_FormClosed(object sender, FormClosedEventArgs e)
        {
            PQ = null;
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            if (PO == null)
            {
                PO = new frmPurchaseOrders();
                PO.FormClosed += PurchaseOrders_FormClosed;
                PO.MdiParent = this;
                PO.Dock = DockStyle.Fill;
                PO.Show();
            }
            else
            {
                PO.Activate();
            }
        }

        private void PurchaseOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            PO = null;
        }

        private void btnHistorical_Click(object sender, EventArgs e)
        {
            tmrHistorical.Start();
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {

        }

        private void tmrHistorical_Tick(object sender, EventArgs e)
        {
            if (HistoricalCollapsed)
            {
                btnHistorical.Image = Resources.collapse_arrow_20;
                pnlHistoricalDropdown.Height += 10;
                if (pnlHistoricalDropdown.Size == pnlHistoricalDropdown.MaximumSize)
                {
                    tmrHistorical.Stop();
                    HistoricalCollapsed = false;
                }
            }
            else
            {
                btnHistorical.Image = Resources.expand_arrow_20;
                pnlHistoricalDropdown.Height -= 10;
                if (pnlHistoricalDropdown.Size == pnlHistoricalDropdown.MinimumSize)
                {
                    tmrHistorical.Stop();
                    HistoricalCollapsed = true;
                }
            }
        }

        private void btnReportings_Click(object sender, EventArgs e)
        {
            tmrReportings.Start();
        }

        private void tmrReportings_Tick(object sender, EventArgs e)
        {
            if (ReportingsCollapsed)
            {
                btnReportings.Image = Resources.collapse_arrow_20;
                pnlReportinngsDropdown.Height += 10;
                if (pnlReportinngsDropdown.Size == pnlReportinngsDropdown.MaximumSize)
                {
                    tmrReportings.Stop();
                    ReportingsCollapsed = false;
                }
            }
            else
            {
                btnReportings.Image = Resources.expand_arrow_20;
                pnlReportinngsDropdown.Height -= 10;
                if (pnlReportinngsDropdown.Size == pnlReportinngsDropdown.MinimumSize)
                {
                    tmrReportings.Stop();
                    ReportingsCollapsed = true;
                }
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnFinishOrders_Click(object sender, EventArgs e)
        {
            if (FO == null)
            {
                FO = new frmFinishOrders();
                FO.FormClosed += FinishOrders_FormClosed;
                FO.MdiParent = this;
                FO.Dock = DockStyle.Fill;
                FO.Show();
            }
            else
            {
                FO.Activate();
            }
        }

        private void FinishOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            FO = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PB == null)
            {
                PB = new frmPurchaseBuyer();
                PB.FormClosed += PurchaseBuyer_FormClosed;
                PB.MdiParent = this;
                PB.Dock = DockStyle.Fill;
                PB.Show();
            }
            else
            {
                PB.Activate();
            }
        }

        private void PurchaseBuyer_FormClosed(Object sender, FormClosedEventArgs e)
        {
            PB = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PM == null)
            {
                PM = new frmPurchaseManager();
                PM.FormClosed += PurchaseManager_FormClosed;
                PM.MdiParent = this;
                PM.Dock = DockStyle.Fill;
                PM.Show();
            }
            else
            {
                PM.Activate();
            }
        }
        private void PurchaseManager_FormClosed(Object sender, FormClosedEventArgs e)
        {
            PM = null;
        }
    }
}
