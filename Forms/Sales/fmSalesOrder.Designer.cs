namespace REMAS.Forms.Sales
{
    partial class fmSalesOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSalesOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.separators1 = new REMAS.Contoller.Separators();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgCustList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPWP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPWPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPNStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcctNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 26);
            this.panel2.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Crimson;
            this.btnClose.Location = new System.Drawing.Point(760, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 26);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "❎";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "SALES ORDER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.separators1);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 46);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(561, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "*** Maximum Load 1000 Data ***";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(281, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(31, 26);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // separators1
            // 
            this.separators1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.separators1.isVertical = false;
            this.separators1.Location = new System.Drawing.Point(9, 35);
            this.separators1.Name = "separators1";
            this.separators1.Size = new System.Drawing.Size(204, 10);
            this.separators1.TabIndex = 8;
            this.separators1.Text = "separators1";
            this.separators1.Thickness = 1;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(192, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(31, 26);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbSearch.Location = new System.Drawing.Point(8, 6);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(61, 13);
            this.lbSearch.TabIndex = 8;
            this.lbSearch.Text = "Search by :";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 16);
            this.txtSearch.TabIndex = 1;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Image = global::REMAS.Properties.Resources.Excel_App;
            this.btnExportExcel.Location = new System.Drawing.Point(363, 12);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(31, 26);
            this.btnExportExcel.TabIndex = 6;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.btnRefresh.Location = new System.Drawing.Point(321, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 26);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::REMAS.Properties.Resources.PlusLg;
            this.btnAdd.Location = new System.Drawing.Point(243, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgCustList
            // 
            this.dgCustList.AllowUserToAddRows = false;
            this.dgCustList.AllowUserToDeleteRows = false;
            this.dgCustList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgCustList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCustList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgCustList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCustList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCustList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.CustId,
            this.CustName,
            this.SupplyCd,
            this.CustType,
            this.CurrencyCd,
            this.NPWP,
            this.NPWPName,
            this.PPNStat,
            this.AcctNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgCustList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCustList.EnableHeadersVisualStyles = false;
            this.dgCustList.Location = new System.Drawing.Point(0, 72);
            this.dgCustList.MultiSelect = false;
            this.dgCustList.Name = "dgCustList";
            this.dgCustList.ReadOnly = true;
            this.dgCustList.RowHeadersVisible = false;
            this.dgCustList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustList.Size = new System.Drawing.Size(784, 489);
            this.dgCustList.TabIndex = 11;
            // 
            // No
            // 
            this.No.FillWeight = 50F;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 50;
            // 
            // CustId
            // 
            this.CustId.FillWeight = 80F;
            this.CustId.HeaderText = "Customer ID";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            this.CustId.Width = 80;
            // 
            // CustName
            // 
            this.CustName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CustName.HeaderText = "Customer";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            this.CustName.Width = 200;
            // 
            // SupplyCd
            // 
            this.SupplyCd.FillWeight = 80F;
            this.SupplyCd.HeaderText = "Supply Code";
            this.SupplyCd.Name = "SupplyCd";
            this.SupplyCd.ReadOnly = true;
            this.SupplyCd.Width = 80;
            // 
            // CustType
            // 
            this.CustType.FillWeight = 80F;
            this.CustType.HeaderText = "Customer Type";
            this.CustType.Name = "CustType";
            this.CustType.ReadOnly = true;
            this.CustType.Width = 80;
            // 
            // CurrencyCd
            // 
            this.CurrencyCd.FillWeight = 60F;
            this.CurrencyCd.HeaderText = "Currency";
            this.CurrencyCd.Name = "CurrencyCd";
            this.CurrencyCd.ReadOnly = true;
            this.CurrencyCd.Width = 60;
            // 
            // NPWP
            // 
            this.NPWP.HeaderText = "NPWP No.";
            this.NPWP.Name = "NPWP";
            this.NPWP.ReadOnly = true;
            // 
            // NPWPName
            // 
            this.NPWPName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NPWPName.HeaderText = "NPWP Name";
            this.NPWPName.Name = "NPWPName";
            this.NPWPName.ReadOnly = true;
            this.NPWPName.Width = 200;
            // 
            // PPNStat
            // 
            this.PPNStat.FillWeight = 60F;
            this.PPNStat.HeaderText = "PPN";
            this.PPNStat.Name = "PPNStat";
            this.PPNStat.ReadOnly = true;
            this.PPNStat.Width = 60;
            // 
            // AcctNo
            // 
            this.AcctNo.FillWeight = 80F;
            this.AcctNo.HeaderText = "Account No.";
            this.AcctNo.Name = "AcctNo";
            this.AcctNo.ReadOnly = true;
            this.AcctNo.Width = 80;
            // 
            // fmSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgCustList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmSalesOrder";
            this.Text = "SalesOrder";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private Contoller.Separators separators1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgCustList;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPWP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPWPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPNStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcctNo;
    }
}