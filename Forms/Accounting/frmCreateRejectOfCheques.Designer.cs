namespace REMAS.Forms.Accounting
{
    partial class frmCreateRejectOfCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateRejectOfCheques));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new REMAS.Contoller.RJTextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblDraft = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblRejectionMove = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.separators4 = new REMAS.Contoller.Separators();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnSaveAction = new System.Windows.Forms.Button();
            this.btnValidateReject = new System.Windows.Forms.Button();
            this.sptAction = new REMAS.Contoller.Separators();
            this.lblAction = new System.Windows.Forms.Label();
            this.pnlRejectInformation = new System.Windows.Forms.Panel();
            this.lblRejectedAmountInformation = new System.Windows.Forms.Label();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.txbRejectionReason = new REMAS.Contoller.RJTextBox();
            this.txbRejectionDate = new REMAS.Contoller.RJTextBox();
            this.sptRejectInformation = new REMAS.Contoller.Separators();
            this.lblRejectedAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRejectionDate = new System.Windows.Forms.Label();
            this.lblRejectionReason = new System.Windows.Forms.Label();
            this.lblRejectInformation = new System.Windows.Forms.Label();
            this.txbDescription = new REMAS.Contoller.RJTextBox();
            this.pnlPaymentRejected = new System.Windows.Forms.Panel();
            this.lblStatusPaymentRejected = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.sptPaymentRejected = new REMAS.Contoller.Separators();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPaymentVoucher = new System.Windows.Forms.Label();
            this.lblReferencePaymentRejected = new System.Windows.Forms.Label();
            this.lblPaymentRejected = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlRejectInformation.SuspendLayout();
            this.pnlPaymentRejected.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.btnSave);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1176, 37);
            this.pnlHeader.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.btnRefresh.Location = new System.Drawing.Point(1115, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 26);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeader.Location = new System.Drawing.Point(19, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(157, 17);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Create Reject of cheques";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::REMAS.Properties.Resources.XLg;
            this.btnClose.Location = new System.Drawing.Point(1142, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::REMAS.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(1086, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(31, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBody.Controls.Add(this.btnFind);
            this.pnlBody.Controls.Add(this.txtSearch);
            this.pnlBody.Controls.Add(this.lblCustomer);
            this.pnlBody.Controls.Add(this.lblDateTime);
            this.pnlBody.Controls.Add(this.lblDate);
            this.pnlBody.Controls.Add(this.cmbCompany);
            this.pnlBody.Controls.Add(this.lblCompany);
            this.pnlBody.Controls.Add(this.lblDraft);
            this.pnlBody.Controls.Add(this.lblReference);
            this.pnlBody.Controls.Add(this.lblRejectionMove);
            this.pnlBody.Controls.Add(this.lblStatus);
            this.pnlBody.Controls.Add(this.separators4);
            this.pnlBody.Location = new System.Drawing.Point(12, 62);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(782, 253);
            this.pnlBody.TabIndex = 19;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(487, 208);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(31, 26);
            this.btnFind.TabIndex = 84;
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
            this.txtSearch.Location = new System.Drawing.Point(16, 208);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 250;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(502, 29);
            this.txtSearch.TabIndex = 83;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(13, 192);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(67, 17);
            this.lblCustomer.TabIndex = 45;
            this.lblCustomer.Text = "Customer";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(528, 64);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(109, 17);
            this.lblDateTime.TabIndex = 26;
            this.lblDateTime.Text = "28/03/2024 15:49";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(528, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 17);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date";
            // 
            // cmbCompany
            // 
            this.cmbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCompany.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Items.AddRange(new object[] {
            "THIRD PARTIES",
            "CONSOLIDATED PARTIES",
            "RELATED PARTIES"});
            this.cmbCompany.Location = new System.Drawing.Point(15, 155);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(503, 21);
            this.cmbCompany.TabIndex = 43;
            this.cmbCompany.Text = "ARAI RUBBER SEAL INDONESIA";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(12, 120);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(66, 17);
            this.lblCompany.TabIndex = 26;
            this.lblCompany.Text = "Company";
            // 
            // lblDraft
            // 
            this.lblDraft.AutoSize = true;
            this.lblDraft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraft.Location = new System.Drawing.Point(12, 47);
            this.lblDraft.Name = "lblDraft";
            this.lblDraft.Size = new System.Drawing.Size(37, 17);
            this.lblDraft.TabIndex = 23;
            this.lblDraft.Text = "Draft";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Location = new System.Drawing.Point(12, 83);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(67, 17);
            this.lblReference.TabIndex = 22;
            this.lblReference.Text = "Reference";
            // 
            // lblRejectionMove
            // 
            this.lblRejectionMove.AutoSize = true;
            this.lblRejectionMove.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectionMove.Location = new System.Drawing.Point(528, 16);
            this.lblRejectionMove.Name = "lblRejectionMove";
            this.lblRejectionMove.Size = new System.Drawing.Size(101, 17);
            this.lblRejectionMove.TabIndex = 21;
            this.lblRejectionMove.Text = "Rejection move";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            // 
            // separators4
            // 
            this.separators4.ForeColor = System.Drawing.Color.DarkGray;
            this.separators4.isVertical = false;
            this.separators4.Location = new System.Drawing.Point(15, 174);
            this.separators4.Name = "separators4";
            this.separators4.Size = new System.Drawing.Size(503, 10);
            this.separators4.TabIndex = 44;
            this.separators4.Text = "separators4";
            this.separators4.Thickness = 1;
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAction.Controls.Add(this.btnSaveAction);
            this.pnlAction.Controls.Add(this.btnValidateReject);
            this.pnlAction.Controls.Add(this.sptAction);
            this.pnlAction.Controls.Add(this.lblAction);
            this.pnlAction.Location = new System.Drawing.Point(809, 62);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(379, 155);
            this.pnlAction.TabIndex = 20;
            // 
            // btnSaveAction
            // 
            this.btnSaveAction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveAction.FlatAppearance.BorderSize = 0;
            this.btnSaveAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAction.ForeColor = System.Drawing.Color.White;
            this.btnSaveAction.Location = new System.Drawing.Point(8, 89);
            this.btnSaveAction.Name = "btnSaveAction";
            this.btnSaveAction.Size = new System.Drawing.Size(365, 36);
            this.btnSaveAction.TabIndex = 23;
            this.btnSaveAction.Text = "Save";
            this.btnSaveAction.UseVisualStyleBackColor = false;
            // 
            // btnValidateReject
            // 
            this.btnValidateReject.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnValidateReject.FlatAppearance.BorderSize = 0;
            this.btnValidateReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateReject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateReject.ForeColor = System.Drawing.Color.White;
            this.btnValidateReject.Location = new System.Drawing.Point(8, 47);
            this.btnValidateReject.Name = "btnValidateReject";
            this.btnValidateReject.Size = new System.Drawing.Size(365, 36);
            this.btnValidateReject.TabIndex = 22;
            this.btnValidateReject.Text = "Validate reject";
            this.btnValidateReject.UseVisualStyleBackColor = false;
            // 
            // sptAction
            // 
            this.sptAction.ForeColor = System.Drawing.Color.DarkGray;
            this.sptAction.isVertical = false;
            this.sptAction.Location = new System.Drawing.Point(1, 28);
            this.sptAction.Name = "sptAction";
            this.sptAction.Size = new System.Drawing.Size(376, 10);
            this.sptAction.TabIndex = 45;
            this.sptAction.Text = "separators1";
            this.sptAction.Thickness = 1;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(8, 8);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(48, 17);
            this.lblAction.TabIndex = 20;
            this.lblAction.Text = "Action";
            // 
            // pnlRejectInformation
            // 
            this.pnlRejectInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlRejectInformation.Controls.Add(this.lblRejectedAmountInformation);
            this.pnlRejectInformation.Controls.Add(this.btnCalendar);
            this.pnlRejectInformation.Controls.Add(this.txbRejectionReason);
            this.pnlRejectInformation.Controls.Add(this.txbRejectionDate);
            this.pnlRejectInformation.Controls.Add(this.sptRejectInformation);
            this.pnlRejectInformation.Controls.Add(this.lblRejectedAmount);
            this.pnlRejectInformation.Controls.Add(this.lblDescription);
            this.pnlRejectInformation.Controls.Add(this.lblRejectionDate);
            this.pnlRejectInformation.Controls.Add(this.lblRejectionReason);
            this.pnlRejectInformation.Controls.Add(this.lblRejectInformation);
            this.pnlRejectInformation.Controls.Add(this.txbDescription);
            this.pnlRejectInformation.Location = new System.Drawing.Point(12, 321);
            this.pnlRejectInformation.Name = "pnlRejectInformation";
            this.pnlRejectInformation.Size = new System.Drawing.Size(782, 192);
            this.pnlRejectInformation.TabIndex = 21;
            // 
            // lblRejectedAmountInformation
            // 
            this.lblRejectedAmountInformation.AutoSize = true;
            this.lblRejectedAmountInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectedAmountInformation.Location = new System.Drawing.Point(423, 145);
            this.lblRejectedAmountInformation.Name = "lblRejectedAmountInformation";
            this.lblRejectedAmountInformation.Size = new System.Drawing.Size(32, 17);
            this.lblRejectedAmountInformation.TabIndex = 27;
            this.lblRejectedAmountInformation.Text = "0.00";
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendar.Location = new System.Drawing.Point(313, 72);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(31, 26);
            this.btnCalendar.TabIndex = 85;
            this.btnCalendar.UseVisualStyleBackColor = false;
            // 
            // txbRejectionReason
            // 
            this.txbRejectionReason.BackColor = System.Drawing.SystemColors.Window;
            this.txbRejectionReason.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbRejectionReason.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbRejectionReason.BorderRadius = 0;
            this.txbRejectionReason.BorderSize = 1;
            this.txbRejectionReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbRejectionReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRejectionReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRejectionReason.Location = new System.Drawing.Point(426, 70);
            this.txbRejectionReason.Margin = new System.Windows.Forms.Padding(4);
            this.txbRejectionReason.MaxLength = 250;
            this.txbRejectionReason.Multiline = false;
            this.txbRejectionReason.Name = "txbRejectionReason";
            this.txbRejectionReason.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbRejectionReason.PasswordChar = false;
            this.txbRejectionReason.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbRejectionReason.PlaceholderText = "";
            this.txbRejectionReason.ReadOnly = false;
            this.txbRejectionReason.Size = new System.Drawing.Size(325, 29);
            this.txbRejectionReason.TabIndex = 86;
            this.txbRejectionReason.Texts = "";
            this.txbRejectionReason.UnderlinedStyle = true;
            // 
            // txbRejectionDate
            // 
            this.txbRejectionDate.BackColor = System.Drawing.SystemColors.Window;
            this.txbRejectionDate.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbRejectionDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbRejectionDate.BorderRadius = 0;
            this.txbRejectionDate.BorderSize = 1;
            this.txbRejectionDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbRejectionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRejectionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRejectionDate.Location = new System.Drawing.Point(15, 70);
            this.txbRejectionDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbRejectionDate.MaxLength = 250;
            this.txbRejectionDate.Multiline = false;
            this.txbRejectionDate.Name = "txbRejectionDate";
            this.txbRejectionDate.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbRejectionDate.PasswordChar = false;
            this.txbRejectionDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbRejectionDate.PlaceholderText = "";
            this.txbRejectionDate.ReadOnly = false;
            this.txbRejectionDate.Size = new System.Drawing.Size(329, 29);
            this.txbRejectionDate.TabIndex = 85;
            this.txbRejectionDate.Texts = "";
            this.txbRejectionDate.UnderlinedStyle = true;
            // 
            // sptRejectInformation
            // 
            this.sptRejectInformation.ForeColor = System.Drawing.Color.DarkGray;
            this.sptRejectInformation.isVertical = false;
            this.sptRejectInformation.Location = new System.Drawing.Point(2, 36);
            this.sptRejectInformation.Name = "sptRejectInformation";
            this.sptRejectInformation.Size = new System.Drawing.Size(780, 10);
            this.sptRejectInformation.TabIndex = 46;
            this.sptRejectInformation.Text = "separators3";
            this.sptRejectInformation.Thickness = 1;
            // 
            // lblRejectedAmount
            // 
            this.lblRejectedAmount.AutoSize = true;
            this.lblRejectedAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectedAmount.Location = new System.Drawing.Point(423, 120);
            this.lblRejectedAmount.Name = "lblRejectedAmount";
            this.lblRejectedAmount.Size = new System.Drawing.Size(111, 17);
            this.lblRejectedAmount.TabIndex = 25;
            this.lblRejectedAmount.Text = "Rejected amount";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 17);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description";
            // 
            // lblRejectionDate
            // 
            this.lblRejectionDate.AutoSize = true;
            this.lblRejectionDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectionDate.Location = new System.Drawing.Point(13, 49);
            this.lblRejectionDate.Name = "lblRejectionDate";
            this.lblRejectionDate.Size = new System.Drawing.Size(94, 17);
            this.lblRejectionDate.TabIndex = 22;
            this.lblRejectionDate.Text = "Rejection date";
            // 
            // lblRejectionReason
            // 
            this.lblRejectionReason.AutoSize = true;
            this.lblRejectionReason.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectionReason.Location = new System.Drawing.Point(423, 49);
            this.lblRejectionReason.Name = "lblRejectionReason";
            this.lblRejectionReason.Size = new System.Drawing.Size(108, 17);
            this.lblRejectionReason.TabIndex = 21;
            this.lblRejectionReason.Text = "Rejection reason";
            // 
            // lblRejectInformation
            // 
            this.lblRejectInformation.AutoSize = true;
            this.lblRejectInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectInformation.Location = new System.Drawing.Point(12, 16);
            this.lblRejectInformation.Name = "lblRejectInformation";
            this.lblRejectInformation.Size = new System.Drawing.Size(119, 17);
            this.lblRejectInformation.TabIndex = 19;
            this.lblRejectInformation.Text = "Reject information";
            // 
            // txbDescription
            // 
            this.txbDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txbDescription.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbDescription.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbDescription.BorderRadius = 0;
            this.txbDescription.BorderSize = 1;
            this.txbDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDescription.Location = new System.Drawing.Point(15, 133);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescription.MaxLength = 250;
            this.txbDescription.Multiline = false;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbDescription.PasswordChar = false;
            this.txbDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDescription.PlaceholderText = "";
            this.txbDescription.ReadOnly = false;
            this.txbDescription.Size = new System.Drawing.Size(329, 29);
            this.txbDescription.TabIndex = 84;
            this.txbDescription.Texts = "";
            this.txbDescription.UnderlinedStyle = true;
            // 
            // pnlPaymentRejected
            // 
            this.pnlPaymentRejected.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPaymentRejected.Controls.Add(this.lblStatusPaymentRejected);
            this.pnlPaymentRejected.Controls.Add(this.lblAmountPaid);
            this.pnlPaymentRejected.Controls.Add(this.lblPaymentDate);
            this.pnlPaymentRejected.Controls.Add(this.sptPaymentRejected);
            this.pnlPaymentRejected.Controls.Add(this.lblPaymentMode);
            this.pnlPaymentRejected.Controls.Add(this.lblUser);
            this.pnlPaymentRejected.Controls.Add(this.lblPaymentVoucher);
            this.pnlPaymentRejected.Controls.Add(this.lblReferencePaymentRejected);
            this.pnlPaymentRejected.Controls.Add(this.lblPaymentRejected);
            this.pnlPaymentRejected.Location = new System.Drawing.Point(12, 519);
            this.pnlPaymentRejected.Name = "pnlPaymentRejected";
            this.pnlPaymentRejected.Size = new System.Drawing.Size(782, 318);
            this.pnlPaymentRejected.TabIndex = 22;
            // 
            // lblStatusPaymentRejected
            // 
            this.lblStatusPaymentRejected.AutoSize = true;
            this.lblStatusPaymentRejected.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPaymentRejected.Location = new System.Drawing.Point(13, 263);
            this.lblStatusPaymentRejected.Name = "lblStatusPaymentRejected";
            this.lblStatusPaymentRejected.Size = new System.Drawing.Size(46, 17);
            this.lblStatusPaymentRejected.TabIndex = 49;
            this.lblStatusPaymentRejected.Text = "Status";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(423, 196);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(88, 17);
            this.lblAmountPaid.TabIndex = 48;
            this.lblAmountPaid.Text = "Amount paid";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(13, 196);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(93, 17);
            this.lblPaymentDate.TabIndex = 47;
            this.lblPaymentDate.Text = "Payment date";
            // 
            // sptPaymentRejected
            // 
            this.sptPaymentRejected.ForeColor = System.Drawing.Color.DarkGray;
            this.sptPaymentRejected.isVertical = false;
            this.sptPaymentRejected.Location = new System.Drawing.Point(2, 36);
            this.sptPaymentRejected.Name = "sptPaymentRejected";
            this.sptPaymentRejected.Size = new System.Drawing.Size(780, 10);
            this.sptPaymentRejected.TabIndex = 46;
            this.sptPaymentRejected.Text = "separators2";
            this.sptPaymentRejected.Thickness = 1;
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMode.Location = new System.Drawing.Point(423, 120);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(101, 17);
            this.lblPaymentMode.TabIndex = 25;
            this.lblPaymentMode.Text = "Payment mode";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 120);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 17);
            this.lblUser.TabIndex = 26;
            this.lblUser.Text = "User";
            // 
            // lblPaymentVoucher
            // 
            this.lblPaymentVoucher.AutoSize = true;
            this.lblPaymentVoucher.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentVoucher.Location = new System.Drawing.Point(13, 49);
            this.lblPaymentVoucher.Name = "lblPaymentVoucher";
            this.lblPaymentVoucher.Size = new System.Drawing.Size(115, 17);
            this.lblPaymentVoucher.TabIndex = 22;
            this.lblPaymentVoucher.Text = "Payment voucher";
            // 
            // lblReferencePaymentRejected
            // 
            this.lblReferencePaymentRejected.AutoSize = true;
            this.lblReferencePaymentRejected.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencePaymentRejected.Location = new System.Drawing.Point(423, 49);
            this.lblReferencePaymentRejected.Name = "lblReferencePaymentRejected";
            this.lblReferencePaymentRejected.Size = new System.Drawing.Size(67, 17);
            this.lblReferencePaymentRejected.TabIndex = 21;
            this.lblReferencePaymentRejected.Text = "Reference";
            // 
            // lblPaymentRejected
            // 
            this.lblPaymentRejected.AutoSize = true;
            this.lblPaymentRejected.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentRejected.Location = new System.Drawing.Point(12, 16);
            this.lblPaymentRejected.Name = "lblPaymentRejected";
            this.lblPaymentRejected.Size = new System.Drawing.Size(117, 17);
            this.lblPaymentRejected.TabIndex = 19;
            this.lblPaymentRejected.Text = "Payment Rejected";
            // 
            // frmCreateRejectOfCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 580);
            this.Controls.Add(this.pnlPaymentRejected);
            this.Controls.Add(this.pnlRejectInformation);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateRejectOfCheques";
            this.Text = "frmCreateRejectOfCheques";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            this.pnlRejectInformation.ResumeLayout(false);
            this.pnlRejectInformation.PerformLayout();
            this.pnlPaymentRejected.ResumeLayout(false);
            this.pnlPaymentRejected.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblDraft;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblRejectionMove;
        private System.Windows.Forms.Label lblStatus;
        private Contoller.Separators separators4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlAction;
        private Contoller.Separators sptAction;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnSaveAction;
        private System.Windows.Forms.Button btnValidateReject;
        private System.Windows.Forms.Panel pnlRejectInformation;
        private System.Windows.Forms.Label lblRejectedAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRejectionDate;
        private System.Windows.Forms.Label lblRejectionReason;
        private System.Windows.Forms.Label lblRejectInformation;
        private System.Windows.Forms.Label lblCustomer;
        private Contoller.RJTextBox txtSearch;
        private System.Windows.Forms.Button btnFind;
        private Contoller.Separators sptRejectInformation;
        private System.Windows.Forms.Label lblRejectedAmountInformation;
        private System.Windows.Forms.Button btnCalendar;
        private Contoller.RJTextBox txbRejectionReason;
        private Contoller.RJTextBox txbRejectionDate;
        private Contoller.RJTextBox txbDescription;
        private System.Windows.Forms.Panel pnlPaymentRejected;
        private Contoller.Separators sptPaymentRejected;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPaymentVoucher;
        private System.Windows.Forms.Label lblReferencePaymentRejected;
        private System.Windows.Forms.Label lblPaymentRejected;
        private System.Windows.Forms.Label lblStatusPaymentRejected;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblPaymentDate;
    }
}