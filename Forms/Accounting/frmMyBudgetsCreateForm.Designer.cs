namespace REMAS.Forms.Accounting
{
    partial class frmMyBudgetsCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyBudgetsCreateForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnDraft = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnValidated = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txbCode = new REMAS.Contoller.RJTextBox();
            this.txbName = new REMAS.Contoller.RJTextBox();
            this.txbCompany = new REMAS.Contoller.RJTextBox();
            this.txbFrom = new REMAS.Contoller.RJTextBox();
            this.txbTo = new REMAS.Contoller.RJTextBox();
            this.btnFindCompany = new System.Windows.Forms.Button();
            this.btnCalendarFrom = new System.Windows.Forms.Button();
            this.btnCalendarTo = new System.Windows.Forms.Button();
            this.pnlValidate = new System.Windows.Forms.Panel();
            this.btnValidate = new System.Windows.Forms.Button();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.sptPeriod = new REMAS.Contoller.Separators();
            this.lblExpectedAmount = new System.Windows.Forms.Label();
            this.lblExpectedAmountNumber = new System.Windows.Forms.Label();
            this.lblCommittedAmount = new System.Windows.Forms.Label();
            this.lblCommittedAmountNumber = new System.Windows.Forms.Label();
            this.lblRealizedAmount = new System.Windows.Forms.Label();
            this.lblRealizedAmountNumber = new System.Windows.Forms.Label();
            this.pnlPeriodsGenerations = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.sptPeriodsGenerations = new REMAS.Contoller.Separators();
            this.lblPeriodsDuration = new System.Windows.Forms.Label();
            this.lblAmountForEach = new System.Windows.Forms.Label();
            this.txbPeriodsDuration = new REMAS.Contoller.RJTextBox();
            this.txbAmountForEach = new REMAS.Contoller.RJTextBox();
            this.nudAmountForEach = new System.Windows.Forms.NumericUpDown();
            this.btnGeneratePeriods = new System.Windows.Forms.Button();
            this.pnlBudgetLines = new System.Windows.Forms.Panel();
            this.separators2 = new REMAS.Contoller.Separators();
            this.lblBudgetLines = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblNew = new System.Windows.Forms.Label();
            this.btnPeriodsGenerationsUp = new System.Windows.Forms.Button();
            this.pnlFollowUp = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.separators3 = new REMAS.Contoller.Separators();
            this.btnFollowUp = new System.Windows.Forms.Button();
            this.lblPersonInCharge = new System.Windows.Forms.Label();
            this.txbPersonInCharge = new REMAS.Contoller.RJTextBox();
            this.btnPersonInChargeFind = new System.Windows.Forms.Button();
            this.pnlConfiguration = new System.Windows.Forms.Panel();
            this.lblCheckAvailable = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.sptConfiguration = new REMAS.Contoller.Separators();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCheckAvailable = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlValidate.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.pnlPeriodsGenerations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountForEach)).BeginInit();
            this.pnlBudgetLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlFollowUp.SuspendLayout();
            this.pnlConfiguration.SuspendLayout();
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
            this.pnlHeader.TabIndex = 5;
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
            this.lbHeader.Size = new System.Drawing.Size(124, 17);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Create My Budgets";
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
            this.pnlBody.Controls.Add(this.btnCalendarTo);
            this.pnlBody.Controls.Add(this.btnCalendarFrom);
            this.pnlBody.Controls.Add(this.btnFindCompany);
            this.pnlBody.Controls.Add(this.txbTo);
            this.pnlBody.Controls.Add(this.txbFrom);
            this.pnlBody.Controls.Add(this.txbCompany);
            this.pnlBody.Controls.Add(this.txbName);
            this.pnlBody.Controls.Add(this.txbCode);
            this.pnlBody.Controls.Add(this.lblTo);
            this.pnlBody.Controls.Add(this.lblFrom);
            this.pnlBody.Controls.Add(this.btnDraft);
            this.pnlBody.Controls.Add(this.lblCompany);
            this.pnlBody.Controls.Add(this.lblCurrency);
            this.pnlBody.Controls.Add(this.lblName);
            this.pnlBody.Controls.Add(this.lblCode);
            this.pnlBody.Controls.Add(this.btnValidated);
            this.pnlBody.Location = new System.Drawing.Point(12, 55);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(782, 283);
            this.pnlBody.TabIndex = 19;
            // 
            // btnDraft
            // 
            this.btnDraft.BackColor = System.Drawing.Color.Transparent;
            this.btnDraft.FlatAppearance.BorderSize = 0;
            this.btnDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraft.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraft.ForeColor = System.Drawing.Color.White;
            this.btnDraft.Image = ((System.Drawing.Image)(resources.GetObject("btnDraft.Image")));
            this.btnDraft.Location = new System.Drawing.Point(12, 10);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(74, 36);
            this.btnDraft.TabIndex = 20;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(12, 121);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(66, 17);
            this.lblCompany.TabIndex = 26;
            this.lblCompany.Text = "Company";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(405, 121);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(62, 17);
            this.lblCurrency.TabIndex = 24;
            this.lblCurrency.Text = "Currency";
            this.lblCurrency.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(405, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 17);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(12, 59);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(39, 17);
            this.lblCode.TabIndex = 21;
            this.lblCode.Text = "Code";
            // 
            // btnValidated
            // 
            this.btnValidated.BackColor = System.Drawing.Color.Transparent;
            this.btnValidated.FlatAppearance.BorderSize = 0;
            this.btnValidated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidated.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidated.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnValidated.Image = ((System.Drawing.Image)(resources.GetObject("btnValidated.Image")));
            this.btnValidated.Location = new System.Drawing.Point(82, 10);
            this.btnValidated.Name = "btnValidated";
            this.btnValidated.Size = new System.Drawing.Size(97, 36);
            this.btnValidated.TabIndex = 45;
            this.btnValidated.Text = "Validated";
            this.btnValidated.UseVisualStyleBackColor = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(12, 195);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 46;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(405, 195);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 17);
            this.lblTo.TabIndex = 47;
            this.lblTo.Text = "To";
            // 
            // txbCode
            // 
            this.txbCode.BackColor = System.Drawing.SystemColors.Window;
            this.txbCode.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbCode.BorderRadius = 0;
            this.txbCode.BorderSize = 1;
            this.txbCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCode.Location = new System.Drawing.Point(15, 80);
            this.txbCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbCode.MaxLength = 250;
            this.txbCode.Multiline = false;
            this.txbCode.Name = "txbCode";
            this.txbCode.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbCode.PasswordChar = false;
            this.txbCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCode.PlaceholderText = "";
            this.txbCode.ReadOnly = false;
            this.txbCode.Size = new System.Drawing.Size(338, 29);
            this.txbCode.TabIndex = 87;
            this.txbCode.Texts = "";
            this.txbCode.UnderlinedStyle = true;
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.Window;
            this.txbName.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbName.BorderRadius = 0;
            this.txbName.BorderSize = 1;
            this.txbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbName.Location = new System.Drawing.Point(408, 80);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.MaxLength = 250;
            this.txbName.Multiline = false;
            this.txbName.Name = "txbName";
            this.txbName.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbName.PasswordChar = false;
            this.txbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbName.PlaceholderText = "";
            this.txbName.ReadOnly = false;
            this.txbName.Size = new System.Drawing.Size(338, 29);
            this.txbName.TabIndex = 88;
            this.txbName.Texts = "";
            this.txbName.UnderlinedStyle = true;
            // 
            // txbCompany
            // 
            this.txbCompany.BackColor = System.Drawing.SystemColors.Window;
            this.txbCompany.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbCompany.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbCompany.BorderRadius = 0;
            this.txbCompany.BorderSize = 1;
            this.txbCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCompany.Location = new System.Drawing.Point(15, 151);
            this.txbCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txbCompany.MaxLength = 250;
            this.txbCompany.Multiline = false;
            this.txbCompany.Name = "txbCompany";
            this.txbCompany.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbCompany.PasswordChar = false;
            this.txbCompany.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCompany.PlaceholderText = "";
            this.txbCompany.ReadOnly = false;
            this.txbCompany.Size = new System.Drawing.Size(338, 29);
            this.txbCompany.TabIndex = 89;
            this.txbCompany.Texts = "";
            this.txbCompany.UnderlinedStyle = true;
            // 
            // txbFrom
            // 
            this.txbFrom.BackColor = System.Drawing.SystemColors.Window;
            this.txbFrom.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbFrom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbFrom.BorderRadius = 0;
            this.txbFrom.BorderSize = 1;
            this.txbFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFrom.Location = new System.Drawing.Point(15, 220);
            this.txbFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txbFrom.MaxLength = 250;
            this.txbFrom.Multiline = false;
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbFrom.PasswordChar = false;
            this.txbFrom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbFrom.PlaceholderText = "";
            this.txbFrom.ReadOnly = false;
            this.txbFrom.Size = new System.Drawing.Size(338, 29);
            this.txbFrom.TabIndex = 89;
            this.txbFrom.Texts = "";
            this.txbFrom.UnderlinedStyle = true;
            // 
            // txbTo
            // 
            this.txbTo.BackColor = System.Drawing.SystemColors.Window;
            this.txbTo.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbTo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbTo.BorderRadius = 0;
            this.txbTo.BorderSize = 1;
            this.txbTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTo.Location = new System.Drawing.Point(408, 220);
            this.txbTo.Margin = new System.Windows.Forms.Padding(4);
            this.txbTo.MaxLength = 250;
            this.txbTo.Multiline = false;
            this.txbTo.Name = "txbTo";
            this.txbTo.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbTo.PasswordChar = false;
            this.txbTo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbTo.PlaceholderText = "";
            this.txbTo.ReadOnly = false;
            this.txbTo.Size = new System.Drawing.Size(338, 29);
            this.txbTo.TabIndex = 89;
            this.txbTo.Texts = "";
            this.txbTo.UnderlinedStyle = true;
            // 
            // btnFindCompany
            // 
            this.btnFindCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnFindCompany.FlatAppearance.BorderSize = 0;
            this.btnFindCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCompany.Image")));
            this.btnFindCompany.Location = new System.Drawing.Point(322, 153);
            this.btnFindCompany.Name = "btnFindCompany";
            this.btnFindCompany.Size = new System.Drawing.Size(31, 26);
            this.btnFindCompany.TabIndex = 92;
            this.btnFindCompany.UseVisualStyleBackColor = false;
            // 
            // btnCalendarFrom
            // 
            this.btnCalendarFrom.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendarFrom.FlatAppearance.BorderSize = 0;
            this.btnCalendarFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarFrom.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarFrom.Location = new System.Drawing.Point(322, 220);
            this.btnCalendarFrom.Name = "btnCalendarFrom";
            this.btnCalendarFrom.Size = new System.Drawing.Size(31, 26);
            this.btnCalendarFrom.TabIndex = 87;
            this.btnCalendarFrom.UseVisualStyleBackColor = false;
            // 
            // btnCalendarTo
            // 
            this.btnCalendarTo.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendarTo.FlatAppearance.BorderSize = 0;
            this.btnCalendarTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarTo.Image = global::REMAS.Properties.Resources.icons8_calendar_20__1_;
            this.btnCalendarTo.Location = new System.Drawing.Point(715, 220);
            this.btnCalendarTo.Name = "btnCalendarTo";
            this.btnCalendarTo.Size = new System.Drawing.Size(31, 26);
            this.btnCalendarTo.TabIndex = 87;
            this.btnCalendarTo.UseVisualStyleBackColor = false;
            // 
            // pnlValidate
            // 
            this.pnlValidate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlValidate.Controls.Add(this.btnValidate);
            this.pnlValidate.Location = new System.Drawing.Point(806, 55);
            this.pnlValidate.Name = "pnlValidate";
            this.pnlValidate.Size = new System.Drawing.Size(379, 63);
            this.pnlValidate.TabIndex = 20;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(12, 10);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(355, 36);
            this.btnValidate.TabIndex = 22;
            this.btnValidate.Text = "Validate\r\n";
            this.btnValidate.UseVisualStyleBackColor = false;
            // 
            // pnlBalance
            // 
            this.pnlBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBalance.Controls.Add(this.lblRealizedAmountNumber);
            this.pnlBalance.Controls.Add(this.lblRealizedAmount);
            this.pnlBalance.Controls.Add(this.lblCommittedAmountNumber);
            this.pnlBalance.Controls.Add(this.lblCommittedAmount);
            this.pnlBalance.Controls.Add(this.lblExpectedAmountNumber);
            this.pnlBalance.Controls.Add(this.lblExpectedAmount);
            this.pnlBalance.Controls.Add(this.sptPeriod);
            this.pnlBalance.Controls.Add(this.lblBalance);
            this.pnlBalance.Location = new System.Drawing.Point(806, 124);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(379, 214);
            this.pnlBalance.TabIndex = 23;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(9, 11);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(54, 17);
            this.lblBalance.TabIndex = 24;
            this.lblBalance.Text = "Balance";
            // 
            // sptPeriod
            // 
            this.sptPeriod.ForeColor = System.Drawing.Color.DarkGray;
            this.sptPeriod.isVertical = false;
            this.sptPeriod.Location = new System.Drawing.Point(0, 31);
            this.sptPeriod.Name = "sptPeriod";
            this.sptPeriod.Size = new System.Drawing.Size(376, 10);
            this.sptPeriod.TabIndex = 48;
            this.sptPeriod.Text = "separators3";
            this.sptPeriod.Thickness = 1;
            // 
            // lblExpectedAmount
            // 
            this.lblExpectedAmount.AutoSize = true;
            this.lblExpectedAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedAmount.Location = new System.Drawing.Point(9, 44);
            this.lblExpectedAmount.Name = "lblExpectedAmount";
            this.lblExpectedAmount.Size = new System.Drawing.Size(147, 17);
            this.lblExpectedAmount.TabIndex = 49;
            this.lblExpectedAmount.Text = "Expected total amount";
            // 
            // lblExpectedAmountNumber
            // 
            this.lblExpectedAmountNumber.AutoSize = true;
            this.lblExpectedAmountNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedAmountNumber.Location = new System.Drawing.Point(9, 65);
            this.lblExpectedAmountNumber.Name = "lblExpectedAmountNumber";
            this.lblExpectedAmountNumber.Size = new System.Drawing.Size(25, 17);
            this.lblExpectedAmountNumber.TabIndex = 50;
            this.lblExpectedAmountNumber.Text = "0.0";
            // 
            // lblCommittedAmount
            // 
            this.lblCommittedAmount.AutoSize = true;
            this.lblCommittedAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommittedAmount.Location = new System.Drawing.Point(9, 94);
            this.lblCommittedAmount.Name = "lblCommittedAmount";
            this.lblCommittedAmount.Size = new System.Drawing.Size(160, 17);
            this.lblCommittedAmount.TabIndex = 51;
            this.lblCommittedAmount.Text = "Committed total amount";
            // 
            // lblCommittedAmountNumber
            // 
            this.lblCommittedAmountNumber.AutoSize = true;
            this.lblCommittedAmountNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommittedAmountNumber.Location = new System.Drawing.Point(9, 114);
            this.lblCommittedAmountNumber.Name = "lblCommittedAmountNumber";
            this.lblCommittedAmountNumber.Size = new System.Drawing.Size(25, 17);
            this.lblCommittedAmountNumber.TabIndex = 52;
            this.lblCommittedAmountNumber.Text = "0.0";
            // 
            // lblRealizedAmount
            // 
            this.lblRealizedAmount.AutoSize = true;
            this.lblRealizedAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizedAmount.Location = new System.Drawing.Point(9, 140);
            this.lblRealizedAmount.Name = "lblRealizedAmount";
            this.lblRealizedAmount.Size = new System.Drawing.Size(141, 17);
            this.lblRealizedAmount.TabIndex = 53;
            this.lblRealizedAmount.Text = "Realized total amount";
            // 
            // lblRealizedAmountNumber
            // 
            this.lblRealizedAmountNumber.AutoSize = true;
            this.lblRealizedAmountNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizedAmountNumber.Location = new System.Drawing.Point(9, 163);
            this.lblRealizedAmountNumber.Name = "lblRealizedAmountNumber";
            this.lblRealizedAmountNumber.Size = new System.Drawing.Size(25, 17);
            this.lblRealizedAmountNumber.TabIndex = 54;
            this.lblRealizedAmountNumber.Text = "0.0";
            // 
            // pnlPeriodsGenerations
            // 
            this.pnlPeriodsGenerations.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPeriodsGenerations.Controls.Add(this.btnPeriodsGenerationsUp);
            this.pnlPeriodsGenerations.Controls.Add(this.btnGeneratePeriods);
            this.pnlPeriodsGenerations.Controls.Add(this.nudAmountForEach);
            this.pnlPeriodsGenerations.Controls.Add(this.txbAmountForEach);
            this.pnlPeriodsGenerations.Controls.Add(this.txbPeriodsDuration);
            this.pnlPeriodsGenerations.Controls.Add(this.lblAmountForEach);
            this.pnlPeriodsGenerations.Controls.Add(this.lblPeriodsDuration);
            this.pnlPeriodsGenerations.Controls.Add(this.sptPeriodsGenerations);
            this.pnlPeriodsGenerations.Controls.Add(this.label13);
            this.pnlPeriodsGenerations.Location = new System.Drawing.Point(12, 354);
            this.pnlPeriodsGenerations.Name = "pnlPeriodsGenerations";
            this.pnlPeriodsGenerations.Size = new System.Drawing.Size(782, 115);
            this.pnlPeriodsGenerations.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Periods generations assistans";
            // 
            // sptPeriodsGenerations
            // 
            this.sptPeriodsGenerations.ForeColor = System.Drawing.Color.DarkGray;
            this.sptPeriodsGenerations.isVertical = false;
            this.sptPeriodsGenerations.Location = new System.Drawing.Point(0, 29);
            this.sptPeriodsGenerations.Name = "sptPeriodsGenerations";
            this.sptPeriodsGenerations.Size = new System.Drawing.Size(782, 10);
            this.sptPeriodsGenerations.TabIndex = 49;
            this.sptPeriodsGenerations.Text = "separators3";
            this.sptPeriodsGenerations.Thickness = 1;
            // 
            // lblPeriodsDuration
            // 
            this.lblPeriodsDuration.AutoSize = true;
            this.lblPeriodsDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodsDuration.Location = new System.Drawing.Point(9, 42);
            this.lblPeriodsDuration.Name = "lblPeriodsDuration";
            this.lblPeriodsDuration.Size = new System.Drawing.Size(109, 17);
            this.lblPeriodsDuration.TabIndex = 50;
            this.lblPeriodsDuration.Text = "Periods duration";
            // 
            // lblAmountForEach
            // 
            this.lblAmountForEach.AutoSize = true;
            this.lblAmountForEach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountForEach.Location = new System.Drawing.Point(253, 42);
            this.lblAmountForEach.Name = "lblAmountForEach";
            this.lblAmountForEach.Size = new System.Drawing.Size(136, 17);
            this.lblAmountForEach.TabIndex = 51;
            this.lblAmountForEach.Text = "Amount for each line";
            // 
            // txbPeriodsDuration
            // 
            this.txbPeriodsDuration.BackColor = System.Drawing.SystemColors.Window;
            this.txbPeriodsDuration.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbPeriodsDuration.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPeriodsDuration.BorderRadius = 0;
            this.txbPeriodsDuration.BorderSize = 1;
            this.txbPeriodsDuration.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPeriodsDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPeriodsDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPeriodsDuration.Location = new System.Drawing.Point(12, 63);
            this.txbPeriodsDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txbPeriodsDuration.MaxLength = 250;
            this.txbPeriodsDuration.Multiline = false;
            this.txbPeriodsDuration.Name = "txbPeriodsDuration";
            this.txbPeriodsDuration.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbPeriodsDuration.PasswordChar = false;
            this.txbPeriodsDuration.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPeriodsDuration.PlaceholderText = "";
            this.txbPeriodsDuration.ReadOnly = false;
            this.txbPeriodsDuration.Size = new System.Drawing.Size(234, 29);
            this.txbPeriodsDuration.TabIndex = 93;
            this.txbPeriodsDuration.Texts = "";
            this.txbPeriodsDuration.UnderlinedStyle = true;
            // 
            // txbAmountForEach
            // 
            this.txbAmountForEach.BackColor = System.Drawing.SystemColors.Window;
            this.txbAmountForEach.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbAmountForEach.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbAmountForEach.BorderRadius = 0;
            this.txbAmountForEach.BorderSize = 1;
            this.txbAmountForEach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbAmountForEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAmountForEach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbAmountForEach.Location = new System.Drawing.Point(254, 63);
            this.txbAmountForEach.Margin = new System.Windows.Forms.Padding(4);
            this.txbAmountForEach.MaxLength = 250;
            this.txbAmountForEach.Multiline = false;
            this.txbAmountForEach.Name = "txbAmountForEach";
            this.txbAmountForEach.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbAmountForEach.PasswordChar = false;
            this.txbAmountForEach.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbAmountForEach.PlaceholderText = "";
            this.txbAmountForEach.ReadOnly = false;
            this.txbAmountForEach.Size = new System.Drawing.Size(234, 29);
            this.txbAmountForEach.TabIndex = 94;
            this.txbAmountForEach.Texts = "";
            this.txbAmountForEach.UnderlinedStyle = true;
            // 
            // nudAmountForEach
            // 
            this.nudAmountForEach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudAmountForEach.Location = new System.Drawing.Point(458, 75);
            this.nudAmountForEach.Name = "nudAmountForEach";
            this.nudAmountForEach.Size = new System.Drawing.Size(30, 16);
            this.nudAmountForEach.TabIndex = 95;
            // 
            // btnGeneratePeriods
            // 
            this.btnGeneratePeriods.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGeneratePeriods.FlatAppearance.BorderSize = 0;
            this.btnGeneratePeriods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePeriods.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePeriods.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePeriods.Location = new System.Drawing.Point(507, 63);
            this.btnGeneratePeriods.Name = "btnGeneratePeriods";
            this.btnGeneratePeriods.Size = new System.Drawing.Size(258, 28);
            this.btnGeneratePeriods.TabIndex = 23;
            this.btnGeneratePeriods.Text = "Generate periods";
            this.btnGeneratePeriods.UseVisualStyleBackColor = false;
            // 
            // pnlBudgetLines
            // 
            this.pnlBudgetLines.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBudgetLines.Controls.Add(this.lblNew);
            this.pnlBudgetLines.Controls.Add(this.btnPlus);
            this.pnlBudgetLines.Controls.Add(this.dgvList);
            this.pnlBudgetLines.Controls.Add(this.separators2);
            this.pnlBudgetLines.Controls.Add(this.lblBudgetLines);
            this.pnlBudgetLines.Location = new System.Drawing.Point(12, 485);
            this.pnlBudgetLines.Name = "pnlBudgetLines";
            this.pnlBudgetLines.Size = new System.Drawing.Size(782, 115);
            this.pnlBudgetLines.TabIndex = 96;
            // 
            // separators2
            // 
            this.separators2.ForeColor = System.Drawing.Color.DarkGray;
            this.separators2.isVertical = false;
            this.separators2.Location = new System.Drawing.Point(0, 29);
            this.separators2.Name = "separators2";
            this.separators2.Size = new System.Drawing.Size(782, 10);
            this.separators2.TabIndex = 49;
            this.separators2.Text = "separators3";
            this.separators2.Thickness = 1;
            // 
            // lblBudgetLines
            // 
            this.lblBudgetLines.AutoSize = true;
            this.lblBudgetLines.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetLines.Location = new System.Drawing.Point(9, 9);
            this.lblBudgetLines.Name = "lblBudgetLines";
            this.lblBudgetLines.Size = new System.Drawing.Size(86, 17);
            this.lblBudgetLines.TabIndex = 25;
            this.lblBudgetLines.Text = "Budget Lines";
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
            this.Column4});
            this.dgvList.Location = new System.Drawing.Point(8, 45);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(757, 67);
            this.dgvList.TabIndex = 97;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // MenuName
            // 
            this.MenuName.FillWeight = 150F;
            this.MenuName.HeaderText = "From";
            this.MenuName.Name = "MenuName";
            this.MenuName.Width = 125;
            // 
            // MainRoot
            // 
            this.MainRoot.HeaderText = "To";
            this.MainRoot.Name = "MainRoot";
            this.MainRoot.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Expected amount";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Committed amount";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Realized amount";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.Location = new System.Drawing.Point(705, 7);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 23);
            this.btnPlus.TabIndex = 97;
            this.btnPlus.UseVisualStyleBackColor = false;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(728, 10);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(35, 17);
            this.lblNew.TabIndex = 97;
            this.lblNew.Text = "New";
            // 
            // btnPeriodsGenerationsUp
            // 
            this.btnPeriodsGenerationsUp.BackColor = System.Drawing.Color.White;
            this.btnPeriodsGenerationsUp.FlatAppearance.BorderSize = 0;
            this.btnPeriodsGenerationsUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodsGenerationsUp.Image = ((System.Drawing.Image)(resources.GetObject("btnPeriodsGenerationsUp.Image")));
            this.btnPeriodsGenerationsUp.Location = new System.Drawing.Point(753, 6);
            this.btnPeriodsGenerationsUp.Name = "btnPeriodsGenerationsUp";
            this.btnPeriodsGenerationsUp.Size = new System.Drawing.Size(25, 23);
            this.btnPeriodsGenerationsUp.TabIndex = 98;
            this.btnPeriodsGenerationsUp.UseVisualStyleBackColor = false;
            // 
            // pnlFollowUp
            // 
            this.pnlFollowUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFollowUp.Controls.Add(this.btnPersonInChargeFind);
            this.pnlFollowUp.Controls.Add(this.txbPersonInCharge);
            this.pnlFollowUp.Controls.Add(this.lblPersonInCharge);
            this.pnlFollowUp.Controls.Add(this.btnFollowUp);
            this.pnlFollowUp.Controls.Add(this.separators3);
            this.pnlFollowUp.Controls.Add(this.label17);
            this.pnlFollowUp.Location = new System.Drawing.Point(806, 354);
            this.pnlFollowUp.Name = "pnlFollowUp";
            this.pnlFollowUp.Size = new System.Drawing.Size(379, 115);
            this.pnlFollowUp.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 55;
            this.label17.Text = "Follow-up";
            // 
            // separators3
            // 
            this.separators3.ForeColor = System.Drawing.Color.DarkGray;
            this.separators3.isVertical = false;
            this.separators3.Location = new System.Drawing.Point(2, 29);
            this.separators3.Name = "separators3";
            this.separators3.Size = new System.Drawing.Size(376, 10);
            this.separators3.TabIndex = 55;
            this.separators3.Text = "separators3";
            this.separators3.Thickness = 1;
            // 
            // btnFollowUp
            // 
            this.btnFollowUp.BackColor = System.Drawing.Color.White;
            this.btnFollowUp.FlatAppearance.BorderSize = 0;
            this.btnFollowUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFollowUp.Image = ((System.Drawing.Image)(resources.GetObject("btnFollowUp.Image")));
            this.btnFollowUp.Location = new System.Drawing.Point(353, 7);
            this.btnFollowUp.Name = "btnFollowUp";
            this.btnFollowUp.Size = new System.Drawing.Size(25, 23);
            this.btnFollowUp.TabIndex = 99;
            this.btnFollowUp.UseVisualStyleBackColor = false;
            // 
            // lblPersonInCharge
            // 
            this.lblPersonInCharge.AutoSize = true;
            this.lblPersonInCharge.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonInCharge.Location = new System.Drawing.Point(9, 42);
            this.lblPersonInCharge.Name = "lblPersonInCharge";
            this.lblPersonInCharge.Size = new System.Drawing.Size(110, 17);
            this.lblPersonInCharge.TabIndex = 100;
            this.lblPersonInCharge.Text = "Person in charge";
            // 
            // txbPersonInCharge
            // 
            this.txbPersonInCharge.BackColor = System.Drawing.SystemColors.Window;
            this.txbPersonInCharge.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbPersonInCharge.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPersonInCharge.BorderRadius = 0;
            this.txbPersonInCharge.BorderSize = 1;
            this.txbPersonInCharge.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPersonInCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPersonInCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPersonInCharge.Location = new System.Drawing.Point(12, 63);
            this.txbPersonInCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txbPersonInCharge.MaxLength = 250;
            this.txbPersonInCharge.Multiline = false;
            this.txbPersonInCharge.Name = "txbPersonInCharge";
            this.txbPersonInCharge.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txbPersonInCharge.PasswordChar = false;
            this.txbPersonInCharge.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPersonInCharge.PlaceholderText = "";
            this.txbPersonInCharge.ReadOnly = false;
            this.txbPersonInCharge.Size = new System.Drawing.Size(355, 29);
            this.txbPersonInCharge.TabIndex = 93;
            this.txbPersonInCharge.Texts = "";
            this.txbPersonInCharge.UnderlinedStyle = true;
            // 
            // btnPersonInChargeFind
            // 
            this.btnPersonInChargeFind.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonInChargeFind.FlatAppearance.BorderSize = 0;
            this.btnPersonInChargeFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonInChargeFind.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonInChargeFind.Image")));
            this.btnPersonInChargeFind.Location = new System.Drawing.Point(336, 65);
            this.btnPersonInChargeFind.Name = "btnPersonInChargeFind";
            this.btnPersonInChargeFind.Size = new System.Drawing.Size(31, 26);
            this.btnPersonInChargeFind.TabIndex = 93;
            this.btnPersonInChargeFind.UseVisualStyleBackColor = false;
            // 
            // pnlConfiguration
            // 
            this.pnlConfiguration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlConfiguration.Controls.Add(this.btnCheckAvailable);
            this.pnlConfiguration.Controls.Add(this.lblCheckAvailable);
            this.pnlConfiguration.Controls.Add(this.button10);
            this.pnlConfiguration.Controls.Add(this.sptConfiguration);
            this.pnlConfiguration.Controls.Add(this.label21);
            this.pnlConfiguration.Location = new System.Drawing.Point(806, 485);
            this.pnlConfiguration.Name = "pnlConfiguration";
            this.pnlConfiguration.Size = new System.Drawing.Size(379, 115);
            this.pnlConfiguration.TabIndex = 101;
            // 
            // lblCheckAvailable
            // 
            this.lblCheckAvailable.AutoSize = true;
            this.lblCheckAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckAvailable.Location = new System.Drawing.Point(9, 42);
            this.lblCheckAvailable.Name = "lblCheckAvailable";
            this.lblCheckAvailable.Size = new System.Drawing.Size(148, 17);
            this.lblCheckAvailable.TabIndex = 100;
            this.lblCheckAvailable.Text = "Check available budget";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(353, 7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(25, 23);
            this.button10.TabIndex = 99;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // sptConfiguration
            // 
            this.sptConfiguration.ForeColor = System.Drawing.Color.DarkGray;
            this.sptConfiguration.isVertical = false;
            this.sptConfiguration.Location = new System.Drawing.Point(2, 29);
            this.sptConfiguration.Name = "sptConfiguration";
            this.sptConfiguration.Size = new System.Drawing.Size(376, 10);
            this.sptConfiguration.TabIndex = 55;
            this.sptConfiguration.Text = "separators4";
            this.sptConfiguration.Thickness = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 17);
            this.label21.TabIndex = 55;
            this.label21.Text = "Configuration";
            // 
            // btnCheckAvailable
            // 
            this.btnCheckAvailable.BackColor = System.Drawing.Color.White;
            this.btnCheckAvailable.FlatAppearance.BorderSize = 0;
            this.btnCheckAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAvailable.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAvailable.Image")));
            this.btnCheckAvailable.Location = new System.Drawing.Point(12, 71);
            this.btnCheckAvailable.Name = "btnCheckAvailable";
            this.btnCheckAvailable.Size = new System.Drawing.Size(40, 23);
            this.btnCheckAvailable.TabIndex = 98;
            this.btnCheckAvailable.UseVisualStyleBackColor = false;
            // 
            // frmMyBudgetsCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlConfiguration);
            this.Controls.Add(this.pnlFollowUp);
            this.Controls.Add(this.pnlBudgetLines);
            this.Controls.Add(this.pnlPeriodsGenerations);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlValidate);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMyBudgetsCreateForm";
            this.Text = "frmMyBudgetsCreateForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlValidate.ResumeLayout(false);
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlPeriodsGenerations.ResumeLayout(false);
            this.pnlPeriodsGenerations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountForEach)).EndInit();
            this.pnlBudgetLines.ResumeLayout(false);
            this.pnlBudgetLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlFollowUp.ResumeLayout(false);
            this.pnlFollowUp.PerformLayout();
            this.pnlConfiguration.ResumeLayout(false);
            this.pnlConfiguration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnValidated;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Contoller.RJTextBox txbTo;
        private Contoller.RJTextBox txbFrom;
        private Contoller.RJTextBox txbCompany;
        private Contoller.RJTextBox txbName;
        private Contoller.RJTextBox txbCode;
        private System.Windows.Forms.Button btnFindCompany;
        private System.Windows.Forms.Button btnCalendarTo;
        private System.Windows.Forms.Button btnCalendarFrom;
        private System.Windows.Forms.Panel pnlValidate;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblRealizedAmountNumber;
        private System.Windows.Forms.Label lblRealizedAmount;
        private System.Windows.Forms.Label lblCommittedAmountNumber;
        private System.Windows.Forms.Label lblCommittedAmount;
        private System.Windows.Forms.Label lblExpectedAmountNumber;
        private System.Windows.Forms.Label lblExpectedAmount;
        private Contoller.Separators sptPeriod;
        private System.Windows.Forms.Panel pnlPeriodsGenerations;
        private Contoller.RJTextBox txbAmountForEach;
        private Contoller.RJTextBox txbPeriodsDuration;
        private System.Windows.Forms.Label lblAmountForEach;
        private System.Windows.Forms.Label lblPeriodsDuration;
        private Contoller.Separators sptPeriodsGenerations;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGeneratePeriods;
        private System.Windows.Forms.NumericUpDown nudAmountForEach;
        private System.Windows.Forms.Panel pnlBudgetLines;
        private Contoller.Separators separators2;
        private System.Windows.Forms.Label lblBudgetLines;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPeriodsGenerationsUp;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Panel pnlFollowUp;
        private System.Windows.Forms.Button btnPersonInChargeFind;
        private Contoller.RJTextBox txbPersonInCharge;
        private System.Windows.Forms.Label lblPersonInCharge;
        private System.Windows.Forms.Button btnFollowUp;
        private Contoller.Separators separators3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlConfiguration;
        private System.Windows.Forms.Button btnCheckAvailable;
        private System.Windows.Forms.Label lblCheckAvailable;
        private System.Windows.Forms.Button button10;
        private Contoller.Separators sptConfiguration;
        private System.Windows.Forms.Label label21;
    }
}