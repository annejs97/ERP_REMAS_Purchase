namespace REMAS.Forms.Sales
{
    partial class frmCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.dgvCustList = new System.Windows.Forms.DataGridView();
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new REMAS.Contoller.RJTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlUC = new REMAS.Contoller.CustomPanel();
            this.drag = new REMAS.Contoller.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustList)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustList
            // 
            this.dgvCustList.AllowUserToAddRows = false;
            this.dgvCustList.AllowUserToDeleteRows = false;
            this.dgvCustList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCustList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustList.EnableHeadersVisualStyles = false;
            this.dgvCustList.Location = new System.Drawing.Point(0, 75);
            this.dgvCustList.MultiSelect = false;
            this.dgvCustList.Name = "dgvCustList";
            this.dgvCustList.ReadOnly = true;
            this.dgvCustList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCustList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustList.RowHeadersVisible = false;
            this.dgvCustList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustList.Size = new System.Drawing.Size(1000, 625);
            this.dgvCustList.TabIndex = 7;
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
            this.CustName.HeaderText = "Customer";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            this.CustName.Width = 250;
            // 
            // SupplyCd
            // 
            this.SupplyCd.FillWeight = 80F;
            this.SupplyCd.HeaderText = "Supply Code";
            this.SupplyCd.Name = "SupplyCd";
            this.SupplyCd.ReadOnly = true;
            // 
            // CustType
            // 
            this.CustType.FillWeight = 80F;
            this.CustType.HeaderText = "Customer Type";
            this.CustType.Name = "CustType";
            this.CustType.ReadOnly = true;
            // 
            // CurrencyCd
            // 
            this.CurrencyCd.FillWeight = 80F;
            this.CurrencyCd.HeaderText = "Currency";
            this.CurrencyCd.Name = "CurrencyCd";
            this.CurrencyCd.ReadOnly = true;
            this.CurrencyCd.Width = 80;
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
            this.AcctNo.HeaderText = "Account No.";
            this.AcctNo.Name = "AcctNo";
            this.AcctNo.ReadOnly = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 26);
            this.pnlTop.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Crimson;
            this.btnClose.Location = new System.Drawing.Point(976, 0);
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
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "CUSTOMER DATA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 49);
            this.panel1.TabIndex = 9;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbSearch.Location = new System.Drawing.Point(8, 5);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(61, 13);
            this.lbSearch.TabIndex = 8;
            this.lbSearch.Text = "Search by :";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(181, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(31, 26);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(11, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 250;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(201, 29);
            this.txtSearch.TabIndex = 52;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(277, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(31, 26);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Image = global::REMAS.Properties.Resources.Excel_App;
            this.btnExportExcel.Location = new System.Drawing.Point(359, 16);
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
            this.btnRefresh.Location = new System.Drawing.Point(317, 16);
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
            this.btnAdd.Location = new System.Drawing.Point(239, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlUC
            // 
            this.pnlUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlUC.BorderColor = System.Drawing.Color.Transparent;
            this.pnlUC.ColorBottom = System.Drawing.Color.Empty;
            this.pnlUC.ColorTop = System.Drawing.Color.Empty;
            this.pnlUC.Location = new System.Drawing.Point(976, 300);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Radius = 20;
            this.pnlUC.Size = new System.Drawing.Size(200, 100);
            this.pnlUC.TabIndex = 11;
            this.pnlUC.Thickness = 5F;
            this.pnlUC.Visible = false;
            // 
            // drag
            // 
            this.drag.SelectControl = this.pnlTop;
            // 
            // fmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.ControlBox = false;
            this.Controls.Add(this.pnlUC);
            this.Controls.Add(this.dgvCustList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustList)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCustList;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private Contoller.DragControl drag;
        private Contoller.CustomPanel pnlUC;
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
        private Contoller.RJTextBox txtSearch;
    }
}