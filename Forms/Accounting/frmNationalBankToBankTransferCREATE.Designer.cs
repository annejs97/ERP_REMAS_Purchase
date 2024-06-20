namespace REMAS.Forms.Accounting
{
    partial class frmNationalBankToBankTransferCREATE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNationalBankToBankTransferCREATE));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlSequence = new System.Windows.Forms.Panel();
            this.btnFindPaymentMode = new System.Windows.Forms.Button();
            this.txbFileFormat = new REMAS.Contoller.RJTextBox();
            this.txbPaymentMode = new REMAS.Contoller.RJTextBox();
            this.txbBankOrderDueDate = new REMAS.Contoller.RJTextBox();
            this.btnNewRelease = new System.Windows.Forms.Button();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblFileFormat = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnAwaitingSignature = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.sptStatus = new REMAS.Contoller.Separators();
            this.label13 = new System.Windows.Forms.Label();
            this.btnValidated = new System.Windows.Forms.Button();
            this.btnCarriedOut = new System.Windows.Forms.Button();
            this.btnRejected = new System.Windows.Forms.Button();
            this.btnCancelled = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.lblBankOrderDueDate = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnFindFileFormat = new System.Windows.Forms.Button();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.separators1 = new REMAS.Contoller.Separators();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.sptAction = new REMAS.Contoller.Separators();
            this.lblAction = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSequence.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.btnSave);
            this.pnlHeader.Location = new System.Drawing.Point(10, 8);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1176, 37);
            this.pnlHeader.TabIndex = 5;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeader.Location = new System.Drawing.Point(19, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(239, 17);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Create National Bank to Bank Transfer";
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
            // pnlSequence
            // 
            this.pnlSequence.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlSequence.Controls.Add(this.cmbOrderType);
            this.pnlSequence.Controls.Add(this.btnFindFileFormat);
            this.pnlSequence.Controls.Add(this.lblDate);
            this.pnlSequence.Controls.Add(this.btn);
            this.pnlSequence.Controls.Add(this.lblBankOrderDueDate);
            this.pnlSequence.Controls.Add(this.btnFindPaymentMode);
            this.pnlSequence.Controls.Add(this.txbFileFormat);
            this.pnlSequence.Controls.Add(this.txbPaymentMode);
            this.pnlSequence.Controls.Add(this.txbBankOrderDueDate);
            this.pnlSequence.Controls.Add(this.lblPaymentMode);
            this.pnlSequence.Controls.Add(this.lblFileFormat);
            this.pnlSequence.Controls.Add(this.lblOrderType);
            this.pnlSequence.Controls.Add(this.lblCode);
            this.pnlSequence.Controls.Add(this.separators1);
            this.pnlSequence.Location = new System.Drawing.Point(10, 191);
            this.pnlSequence.Name = "pnlSequence";
            this.pnlSequence.Size = new System.Drawing.Size(810, 210);
            this.pnlSequence.TabIndex = 20;
            // 
            // btnFindPaymentMode
            // 
            this.btnFindPaymentMode.BackColor = System.Drawing.Color.Transparent;
            this.btnFindPaymentMode.FlatAppearance.BorderSize = 0;
            this.btnFindPaymentMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPaymentMode.Image = ((System.Drawing.Image)(resources.GetObject("btnFindPaymentMode.Image")));
            this.btnFindPaymentMode.Location = new System.Drawing.Point(322, 153);
            this.btnFindPaymentMode.Name = "btnFindPaymentMode";
            this.btnFindPaymentMode.Size = new System.Drawing.Size(31, 26);
            this.btnFindPaymentMode.TabIndex = 92;
            this.btnFindPaymentMode.UseVisualStyleBackColor = false;
            // 
            // txbFileFormat
            // 
            this.txbFileFormat.BackColor = System.Drawing.SystemColors.Window;
            this.txbFileFormat.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbFileFormat.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbFileFormat.BorderRadius = 0;
            this.txbFileFormat.BorderSize = 1;
            this.txbFileFormat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbFileFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFileFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFileFormat.Location = new System.Drawing.Point(408, 150);
            this.txbFileFormat.Margin = new System.Windows.Forms.Padding(4);
            this.txbFileFormat.MaxLength = 250;
            this.txbFileFormat.Multiline = false;
            this.txbFileFormat.Name = "txbFileFormat";
            this.txbFileFormat.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbFileFormat.PasswordChar = false;
            this.txbFileFormat.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbFileFormat.PlaceholderText = "";
            this.txbFileFormat.ReadOnly = false;
            this.txbFileFormat.Size = new System.Drawing.Size(338, 29);
            this.txbFileFormat.TabIndex = 89;
            this.txbFileFormat.Texts = "";
            this.txbFileFormat.UnderlinedStyle = true;
            // 
            // txbPaymentMode
            // 
            this.txbPaymentMode.BackColor = System.Drawing.SystemColors.Window;
            this.txbPaymentMode.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbPaymentMode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPaymentMode.BorderRadius = 0;
            this.txbPaymentMode.BorderSize = 1;
            this.txbPaymentMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPaymentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPaymentMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPaymentMode.Location = new System.Drawing.Point(15, 151);
            this.txbPaymentMode.Margin = new System.Windows.Forms.Padding(4);
            this.txbPaymentMode.MaxLength = 250;
            this.txbPaymentMode.Multiline = false;
            this.txbPaymentMode.Name = "txbPaymentMode";
            this.txbPaymentMode.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbPaymentMode.PasswordChar = false;
            this.txbPaymentMode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPaymentMode.PlaceholderText = "";
            this.txbPaymentMode.ReadOnly = false;
            this.txbPaymentMode.Size = new System.Drawing.Size(338, 29);
            this.txbPaymentMode.TabIndex = 89;
            this.txbPaymentMode.Texts = "";
            this.txbPaymentMode.UnderlinedStyle = true;
            // 
            // txbBankOrderDueDate
            // 
            this.txbBankOrderDueDate.BackColor = System.Drawing.SystemColors.Window;
            this.txbBankOrderDueDate.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbBankOrderDueDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbBankOrderDueDate.BorderRadius = 0;
            this.txbBankOrderDueDate.BorderSize = 1;
            this.txbBankOrderDueDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbBankOrderDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBankOrderDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbBankOrderDueDate.Location = new System.Drawing.Point(15, 80);
            this.txbBankOrderDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.txbBankOrderDueDate.MaxLength = 250;
            this.txbBankOrderDueDate.Multiline = false;
            this.txbBankOrderDueDate.Name = "txbBankOrderDueDate";
            this.txbBankOrderDueDate.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbBankOrderDueDate.PasswordChar = false;
            this.txbBankOrderDueDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbBankOrderDueDate.PlaceholderText = "";
            this.txbBankOrderDueDate.ReadOnly = false;
            this.txbBankOrderDueDate.Size = new System.Drawing.Size(338, 29);
            this.txbBankOrderDueDate.TabIndex = 87;
            this.txbBankOrderDueDate.Texts = "";
            this.txbBankOrderDueDate.UnderlinedStyle = true;
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.BackColor = System.Drawing.Color.Transparent;
            this.btnNewRelease.FlatAppearance.BorderSize = 0;
            this.btnNewRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRelease.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRelease.ForeColor = System.Drawing.Color.Black;
            this.btnNewRelease.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRelease.Image")));
            this.btnNewRelease.Location = new System.Drawing.Point(12, 45);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Size = new System.Drawing.Size(105, 36);
            this.btnNewRelease.TabIndex = 20;
            this.btnNewRelease.Text = "New release";
            this.btnNewRelease.UseVisualStyleBackColor = false;
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMode.Location = new System.Drawing.Point(12, 121);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(101, 17);
            this.lblPaymentMode.TabIndex = 26;
            this.lblPaymentMode.Text = "Payment Mode";
            // 
            // lblFileFormat
            // 
            this.lblFileFormat.AutoSize = true;
            this.lblFileFormat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileFormat.Location = new System.Drawing.Point(405, 121);
            this.lblFileFormat.Name = "lblFileFormat";
            this.lblFileFormat.Size = new System.Drawing.Size(76, 17);
            this.lblFileFormat.TabIndex = 24;
            this.lblFileFormat.Text = "File Format";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(405, 59);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(74, 17);
            this.lblOrderType.TabIndex = 22;
            this.lblOrderType.Text = "Order type";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(11, 13);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(66, 17);
            this.lblCode.TabIndex = 21;
            this.lblCode.Text = "Sequence";
            this.lblCode.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // btnAwaitingSignature
            // 
            this.btnAwaitingSignature.BackColor = System.Drawing.Color.Transparent;
            this.btnAwaitingSignature.FlatAppearance.BorderSize = 0;
            this.btnAwaitingSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAwaitingSignature.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAwaitingSignature.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAwaitingSignature.Image = ((System.Drawing.Image)(resources.GetObject("btnAwaitingSignature.Image")));
            this.btnAwaitingSignature.Location = new System.Drawing.Point(113, 45);
            this.btnAwaitingSignature.Name = "btnAwaitingSignature";
            this.btnAwaitingSignature.Size = new System.Drawing.Size(162, 36);
            this.btnAwaitingSignature.TabIndex = 45;
            this.btnAwaitingSignature.Text = "Awaiting signature";
            this.btnAwaitingSignature.UseVisualStyleBackColor = false;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlStatus.Controls.Add(this.btnEntry);
            this.pnlStatus.Controls.Add(this.sptStatus);
            this.pnlStatus.Controls.Add(this.label13);
            this.pnlStatus.Controls.Add(this.btnNewRelease);
            this.pnlStatus.Controls.Add(this.btnAwaitingSignature);
            this.pnlStatus.Controls.Add(this.btnValidated);
            this.pnlStatus.Controls.Add(this.btnCarriedOut);
            this.pnlStatus.Controls.Add(this.btnRejected);
            this.pnlStatus.Controls.Add(this.btnCancelled);
            this.pnlStatus.Location = new System.Drawing.Point(10, 60);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(810, 115);
            this.pnlStatus.TabIndex = 25;
            // 
            // sptStatus
            // 
            this.sptStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.sptStatus.isVertical = false;
            this.sptStatus.Location = new System.Drawing.Point(0, 29);
            this.sptStatus.Name = "sptStatus";
            this.sptStatus.Size = new System.Drawing.Size(807, 10);
            this.sptStatus.TabIndex = 49;
            this.sptStatus.Text = "separators3";
            this.sptStatus.Thickness = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Status";
            // 
            // btnValidated
            // 
            this.btnValidated.BackColor = System.Drawing.Color.Transparent;
            this.btnValidated.FlatAppearance.BorderSize = 0;
            this.btnValidated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidated.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidated.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnValidated.Image = ((System.Drawing.Image)(resources.GetObject("btnValidated.Image")));
            this.btnValidated.Location = new System.Drawing.Point(272, 45);
            this.btnValidated.Name = "btnValidated";
            this.btnValidated.Size = new System.Drawing.Size(124, 36);
            this.btnValidated.TabIndex = 50;
            this.btnValidated.Text = "Validated";
            this.btnValidated.UseVisualStyleBackColor = false;
            // 
            // btnCarriedOut
            // 
            this.btnCarriedOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCarriedOut.FlatAppearance.BorderSize = 0;
            this.btnCarriedOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarriedOut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarriedOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCarriedOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCarriedOut.Image")));
            this.btnCarriedOut.Location = new System.Drawing.Point(392, 45);
            this.btnCarriedOut.Name = "btnCarriedOut";
            this.btnCarriedOut.Size = new System.Drawing.Size(125, 36);
            this.btnCarriedOut.TabIndex = 51;
            this.btnCarriedOut.Text = "Carried out";
            this.btnCarriedOut.UseVisualStyleBackColor = false;
            // 
            // btnRejected
            // 
            this.btnRejected.BackColor = System.Drawing.Color.Transparent;
            this.btnRejected.FlatAppearance.BorderSize = 0;
            this.btnRejected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejected.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRejected.Image = ((System.Drawing.Image)(resources.GetObject("btnRejected.Image")));
            this.btnRejected.Location = new System.Drawing.Point(511, 45);
            this.btnRejected.Name = "btnRejected";
            this.btnRejected.Size = new System.Drawing.Size(112, 36);
            this.btnRejected.TabIndex = 52;
            this.btnRejected.Text = "Rejected";
            this.btnRejected.UseVisualStyleBackColor = false;
            // 
            // btnCancelled
            // 
            this.btnCancelled.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelled.FlatAppearance.BorderSize = 0;
            this.btnCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelled.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelled.Image")));
            this.btnCancelled.Location = new System.Drawing.Point(618, 45);
            this.btnCancelled.Name = "btnCancelled";
            this.btnCancelled.Size = new System.Drawing.Size(112, 36);
            this.btnCancelled.TabIndex = 53;
            this.btnCancelled.Text = "Cancelled";
            this.btnCancelled.UseVisualStyleBackColor = false;
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.Transparent;
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnEntry.Image")));
            this.btnEntry.Location = new System.Drawing.Point(736, 45);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(67, 36);
            this.btnEntry.TabIndex = 54;
            this.btnEntry.Text = "Entry";
            this.btnEntry.UseVisualStyleBackColor = false;
            // 
            // lblBankOrderDueDate
            // 
            this.lblBankOrderDueDate.AutoSize = true;
            this.lblBankOrderDueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankOrderDueDate.Location = new System.Drawing.Point(12, 59);
            this.lblBankOrderDueDate.Name = "lblBankOrderDueDate";
            this.lblBankOrderDueDate.Size = new System.Drawing.Size(133, 17);
            this.lblBankOrderDueDate.TabIndex = 93;
            this.lblBankOrderDueDate.Text = "Bank order due date";
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btn.Location = new System.Drawing.Point(322, 80);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(31, 26);
            this.btn.TabIndex = 94;
            this.btn.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 17);
            this.lblDate.TabIndex = 95;
            this.lblDate.Text = "4/22/2023";
            // 
            // btnFindFileFormat
            // 
            this.btnFindFileFormat.BackColor = System.Drawing.Color.Transparent;
            this.btnFindFileFormat.FlatAppearance.BorderSize = 0;
            this.btnFindFileFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindFileFormat.Image = ((System.Drawing.Image)(resources.GetObject("btnFindFileFormat.Image")));
            this.btnFindFileFormat.Location = new System.Drawing.Point(715, 150);
            this.btnFindFileFormat.Name = "btnFindFileFormat";
            this.btnFindFileFormat.Size = new System.Drawing.Size(31, 26);
            this.btnFindFileFormat.TabIndex = 96;
            this.btnFindFileFormat.UseVisualStyleBackColor = false;
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrderType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrderType.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "THIRD PARTIES",
            "CONSOLIDATED PARTIES",
            "RELATED PARTIES"});
            this.cmbOrderType.Location = new System.Drawing.Point(408, 80);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(338, 21);
            this.cmbOrderType.TabIndex = 44;
            this.cmbOrderType.Text = "International Treasury Transfer";
            // 
            // separators1
            // 
            this.separators1.ForeColor = System.Drawing.Color.DarkGray;
            this.separators1.isVertical = false;
            this.separators1.Location = new System.Drawing.Point(408, 99);
            this.separators1.Name = "separators1";
            this.separators1.Size = new System.Drawing.Size(338, 10);
            this.separators1.TabIndex = 50;
            this.separators1.Text = "separators3";
            this.separators1.Thickness = 1;
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Controls.Add(this.btnConfirm);
            this.pnlAction.Controls.Add(this.sptAction);
            this.pnlAction.Controls.Add(this.lblAction);
            this.pnlAction.Location = new System.Drawing.Point(826, 60);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(360, 155);
            this.pnlAction.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(338, 36);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(11, 47);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(338, 36);
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
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
            // frmNationalBankToBankTransferCREATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlSequence);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNationalBankToBankTransferCREATE";
            this.Text = "frmNationalBankToBankTransferCREATE";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSequence.ResumeLayout(false);
            this.pnlSequence.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlSequence;
        private System.Windows.Forms.Button btnFindPaymentMode;
        private Contoller.RJTextBox txbFileFormat;
        private Contoller.RJTextBox txbPaymentMode;
        private Contoller.RJTextBox txbBankOrderDueDate;
        private System.Windows.Forms.Button btnNewRelease;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.Label lblFileFormat;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnAwaitingSignature;
        private System.Windows.Forms.Panel pnlStatus;
        private Contoller.Separators sptStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRejected;
        private System.Windows.Forms.Button btnValidated;
        private System.Windows.Forms.Button btnCarriedOut;
        private System.Windows.Forms.Button btnCancelled;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblBankOrderDueDate;
        private System.Windows.Forms.Button btnFindFileFormat;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private Contoller.Separators separators1;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private Contoller.Separators sptAction;
        private System.Windows.Forms.Label lblAction;
    }
}