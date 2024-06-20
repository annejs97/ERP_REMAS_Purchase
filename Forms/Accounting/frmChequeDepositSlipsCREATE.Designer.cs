namespace REMAS.Forms.Accounting
{
    partial class frmChequeDepositSlipsCREATE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChequeDepositSlipsCREATE));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLoadCheques = new System.Windows.Forms.Button();
            this.btnPublishDepositSlip = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnlPaymenVouchers = new System.Windows.Forms.Panel();
            this.btnPaymentVouchers = new System.Windows.Forms.Button();
            this.pnlPeriod = new System.Windows.Forms.Panel();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.sptPeriod = new REMAS.Contoller.Separators();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txbStartDate = new REMAS.Contoller.RJTextBox();
            this.txbEndDate = new REMAS.Contoller.RJTextBox();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnCalendarEndDate = new System.Windows.Forms.Button();
            this.pnlCompanyCurrency = new System.Windows.Forms.Panel();
            this.lblCuurency = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblDepositDate = new System.Windows.Forms.Label();
            this.txtSearch = new REMAS.Contoller.RJTextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtCurrency = new REMAS.Contoller.RJTextBox();
            this.btnFindCurrency = new System.Windows.Forms.Button();
            this.txtDepositDate = new REMAS.Contoller.RJTextBox();
            this.btnCalendarDepositDate = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlPaymentVouchers = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlPaymenVouchers.SuspendLayout();
            this.pnlPeriod.SuspendLayout();
            this.pnlCompanyCurrency.SuspendLayout();
            this.pnlPaymentVouchers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHeader.Controls.Add(this.btnSetting);
            this.pnlHeader.Controls.Add(this.btnNotes);
            this.pnlHeader.Controls.Add(this.btnList);
            this.pnlHeader.Controls.Add(this.btnRight);
            this.pnlHeader.Controls.Add(this.btnLeft);
            this.pnlHeader.Controls.Add(this.btnPublishDepositSlip);
            this.pnlHeader.Controls.Add(this.btnLoadCheques);
            this.pnlHeader.Controls.Add(this.btnDown);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.btnPlus);
            this.pnlHeader.Controls.Add(this.btnSave);
            this.pnlHeader.Location = new System.Drawing.Point(5, 6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1176, 37);
            this.pnlHeader.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.btnRefresh.Location = new System.Drawing.Point(74, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 26);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::REMAS.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(38, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(31, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Image = global::REMAS.Properties.Resources.PlusLg;
            this.btnPlus.Location = new System.Drawing.Point(7, 5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(31, 26);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(108, 5);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(31, 26);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Visible = false;
            // 
            // btnLoadCheques
            // 
            this.btnLoadCheques.FlatAppearance.BorderSize = 0;
            this.btnLoadCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadCheques.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCheques.Image")));
            this.btnLoadCheques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadCheques.Location = new System.Drawing.Point(161, 5);
            this.btnLoadCheques.Name = "btnLoadCheques";
            this.btnLoadCheques.Size = new System.Drawing.Size(108, 26);
            this.btnLoadCheques.TabIndex = 4;
            this.btnLoadCheques.Text = "Load cheques";
            this.btnLoadCheques.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCheques.UseVisualStyleBackColor = true;
            this.btnLoadCheques.Visible = false;
            // 
            // btnPublishDepositSlip
            // 
            this.btnPublishDepositSlip.FlatAppearance.BorderSize = 0;
            this.btnPublishDepositSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublishDepositSlip.Image = ((System.Drawing.Image)(resources.GetObject("btnPublishDepositSlip.Image")));
            this.btnPublishDepositSlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublishDepositSlip.Location = new System.Drawing.Point(266, 5);
            this.btnPublishDepositSlip.Name = "btnPublishDepositSlip";
            this.btnPublishDepositSlip.Size = new System.Drawing.Size(122, 26);
            this.btnPublishDepositSlip.TabIndex = 5;
            this.btnPublishDepositSlip.Text = "Publish deposit slip";
            this.btnPublishDepositSlip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPublishDepositSlip.UseVisualStyleBackColor = true;
            this.btnPublishDepositSlip.Visible = false;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(1039, 7);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(25, 23);
            this.btnLeft.TabIndex = 64;
            this.btnLeft.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = global::REMAS.Properties.Resources.icons8_back_24__1_;
            this.btnRight.Location = new System.Drawing.Point(1062, 7);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(25, 23);
            this.btnRight.TabIndex = 65;
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(1083, 5);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(31, 26);
            this.btnList.TabIndex = 6;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Visible = false;
            // 
            // btnNotes
            // 
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnNotes.Image")));
            this.btnNotes.Location = new System.Drawing.Point(1109, 5);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(31, 26);
            this.btnNotes.TabIndex = 66;
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Visible = false;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(1137, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(31, 26);
            this.btnSetting.TabIndex = 67;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Visible = false;
            // 
            // pnlPaymenVouchers
            // 
            this.pnlPaymenVouchers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPaymenVouchers.Controls.Add(this.btnPaymentVouchers);
            this.pnlPaymenVouchers.Location = new System.Drawing.Point(5, 55);
            this.pnlPaymenVouchers.Name = "pnlPaymenVouchers";
            this.pnlPaymenVouchers.Size = new System.Drawing.Size(1176, 77);
            this.pnlPaymenVouchers.TabIndex = 21;
            // 
            // btnPaymentVouchers
            // 
            this.btnPaymentVouchers.BackColor = System.Drawing.Color.Red;
            this.btnPaymentVouchers.FlatAppearance.BorderSize = 0;
            this.btnPaymentVouchers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentVouchers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentVouchers.ForeColor = System.Drawing.Color.White;
            this.btnPaymentVouchers.Location = new System.Drawing.Point(15, 19);
            this.btnPaymentVouchers.Name = "btnPaymentVouchers";
            this.btnPaymentVouchers.Size = new System.Drawing.Size(543, 36);
            this.btnPaymentVouchers.TabIndex = 21;
            this.btnPaymentVouchers.Text = "Payment vouchers on invoice setting is disabled";
            this.btnPaymentVouchers.UseVisualStyleBackColor = false;
            // 
            // pnlPeriod
            // 
            this.pnlPeriod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPeriod.Controls.Add(this.btnCalendarEndDate);
            this.pnlPeriod.Controls.Add(this.btnCalendar);
            this.pnlPeriod.Controls.Add(this.txbEndDate);
            this.pnlPeriod.Controls.Add(this.txbStartDate);
            this.pnlPeriod.Controls.Add(this.lblEndDate);
            this.pnlPeriod.Controls.Add(this.sptPeriod);
            this.pnlPeriod.Controls.Add(this.lblStartDate);
            this.pnlPeriod.Controls.Add(this.lblPeriod);
            this.pnlPeriod.Location = new System.Drawing.Point(5, 138);
            this.pnlPeriod.Name = "pnlPeriod";
            this.pnlPeriod.Size = new System.Drawing.Size(1176, 148);
            this.pnlPeriod.TabIndex = 22;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(7, 10);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(47, 17);
            this.lblPeriod.TabIndex = 23;
            this.lblPeriod.Text = "Period";
            // 
            // sptPeriod
            // 
            this.sptPeriod.ForeColor = System.Drawing.Color.DarkGray;
            this.sptPeriod.isVertical = false;
            this.sptPeriod.Location = new System.Drawing.Point(1, 30);
            this.sptPeriod.Name = "sptPeriod";
            this.sptPeriod.Size = new System.Drawing.Size(1172, 10);
            this.sptPeriod.TabIndex = 47;
            this.sptPeriod.Text = "separators3";
            this.sptPeriod.Thickness = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(7, 43);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(68, 17);
            this.lblStartDate.TabIndex = 24;
            this.lblStartDate.Text = "Start date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(601, 43);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(62, 17);
            this.lblEndDate.TabIndex = 25;
            this.lblEndDate.Text = "End date";
            // 
            // txbStartDate
            // 
            this.txbStartDate.BackColor = System.Drawing.SystemColors.Window;
            this.txbStartDate.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbStartDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbStartDate.BorderRadius = 0;
            this.txbStartDate.BorderSize = 1;
            this.txbStartDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbStartDate.Location = new System.Drawing.Point(10, 64);
            this.txbStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbStartDate.MaxLength = 250;
            this.txbStartDate.Multiline = false;
            this.txbStartDate.Name = "txbStartDate";
            this.txbStartDate.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbStartDate.PasswordChar = false;
            this.txbStartDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbStartDate.PlaceholderText = "";
            this.txbStartDate.ReadOnly = false;
            this.txbStartDate.Size = new System.Drawing.Size(548, 29);
            this.txbStartDate.TabIndex = 86;
            this.txbStartDate.Texts = "";
            this.txbStartDate.UnderlinedStyle = true;
            // 
            // txbEndDate
            // 
            this.txbEndDate.BackColor = System.Drawing.SystemColors.Window;
            this.txbEndDate.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbEndDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbEndDate.BorderRadius = 0;
            this.txbEndDate.BorderSize = 1;
            this.txbEndDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbEndDate.Location = new System.Drawing.Point(604, 64);
            this.txbEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbEndDate.MaxLength = 250;
            this.txbEndDate.Multiline = false;
            this.txbEndDate.Name = "txbEndDate";
            this.txbEndDate.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbEndDate.PasswordChar = false;
            this.txbEndDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEndDate.PlaceholderText = "";
            this.txbEndDate.ReadOnly = false;
            this.txbEndDate.Size = new System.Drawing.Size(548, 29);
            this.txbEndDate.TabIndex = 87;
            this.txbEndDate.Texts = "";
            this.txbEndDate.UnderlinedStyle = true;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendar.Location = new System.Drawing.Point(527, 66);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(31, 26);
            this.btnCalendar.TabIndex = 86;
            this.btnCalendar.UseVisualStyleBackColor = false;
            // 
            // btnCalendarEndDate
            // 
            this.btnCalendarEndDate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendarEndDate.FlatAppearance.BorderSize = 0;
            this.btnCalendarEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarEndDate.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarEndDate.Location = new System.Drawing.Point(1121, 66);
            this.btnCalendarEndDate.Name = "btnCalendarEndDate";
            this.btnCalendarEndDate.Size = new System.Drawing.Size(31, 26);
            this.btnCalendarEndDate.TabIndex = 86;
            this.btnCalendarEndDate.UseVisualStyleBackColor = false;
            // 
            // pnlCompanyCurrency
            // 
            this.pnlCompanyCurrency.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCompanyCurrency.Controls.Add(this.lblDateTime);
            this.pnlCompanyCurrency.Controls.Add(this.btnCalendarDepositDate);
            this.pnlCompanyCurrency.Controls.Add(this.txtDepositDate);
            this.pnlCompanyCurrency.Controls.Add(this.btnFindCurrency);
            this.pnlCompanyCurrency.Controls.Add(this.txtCurrency);
            this.pnlCompanyCurrency.Controls.Add(this.btnFind);
            this.pnlCompanyCurrency.Controls.Add(this.txtSearch);
            this.pnlCompanyCurrency.Controls.Add(this.lblDepositDate);
            this.pnlCompanyCurrency.Controls.Add(this.lblCuurency);
            this.pnlCompanyCurrency.Controls.Add(this.lblCompany);
            this.pnlCompanyCurrency.Location = new System.Drawing.Point(6, 292);
            this.pnlCompanyCurrency.Name = "pnlCompanyCurrency";
            this.pnlCompanyCurrency.Size = new System.Drawing.Size(1176, 148);
            this.pnlCompanyCurrency.TabIndex = 88;
            // 
            // lblCuurency
            // 
            this.lblCuurency.AutoSize = true;
            this.lblCuurency.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuurency.Location = new System.Drawing.Point(388, 12);
            this.lblCuurency.Name = "lblCuurency";
            this.lblCuurency.Size = new System.Drawing.Size(62, 17);
            this.lblCuurency.TabIndex = 25;
            this.lblCuurency.Text = "Currency";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(6, 12);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(66, 17);
            this.lblCompany.TabIndex = 24;
            this.lblCompany.Text = "Company";
            // 
            // lblDepositDate
            // 
            this.lblDepositDate.AutoSize = true;
            this.lblDepositDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositDate.Location = new System.Drawing.Point(804, 12);
            this.lblDepositDate.Name = "lblDepositDate";
            this.lblDepositDate.Size = new System.Drawing.Size(85, 17);
            this.lblDepositDate.TabIndex = 26;
            this.lblDepositDate.Text = "Deposit date";
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
            this.txtSearch.Location = new System.Drawing.Point(9, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 250;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(339, 29);
            this.txtSearch.TabIndex = 89;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(317, 44);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(31, 26);
            this.btnFind.TabIndex = 89;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtCurrency
            // 
            this.txtCurrency.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrency.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtCurrency.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtCurrency.BorderRadius = 0;
            this.txtCurrency.BorderSize = 1;
            this.txtCurrency.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrency.Location = new System.Drawing.Point(391, 43);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrency.MaxLength = 250;
            this.txtCurrency.Multiline = false;
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtCurrency.PasswordChar = false;
            this.txtCurrency.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCurrency.PlaceholderText = "";
            this.txtCurrency.ReadOnly = false;
            this.txtCurrency.Size = new System.Drawing.Size(339, 29);
            this.txtCurrency.TabIndex = 90;
            this.txtCurrency.Texts = "";
            this.txtCurrency.UnderlinedStyle = true;
            // 
            // btnFindCurrency
            // 
            this.btnFindCurrency.BackColor = System.Drawing.Color.Transparent;
            this.btnFindCurrency.FlatAppearance.BorderSize = 0;
            this.btnFindCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCurrency.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCurrency.Image")));
            this.btnFindCurrency.Location = new System.Drawing.Point(699, 44);
            this.btnFindCurrency.Name = "btnFindCurrency";
            this.btnFindCurrency.Size = new System.Drawing.Size(31, 26);
            this.btnFindCurrency.TabIndex = 91;
            this.btnFindCurrency.UseVisualStyleBackColor = false;
            // 
            // txtDepositDate
            // 
            this.txtDepositDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDepositDate.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtDepositDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtDepositDate.BorderRadius = 0;
            this.txtDepositDate.BorderSize = 1;
            this.txtDepositDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDepositDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDepositDate.Location = new System.Drawing.Point(807, 43);
            this.txtDepositDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepositDate.MaxLength = 250;
            this.txtDepositDate.Multiline = false;
            this.txtDepositDate.Name = "txtDepositDate";
            this.txtDepositDate.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtDepositDate.PasswordChar = false;
            this.txtDepositDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDepositDate.PlaceholderText = "";
            this.txtDepositDate.ReadOnly = false;
            this.txtDepositDate.Size = new System.Drawing.Size(339, 29);
            this.txtDepositDate.TabIndex = 92;
            this.txtDepositDate.Texts = "";
            this.txtDepositDate.UnderlinedStyle = true;
            // 
            // btnCalendarDepositDate
            // 
            this.btnCalendarDepositDate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendarDepositDate.FlatAppearance.BorderSize = 0;
            this.btnCalendarDepositDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarDepositDate.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarDepositDate.Location = new System.Drawing.Point(1115, 43);
            this.btnCalendarDepositDate.Name = "btnCalendarDepositDate";
            this.btnCalendarDepositDate.Size = new System.Drawing.Size(31, 26);
            this.btnCalendarDepositDate.TabIndex = 88;
            this.btnCalendarDepositDate.UseVisualStyleBackColor = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(809, 49);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(74, 17);
            this.lblDateTime.TabIndex = 89;
            this.lblDateTime.Text = "05/04/2023";
            // 
            // pnlPaymentVouchers
            // 
            this.pnlPaymentVouchers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPaymentVouchers.Controls.Add(this.dgvList);
            this.pnlPaymentVouchers.Controls.Add(this.label6);
            this.pnlPaymentVouchers.Location = new System.Drawing.Point(5, 446);
            this.pnlPaymentVouchers.Name = "pnlPaymentVouchers";
            this.pnlPaymentVouchers.Size = new System.Drawing.Size(1176, 142);
            this.pnlPaymentVouchers.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "Payment vouchers";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
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
            this.Column1,
            this.MenuName,
            this.MainRoot,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvList.Location = new System.Drawing.Point(10, 38);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(1163, 80);
            this.dgvList.TabIndex = 89;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // MenuName
            // 
            this.MenuName.FillWeight = 150F;
            this.MenuName.HeaderText = "Reference";
            this.MenuName.Name = "MenuName";
            this.MenuName.Width = 150;
            // 
            // MainRoot
            // 
            this.MainRoot.HeaderText = "Partner";
            this.MainRoot.Name = "MainRoot";
            this.MainRoot.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Payment date";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount paid";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Currency";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cheque owner";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Bank deposit date";
            this.Column6.Name = "Column6";
            this.Column6.Width = 159;
            // 
            // frmChequeDepositSlipsCREATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlPaymentVouchers);
            this.Controls.Add(this.pnlCompanyCurrency);
            this.Controls.Add(this.pnlPeriod);
            this.Controls.Add(this.pnlPaymenVouchers);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChequeDepositSlipsCREATE";
            this.Text = "frmChequeDepositSlipsCREATE";
            this.pnlHeader.ResumeLayout(false);
            this.pnlPaymenVouchers.ResumeLayout(false);
            this.pnlPeriod.ResumeLayout(false);
            this.pnlPeriod.PerformLayout();
            this.pnlCompanyCurrency.ResumeLayout(false);
            this.pnlCompanyCurrency.PerformLayout();
            this.pnlPaymentVouchers.ResumeLayout(false);
            this.pnlPaymentVouchers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPublishDepositSlip;
        private System.Windows.Forms.Button btnLoadCheques;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel pnlPaymenVouchers;
        private System.Windows.Forms.Button btnPaymentVouchers;
        private System.Windows.Forms.Panel pnlPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private Contoller.Separators sptPeriod;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private Contoller.RJTextBox txbEndDate;
        private Contoller.RJTextBox txbStartDate;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnCalendarEndDate;
        private System.Windows.Forms.Panel pnlCompanyCurrency;
        private System.Windows.Forms.Label lblDepositDate;
        private System.Windows.Forms.Label lblCuurency;
        private System.Windows.Forms.Label lblCompany;
        private Contoller.RJTextBox txtSearch;
        private System.Windows.Forms.Button btnFindCurrency;
        private Contoller.RJTextBox txtCurrency;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCalendarDepositDate;
        private Contoller.RJTextBox txtDepositDate;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlPaymentVouchers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}