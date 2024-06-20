namespace REMAS.Forms.Purchasing
{
    partial class frmPurchaseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new REMAS.Contoller.UPanel();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new REMAS.Contoller.RJTextBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblRFQAndPO = new System.Windows.Forms.Label();
            this.lblNoRecord = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ProgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlPOsVolume = new System.Windows.Forms.Panel();
            this.btnCalendarPOsVolume2 = new System.Windows.Forms.Button();
            this.btnCalendarPOsVolume = new System.Windows.Forms.Button();
            this.lblNoRecordPOsVolume = new System.Windows.Forms.Label();
            this.txbPOsVolume2 = new REMAS.Contoller.RJTextBox();
            this.txbPOsVolume = new REMAS.Contoller.RJTextBox();
            this.sptPOsVolume = new REMAS.Contoller.Separators();
            this.lblPOs = new System.Windows.Forms.Label();
            this.pnlPurchasedAmount = new System.Windows.Forms.Panel();
            this.btnCalendarPurchasedAmount2 = new System.Windows.Forms.Button();
            this.btnCalendarPurchasedAmount = new System.Windows.Forms.Button();
            this.lblNoRecordPurchasedAmount = new System.Windows.Forms.Label();
            this.txbPurchasedAmount2 = new REMAS.Contoller.RJTextBox();
            this.txbPurchasedAmount = new REMAS.Contoller.RJTextBox();
            this.sptPurchasedAmount = new REMAS.Contoller.Separators();
            this.lblPurchasedAmount = new System.Windows.Forms.Label();
            this.pnlPurchasedAmountDistribution = new System.Windows.Forms.Panel();
            this.btnCalendarPurchasedDistribution2 = new System.Windows.Forms.Button();
            this.btnCalendarPurchasedDistribution = new System.Windows.Forms.Button();
            this.lblNoRecordPurchasedAmountDistribution = new System.Windows.Forms.Label();
            this.txbPurchasedAmountDistribution2 = new REMAS.Contoller.RJTextBox();
            this.txbPurchasedAmountDistribution = new REMAS.Contoller.RJTextBox();
            this.sptPurchasedAmountDistribution = new REMAS.Contoller.Separators();
            this.lblPurchasedAmountDistribution = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlPOsVolume.SuspendLayout();
            this.pnlPurchasedAmount.SuspendLayout();
            this.pnlPurchasedAmountDistribution.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Controls.Add(this.btnReplace);
            this.pnlHeader.Controls.Add(this.btnFind);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.btnRight);
            this.pnlHeader.Controls.Add(this.btnLeft);
            this.pnlHeader.Controls.Add(this.lblPage);
            this.pnlHeader.Controls.Add(this.btnExcel);
            this.pnlHeader.Controls.Add(this.btnNotes);
            this.pnlHeader.Controls.Add(this.btnPlus);
            this.pnlHeader.Location = new System.Drawing.Point(21, 18);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1752, 62);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.White;
            this.btnReplace.FlatAppearance.BorderSize = 0;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.btnReplace.Location = new System.Drawing.Point(507, 14);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(38, 35);
            this.btnReplace.TabIndex = 65;
            this.btnReplace.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(362, 9);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(46, 40);
            this.btnFind.TabIndex = 58;
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
            this.txtSearch.Location = new System.Drawing.Point(22, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.MaxLength = 250;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(386, 44);
            this.txtSearch.TabIndex = 60;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = global::REMAS.Properties.Resources.icons8_back_24__1_;
            this.btnRight.Location = new System.Drawing.Point(1701, 15);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(38, 35);
            this.btnRight.TabIndex = 64;
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(1656, 15);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(38, 35);
            this.btnLeft.TabIndex = 63;
            this.btnLeft.UseVisualStyleBackColor = false;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.White;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPage.Location = new System.Drawing.Point(1544, 18);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(102, 28);
            this.lblPage.TabIndex = 62;
            this.lblPage.Text = "1 to 5 of 5";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Image = global::REMAS.Properties.Resources.Excel_App;
            this.btnExcel.Location = new System.Drawing.Point(555, 12);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(38, 35);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnNotes
            // 
            this.btnNotes.BackColor = System.Drawing.Color.White;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Image = global::REMAS.Properties.Resources.icons8_create_20;
            this.btnNotes.Location = new System.Drawing.Point(462, 11);
            this.btnNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(38, 35);
            this.btnNotes.TabIndex = 3;
            this.btnNotes.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Image = global::REMAS.Properties.Resources.PlusLg;
            this.btnPlus.Location = new System.Drawing.Point(418, 14);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(38, 35);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.UseVisualStyleBackColor = false;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBody.Controls.Add(this.lblRFQAndPO);
            this.pnlBody.Controls.Add(this.lblNoRecord);
            this.pnlBody.Controls.Add(this.dgvList);
            this.pnlBody.Location = new System.Drawing.Point(21, 118);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1752, 528);
            this.pnlBody.TabIndex = 16;
            // 
            // lblRFQAndPO
            // 
            this.lblRFQAndPO.AutoSize = true;
            this.lblRFQAndPO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFQAndPO.Location = new System.Drawing.Point(18, 25);
            this.lblRFQAndPO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRFQAndPO.Name = "lblRFQAndPO";
            this.lblRFQAndPO.Size = new System.Drawing.Size(237, 28);
            this.lblRFQAndPO.TabIndex = 19;
            this.lblRFQAndPO.Text = "RFQ And PO To Validate";
            // 
            // lblNoRecord
            // 
            this.lblNoRecord.AutoSize = true;
            this.lblNoRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblNoRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecord.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNoRecord.Location = new System.Drawing.Point(825, 318);
            this.lblNoRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoRecord.Name = "lblNoRecord";
            this.lblNoRecord.Size = new System.Drawing.Size(169, 28);
            this.lblNoRecord.TabIndex = 66;
            this.lblNoRecord.Text = "No record found.";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgName,
            this.MenuName,
            this.MainRoot,
            this.SubRoot,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvList.Location = new System.Drawing.Point(22, 75);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 62;
            this.dgvList.Size = new System.Drawing.Size(1665, 175);
            this.dgvList.TabIndex = 87;
            // 
            // ProgName
            // 
            this.ProgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProgName.HeaderText = "";
            this.ProgName.MinimumWidth = 8;
            this.ProgName.Name = "ProgName";
            // 
            // MenuName
            // 
            this.MenuName.FillWeight = 150F;
            this.MenuName.HeaderText = "Ref.";
            this.MenuName.MinimumWidth = 8;
            this.MenuName.Name = "MenuName";
            this.MenuName.Width = 225;
            // 
            // MainRoot
            // 
            this.MainRoot.HeaderText = "Supplier";
            this.MainRoot.MinimumWidth = 8;
            this.MainRoot.Name = "MainRoot";
            this.MainRoot.Width = 225;
            // 
            // SubRoot
            // 
            this.SubRoot.HeaderText = "Supplier ref.";
            this.SubRoot.MinimumWidth = 8;
            this.SubRoot.Name = "SubRoot";
            this.SubRoot.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order Date";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total A.T.I";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 150;
            // 
            // pnlPOsVolume
            // 
            this.pnlPOsVolume.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPOsVolume.Controls.Add(this.btnCalendarPOsVolume2);
            this.pnlPOsVolume.Controls.Add(this.btnCalendarPOsVolume);
            this.pnlPOsVolume.Controls.Add(this.lblNoRecordPOsVolume);
            this.pnlPOsVolume.Controls.Add(this.txbPOsVolume2);
            this.pnlPOsVolume.Controls.Add(this.txbPOsVolume);
            this.pnlPOsVolume.Controls.Add(this.sptPOsVolume);
            this.pnlPOsVolume.Controls.Add(this.lblPOs);
            this.pnlPOsVolume.Location = new System.Drawing.Point(21, 682);
            this.pnlPOsVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPOsVolume.Name = "pnlPOsVolume";
            this.pnlPOsVolume.Size = new System.Drawing.Size(854, 405);
            this.pnlPOsVolume.TabIndex = 88;
            // 
            // btnCalendarPOsVolume2
            // 
            this.btnCalendarPOsVolume2.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendarPOsVolume2.FlatAppearance.BorderSize = 0;
            this.btnCalendarPOsVolume2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarPOsVolume2.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarPOsVolume2.Location = new System.Drawing.Point(784, 97);
            this.btnCalendarPOsVolume2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalendarPOsVolume2.Name = "btnCalendarPOsVolume2";
            this.btnCalendarPOsVolume2.Size = new System.Drawing.Size(46, 40);
            this.btnCalendarPOsVolume2.TabIndex = 91;
            this.btnCalendarPOsVolume2.UseVisualStyleBackColor = false;
            // 
            // btnCalendarPOsVolume
            // 
            this.btnCalendarPOsVolume.BackColor = System.Drawing.Color.White;
            this.btnCalendarPOsVolume.FlatAppearance.BorderSize = 0;
            this.btnCalendarPOsVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarPOsVolume.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarPOsVolume.Location = new System.Drawing.Point(362, 98);
            this.btnCalendarPOsVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalendarPOsVolume.Name = "btnCalendarPOsVolume";
            this.btnCalendarPOsVolume.Size = new System.Drawing.Size(46, 40);
            this.btnCalendarPOsVolume.TabIndex = 89;
            this.btnCalendarPOsVolume.UseVisualStyleBackColor = false;
            // 
            // lblNoRecordPOsVolume
            // 
            this.lblNoRecordPOsVolume.AutoSize = true;
            this.lblNoRecordPOsVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblNoRecordPOsVolume.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecordPOsVolume.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNoRecordPOsVolume.Location = new System.Drawing.Point(332, 243);
            this.lblNoRecordPOsVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoRecordPOsVolume.Name = "lblNoRecordPOsVolume";
            this.lblNoRecordPOsVolume.Size = new System.Drawing.Size(169, 28);
            this.lblNoRecordPOsVolume.TabIndex = 88;
            this.lblNoRecordPOsVolume.Text = "No record found.";
            // 
            // txbPOsVolume2
            // 
            this.txbPOsVolume2.BackColor = System.Drawing.SystemColors.Window;
            this.txbPOsVolume2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbPOsVolume2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPOsVolume2.BorderRadius = 0;
            this.txbPOsVolume2.BorderSize = 1;
            this.txbPOsVolume2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPOsVolume2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPOsVolume2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPOsVolume2.Location = new System.Drawing.Point(446, 98);
            this.txbPOsVolume2.Margin = new System.Windows.Forms.Padding(6);
            this.txbPOsVolume2.MaxLength = 250;
            this.txbPOsVolume2.Multiline = false;
            this.txbPOsVolume2.Name = "txbPOsVolume2";
            this.txbPOsVolume2.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbPOsVolume2.PasswordChar = false;
            this.txbPOsVolume2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPOsVolume2.PlaceholderText = "21/03/2024";
            this.txbPOsVolume2.ReadOnly = false;
            this.txbPOsVolume2.Size = new System.Drawing.Size(386, 44);
            this.txbPOsVolume2.TabIndex = 90;
            this.txbPOsVolume2.Texts = "";
            this.txbPOsVolume2.UnderlinedStyle = true;
            // 
            // txbPOsVolume
            // 
            this.txbPOsVolume.BackColor = System.Drawing.SystemColors.Window;
            this.txbPOsVolume.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbPOsVolume.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPOsVolume.BorderRadius = 0;
            this.txbPOsVolume.BorderSize = 1;
            this.txbPOsVolume.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPOsVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPOsVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPOsVolume.Location = new System.Drawing.Point(22, 98);
            this.txbPOsVolume.Margin = new System.Windows.Forms.Padding(6);
            this.txbPOsVolume.MaxLength = 250;
            this.txbPOsVolume.Multiline = false;
            this.txbPOsVolume.Name = "txbPOsVolume";
            this.txbPOsVolume.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbPOsVolume.PasswordChar = false;
            this.txbPOsVolume.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPOsVolume.PlaceholderText = "21/09/2023";
            this.txbPOsVolume.ReadOnly = false;
            this.txbPOsVolume.Size = new System.Drawing.Size(386, 44);
            this.txbPOsVolume.TabIndex = 89;
            this.txbPOsVolume.Texts = "";
            this.txbPOsVolume.UnderlinedStyle = true;
            // 
            // sptPOsVolume
            // 
            this.sptPOsVolume.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.sptPOsVolume.isVertical = false;
            this.sptPOsVolume.Location = new System.Drawing.Point(4, 52);
            this.sptPOsVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sptPOsVolume.Name = "sptPOsVolume";
            this.sptPOsVolume.Size = new System.Drawing.Size(844, 35);
            this.sptPOsVolume.TabIndex = 89;
            this.sptPOsVolume.Thickness = 1;
            // 
            // lblPOs
            // 
            this.lblPOs.AutoSize = true;
            this.lblPOs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOs.Location = new System.Drawing.Point(18, 22);
            this.lblPOs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPOs.Name = "lblPOs";
            this.lblPOs.Size = new System.Drawing.Size(309, 28);
            this.lblPOs.TabIndex = 88;
            this.lblPOs.Text = "POs Volume by buyer by family";
            // 
            // pnlPurchasedAmount
            // 
            this.pnlPurchasedAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPurchasedAmount.Controls.Add(this.btnCalendarPurchasedAmount2);
            this.pnlPurchasedAmount.Controls.Add(this.btnCalendarPurchasedAmount);
            this.pnlPurchasedAmount.Controls.Add(this.lblNoRecordPurchasedAmount);
            this.pnlPurchasedAmount.Controls.Add(this.txbPurchasedAmount2);
            this.pnlPurchasedAmount.Controls.Add(this.txbPurchasedAmount);
            this.pnlPurchasedAmount.Controls.Add(this.sptPurchasedAmount);
            this.pnlPurchasedAmount.Controls.Add(this.lblPurchasedAmount);
            this.pnlPurchasedAmount.Location = new System.Drawing.Point(906, 682);
            this.pnlPurchasedAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPurchasedAmount.Name = "pnlPurchasedAmount";
            this.pnlPurchasedAmount.Size = new System.Drawing.Size(854, 405);
            this.pnlPurchasedAmount.TabIndex = 92;
            // 
            // btnCalendarPurchasedAmount2
            // 
            this.btnCalendarPurchasedAmount2.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendarPurchasedAmount2.FlatAppearance.BorderSize = 0;
            this.btnCalendarPurchasedAmount2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarPurchasedAmount2.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarPurchasedAmount2.Location = new System.Drawing.Point(784, 97);
            this.btnCalendarPurchasedAmount2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalendarPurchasedAmount2.Name = "btnCalendarPurchasedAmount2";
            this.btnCalendarPurchasedAmount2.Size = new System.Drawing.Size(46, 40);
            this.btnCalendarPurchasedAmount2.TabIndex = 91;
            this.btnCalendarPurchasedAmount2.UseVisualStyleBackColor = false;
            // 
            // btnCalendarPurchasedAmount
            // 
            this.btnCalendarPurchasedAmount.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendarPurchasedAmount.FlatAppearance.BorderSize = 0;
            this.btnCalendarPurchasedAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarPurchasedAmount.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarPurchasedAmount.Location = new System.Drawing.Point(362, 98);
            this.btnCalendarPurchasedAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalendarPurchasedAmount.Name = "btnCalendarPurchasedAmount";
            this.btnCalendarPurchasedAmount.Size = new System.Drawing.Size(46, 40);
            this.btnCalendarPurchasedAmount.TabIndex = 89;
            this.btnCalendarPurchasedAmount.UseVisualStyleBackColor = false;
            // 
            // lblNoRecordPurchasedAmount
            // 
            this.lblNoRecordPurchasedAmount.AutoSize = true;
            this.lblNoRecordPurchasedAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblNoRecordPurchasedAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecordPurchasedAmount.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNoRecordPurchasedAmount.Location = new System.Drawing.Point(332, 243);
            this.lblNoRecordPurchasedAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoRecordPurchasedAmount.Name = "lblNoRecordPurchasedAmount";
            this.lblNoRecordPurchasedAmount.Size = new System.Drawing.Size(169, 28);
            this.lblNoRecordPurchasedAmount.TabIndex = 88;
            this.lblNoRecordPurchasedAmount.Text = "No record found.";
            // 
            // txbPurchasedAmount2
            // 
            this.txbPurchasedAmount2.BackColor = System.Drawing.SystemColors.Window;
            this.txbPurchasedAmount2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbPurchasedAmount2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPurchasedAmount2.BorderRadius = 0;
            this.txbPurchasedAmount2.BorderSize = 1;
            this.txbPurchasedAmount2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPurchasedAmount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPurchasedAmount2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPurchasedAmount2.Location = new System.Drawing.Point(446, 98);
            this.txbPurchasedAmount2.Margin = new System.Windows.Forms.Padding(6);
            this.txbPurchasedAmount2.MaxLength = 250;
            this.txbPurchasedAmount2.Multiline = false;
            this.txbPurchasedAmount2.Name = "txbPurchasedAmount2";
            this.txbPurchasedAmount2.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbPurchasedAmount2.PasswordChar = false;
            this.txbPurchasedAmount2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPurchasedAmount2.PlaceholderText = "21/03/2024";
            this.txbPurchasedAmount2.ReadOnly = false;
            this.txbPurchasedAmount2.Size = new System.Drawing.Size(386, 44);
            this.txbPurchasedAmount2.TabIndex = 90;
            this.txbPurchasedAmount2.Texts = "";
            this.txbPurchasedAmount2.UnderlinedStyle = true;
            // 
            // txbPurchasedAmount
            // 
            this.txbPurchasedAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txbPurchasedAmount.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbPurchasedAmount.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPurchasedAmount.BorderRadius = 0;
            this.txbPurchasedAmount.BorderSize = 1;
            this.txbPurchasedAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPurchasedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPurchasedAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPurchasedAmount.Location = new System.Drawing.Point(22, 98);
            this.txbPurchasedAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txbPurchasedAmount.MaxLength = 250;
            this.txbPurchasedAmount.Multiline = false;
            this.txbPurchasedAmount.Name = "txbPurchasedAmount";
            this.txbPurchasedAmount.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbPurchasedAmount.PasswordChar = false;
            this.txbPurchasedAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPurchasedAmount.PlaceholderText = "21/09/2023";
            this.txbPurchasedAmount.ReadOnly = false;
            this.txbPurchasedAmount.Size = new System.Drawing.Size(386, 44);
            this.txbPurchasedAmount.TabIndex = 89;
            this.txbPurchasedAmount.Texts = "";
            this.txbPurchasedAmount.UnderlinedStyle = true;
            // 
            // sptPurchasedAmount
            // 
            this.sptPurchasedAmount.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.sptPurchasedAmount.isVertical = false;
            this.sptPurchasedAmount.Location = new System.Drawing.Point(4, 52);
            this.sptPurchasedAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sptPurchasedAmount.Name = "sptPurchasedAmount";
            this.sptPurchasedAmount.Size = new System.Drawing.Size(844, 35);
            this.sptPurchasedAmount.TabIndex = 89;
            this.sptPurchasedAmount.Thickness = 1;
            // 
            // lblPurchasedAmount
            // 
            this.lblPurchasedAmount.AutoSize = true;
            this.lblPurchasedAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedAmount.Location = new System.Drawing.Point(18, 22);
            this.lblPurchasedAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchasedAmount.Name = "lblPurchasedAmount";
            this.lblPurchasedAmount.Size = new System.Drawing.Size(283, 28);
            this.lblPurchasedAmount.TabIndex = 88;
            this.lblPurchasedAmount.Text = "Purchased amount by family";
            // 
            // pnlPurchasedAmountDistribution
            // 
            this.pnlPurchasedAmountDistribution.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPurchasedAmountDistribution.Controls.Add(this.btnCalendarPurchasedDistribution2);
            this.pnlPurchasedAmountDistribution.Controls.Add(this.btnCalendarPurchasedDistribution);
            this.pnlPurchasedAmountDistribution.Controls.Add(this.lblNoRecordPurchasedAmountDistribution);
            this.pnlPurchasedAmountDistribution.Controls.Add(this.txbPurchasedAmountDistribution2);
            this.pnlPurchasedAmountDistribution.Controls.Add(this.txbPurchasedAmountDistribution);
            this.pnlPurchasedAmountDistribution.Controls.Add(this.sptPurchasedAmountDistribution);
            this.pnlPurchasedAmountDistribution.Controls.Add(this.lblPurchasedAmountDistribution);
            this.pnlPurchasedAmountDistribution.Location = new System.Drawing.Point(21, 1114);
            this.pnlPurchasedAmountDistribution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPurchasedAmountDistribution.Name = "pnlPurchasedAmountDistribution";
            this.pnlPurchasedAmountDistribution.Size = new System.Drawing.Size(854, 405);
            this.pnlPurchasedAmountDistribution.TabIndex = 92;
            // 
            // btnCalendarPurchasedDistribution2
            // 
            this.btnCalendarPurchasedDistribution2.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendarPurchasedDistribution2.FlatAppearance.BorderSize = 0;
            this.btnCalendarPurchasedDistribution2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarPurchasedDistribution2.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarPurchasedDistribution2.Location = new System.Drawing.Point(784, 97);
            this.btnCalendarPurchasedDistribution2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalendarPurchasedDistribution2.Name = "btnCalendarPurchasedDistribution2";
            this.btnCalendarPurchasedDistribution2.Size = new System.Drawing.Size(46, 40);
            this.btnCalendarPurchasedDistribution2.TabIndex = 91;
            this.btnCalendarPurchasedDistribution2.UseVisualStyleBackColor = false;
            // 
            // btnCalendarPurchasedDistribution
            // 
            this.btnCalendarPurchasedDistribution.BackColor = System.Drawing.Color.White;
            this.btnCalendarPurchasedDistribution.FlatAppearance.BorderSize = 0;
            this.btnCalendarPurchasedDistribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarPurchasedDistribution.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarPurchasedDistribution.Location = new System.Drawing.Point(362, 98);
            this.btnCalendarPurchasedDistribution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalendarPurchasedDistribution.Name = "btnCalendarPurchasedDistribution";
            this.btnCalendarPurchasedDistribution.Size = new System.Drawing.Size(46, 40);
            this.btnCalendarPurchasedDistribution.TabIndex = 89;
            this.btnCalendarPurchasedDistribution.UseVisualStyleBackColor = false;
            // 
            // lblNoRecordPurchasedAmountDistribution
            // 
            this.lblNoRecordPurchasedAmountDistribution.AutoSize = true;
            this.lblNoRecordPurchasedAmountDistribution.BackColor = System.Drawing.Color.Transparent;
            this.lblNoRecordPurchasedAmountDistribution.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecordPurchasedAmountDistribution.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNoRecordPurchasedAmountDistribution.Location = new System.Drawing.Point(332, 243);
            this.lblNoRecordPurchasedAmountDistribution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoRecordPurchasedAmountDistribution.Name = "lblNoRecordPurchasedAmountDistribution";
            this.lblNoRecordPurchasedAmountDistribution.Size = new System.Drawing.Size(169, 28);
            this.lblNoRecordPurchasedAmountDistribution.TabIndex = 88;
            this.lblNoRecordPurchasedAmountDistribution.Text = "No record found.";
            // 
            // txbPurchasedAmountDistribution2
            // 
            this.txbPurchasedAmountDistribution2.BackColor = System.Drawing.SystemColors.Window;
            this.txbPurchasedAmountDistribution2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbPurchasedAmountDistribution2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPurchasedAmountDistribution2.BorderRadius = 0;
            this.txbPurchasedAmountDistribution2.BorderSize = 1;
            this.txbPurchasedAmountDistribution2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPurchasedAmountDistribution2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPurchasedAmountDistribution2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPurchasedAmountDistribution2.Location = new System.Drawing.Point(446, 98);
            this.txbPurchasedAmountDistribution2.Margin = new System.Windows.Forms.Padding(6);
            this.txbPurchasedAmountDistribution2.MaxLength = 250;
            this.txbPurchasedAmountDistribution2.Multiline = false;
            this.txbPurchasedAmountDistribution2.Name = "txbPurchasedAmountDistribution2";
            this.txbPurchasedAmountDistribution2.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbPurchasedAmountDistribution2.PasswordChar = false;
            this.txbPurchasedAmountDistribution2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPurchasedAmountDistribution2.PlaceholderText = "21/03/2024";
            this.txbPurchasedAmountDistribution2.ReadOnly = false;
            this.txbPurchasedAmountDistribution2.Size = new System.Drawing.Size(386, 44);
            this.txbPurchasedAmountDistribution2.TabIndex = 90;
            this.txbPurchasedAmountDistribution2.Texts = "";
            this.txbPurchasedAmountDistribution2.UnderlinedStyle = true;
            // 
            // txbPurchasedAmountDistribution
            // 
            this.txbPurchasedAmountDistribution.BackColor = System.Drawing.SystemColors.Window;
            this.txbPurchasedAmountDistribution.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbPurchasedAmountDistribution.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPurchasedAmountDistribution.BorderRadius = 0;
            this.txbPurchasedAmountDistribution.BorderSize = 1;
            this.txbPurchasedAmountDistribution.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPurchasedAmountDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPurchasedAmountDistribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPurchasedAmountDistribution.Location = new System.Drawing.Point(22, 98);
            this.txbPurchasedAmountDistribution.Margin = new System.Windows.Forms.Padding(6);
            this.txbPurchasedAmountDistribution.MaxLength = 250;
            this.txbPurchasedAmountDistribution.Multiline = false;
            this.txbPurchasedAmountDistribution.Name = "txbPurchasedAmountDistribution";
            this.txbPurchasedAmountDistribution.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbPurchasedAmountDistribution.PasswordChar = false;
            this.txbPurchasedAmountDistribution.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPurchasedAmountDistribution.PlaceholderText = "21/09/2023";
            this.txbPurchasedAmountDistribution.ReadOnly = false;
            this.txbPurchasedAmountDistribution.Size = new System.Drawing.Size(386, 44);
            this.txbPurchasedAmountDistribution.TabIndex = 89;
            this.txbPurchasedAmountDistribution.Texts = "";
            this.txbPurchasedAmountDistribution.UnderlinedStyle = true;
            // 
            // sptPurchasedAmountDistribution
            // 
            this.sptPurchasedAmountDistribution.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.sptPurchasedAmountDistribution.isVertical = false;
            this.sptPurchasedAmountDistribution.Location = new System.Drawing.Point(4, 52);
            this.sptPurchasedAmountDistribution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sptPurchasedAmountDistribution.Name = "sptPurchasedAmountDistribution";
            this.sptPurchasedAmountDistribution.Size = new System.Drawing.Size(844, 35);
            this.sptPurchasedAmountDistribution.TabIndex = 89;
            this.sptPurchasedAmountDistribution.Thickness = 1;
            // 
            // lblPurchasedAmountDistribution
            // 
            this.lblPurchasedAmountDistribution.AutoSize = true;
            this.lblPurchasedAmountDistribution.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedAmountDistribution.Location = new System.Drawing.Point(18, 22);
            this.lblPurchasedAmountDistribution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchasedAmountDistribution.Name = "lblPurchasedAmountDistribution";
            this.lblPurchasedAmountDistribution.Size = new System.Drawing.Size(400, 28);
            this.lblPurchasedAmountDistribution.TabIndex = 88;
            this.lblPurchasedAmountDistribution.Text = "Purchased amount distribution by family";
            // 
            // frmPurchaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1681, 600);
            this.Controls.Add(this.pnlPurchasedAmountDistribution);
            this.Controls.Add(this.pnlPurchasedAmount);
            this.Controls.Add(this.pnlPOsVolume);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPurchaseManager";
            this.Text = "frmPurchaseManager";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlPOsVolume.ResumeLayout(false);
            this.pnlPOsVolume.PerformLayout();
            this.pnlPurchasedAmount.ResumeLayout(false);
            this.pnlPurchasedAmount.PerformLayout();
            this.pnlPurchasedAmountDistribution.ResumeLayout(false);
            this.pnlPurchasedAmountDistribution.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Contoller.UPanel pnlHeader;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnFind;
        private Contoller.RJTextBox txtSearch;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblNoRecord;
        private System.Windows.Forms.Label lblRFQAndPO;
        private System.Windows.Forms.Panel pnlPOsVolume;
        private System.Windows.Forms.Label lblPOs;
        private Contoller.Separators sptPOsVolume;
        private System.Windows.Forms.Label lblNoRecordPOsVolume;
        private Contoller.RJTextBox txbPOsVolume2;
        private Contoller.RJTextBox txbPOsVolume;
        private System.Windows.Forms.Button btnCalendarPOsVolume2;
        private System.Windows.Forms.Button btnCalendarPOsVolume;
        private System.Windows.Forms.Panel pnlPurchasedAmount;
        private System.Windows.Forms.Button btnCalendarPurchasedAmount2;
        private System.Windows.Forms.Button btnCalendarPurchasedAmount;
        private System.Windows.Forms.Label lblNoRecordPurchasedAmount;
        private Contoller.RJTextBox txbPurchasedAmount2;
        private Contoller.RJTextBox txbPurchasedAmount;
        private Contoller.Separators sptPurchasedAmount;
        private System.Windows.Forms.Label lblPurchasedAmount;
        private System.Windows.Forms.Panel pnlPurchasedAmountDistribution;
        private System.Windows.Forms.Button btnCalendarPurchasedDistribution2;
        private System.Windows.Forms.Button btnCalendarPurchasedDistribution;
        private System.Windows.Forms.Label lblNoRecordPurchasedAmountDistribution;
        private Contoller.RJTextBox txbPurchasedAmountDistribution2;
        private Contoller.RJTextBox txbPurchasedAmountDistribution;
        private Contoller.Separators sptPurchasedAmountDistribution;
        private System.Windows.Forms.Label lblPurchasedAmountDistribution;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
    }
}