using REMAS.Forms.Account;
using REMAS.Forms.Custom;
using REMAS.Forms.Purchasing;
using REMAS.Module;
using System;
using System.Collections;
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
        public string sql, sSearch;
        Form form = new Form();
        Security crypto;
        RunQuery qu_All;
        DataTable myData, myData2;
        myMsgBox messageBox;
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        public fmCustomer()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255,255,255);//Border color
        }

        public fmCustomer(string refresh)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 255, 255);//Border color
            btnRefresh_Click(null, null);
        }

        // Overriden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
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
            //Form f2 = new fmAddMasCust("", "N");
            //if (f2 != null)
            //{
            //    f2.MdiParent = (fmMenu)MdiParent;
            //    f2.Show();
            //    SetEnable(false);
            //    f2 = null;
            //    //SetEnable(true);
            //}

            pnlUC.Visible = true;
            pnlUC.Width = 800;
            pnlUC.Height = 650;
            panelCenter(pnlUC);
            ucAddCustomer addCustomer = new ucAddCustomer();
            addCustomer.sNew = "Y";

            addCustomer.Dock = DockStyle.Fill;
            addCustomer.Location = new Point(pnlUC.Width / 2 - addCustomer.Size.Width / 2,
               pnlUC.Height / 2 - addCustomer.Size.Height / 2);
            pnlUC.Controls.Add(addCustomer);
        }

        public void SetEnable(bool isVisible)
        {
            this.Enabled = isVisible;
        }

        public void SetPanelVisibility(bool isVisible)
        {
            pnlUC.Visible = isVisible;
        }

        void panelCenter(Panel panel)
        {
            panel.Location = new Point(this.ClientSize.Width / 2 - panel.Size.Width / 2,
               this.ClientSize.Height / 2 - panel.Size.Height / 2);
            panel.Anchor = AnchorStyles.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmCustomer_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlUC.Visible = true;
            pnlUC.Width = 800;
            pnlUC.Height = 650;
            panelCenter(pnlUC);
            ucAddCustomer addCustomer = new ucAddCustomer();
            addCustomer.sNew = "N";
            addCustomer.LoadHeaderEdit(dgCustList.CurrentRow.Cells["CustId"].Value.ToString());
            addCustomer.Dock = DockStyle.Fill;
            addCustomer.Location = new Point(pnlUC.Width / 2 - addCustomer.Size.Width / 2,
               pnlUC.Height / 2 - addCustomer.Size.Height / 2);
            pnlUC.Controls.Add(addCustomer);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sSearch = "CustName";
            lbSearch.Text = " Search By Customer";
            GetListCustomer();
        }

        private void dgCustList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgCustList.Rows[e.RowIndex].Cells["No"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgCustList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private void fmCustomer_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }

        public void GetListCustomer()
        {
            sql = " Select *, Case When CustType = 'L' then 'Local' When CustType = 'E' then 'Export' End as CustomerType from MsCustomer " +
                  " Where ActiveStat = 'A' and " + sSearch + " like '%" + txtSearch.Text + "%' ";
            qu_All = new RunQuery();
            myData = qu_All.OpenAdoQuery(sql);
            if (myData.Rows.Count > 0)
            {
                dgCustList.Rows.Clear();
                dgCustList.Rows.Add(myData.Rows.Count);

                for (int n = 0; n <= myData.Rows.Count - 1; n++)
                {
                    dgCustList.Rows[n].Cells["CustId"].Value = myData.Rows[n]["CustId"].ToString().Trim();
                    dgCustList.Rows[n].Cells["CustName"].Value = myData.Rows[n]["CustName"].ToString().Trim();
                    dgCustList.Rows[n].Cells["SupplyCd"].Value = myData.Rows[n]["SupplyCd"].ToString().Trim();
                    dgCustList.Rows[n].Cells["CustType"].Value = myData.Rows[n]["CustomerType"].ToString().Trim();
                    dgCustList.Rows[n].Cells["CurrencyCd"].Value = myData.Rows[n]["CurrencyCd"].ToString().Trim();
                    dgCustList.Rows[n].Cells["NPWP"].Value = myData.Rows[n]["NPWP"].ToString().Trim();
                    dgCustList.Rows[n].Cells["NPWPName"].Value = myData.Rows[n]["NPWPName"].ToString().Trim();
                    dgCustList.Rows[n].Cells["PPNStat"].Value = myData.Rows[n]["PPNStat"].ToString().Trim();
                    dgCustList.Rows[n].Cells["AcctNo"].Value = myData.Rows[n]["AcctNo"].ToString().Trim();
                }
            }

        }
    }
}
