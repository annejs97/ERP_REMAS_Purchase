namespace REMAS.Forms.Accounting
{
    partial class frmDebtRecoveryFactoringNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebtRecoveryFactoringNotifications));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblFactor = new System.Windows.Forms.Label();
            this.lblPaymentdate = new System.Windows.Forms.Label();
            this.lblPayamentDate = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.btnSearchPaymentDate = new System.Windows.Forms.Button();
            this.txbPaymentDateSearch = new REMAS.Contoller.RJTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txbPaymentDateCalendar = new REMAS.Contoller.RJTextBox();
            this.btnSearchCompany = new System.Windows.Forms.Button();
            this.txbCompany = new REMAS.Contoller.RJTextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.separators1 = new REMAS.Contoller.Separators();
            this.label6 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnNewNotification = new System.Windows.Forms.Button();
            this.btnNotificationValidated = new System.Windows.Forms.Button();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(29, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(29, 100);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(77, 21);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company";
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            this.lblFactor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactor.Location = new System.Drawing.Point(413, 84);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(52, 21);
            this.lblFactor.TabIndex = 4;
            this.lblFactor.Text = "Factor";
            // 
            // lblPaymentdate
            // 
            this.lblPaymentdate.AutoSize = true;
            this.lblPaymentdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentdate.Location = new System.Drawing.Point(413, 235);
            this.lblPaymentdate.Name = "lblPaymentdate";
            this.lblPaymentdate.Size = new System.Drawing.Size(104, 21);
            this.lblPaymentdate.TabIndex = 5;
            this.lblPaymentdate.Text = "Payment date";
            // 
            // lblPayamentDate
            // 
            this.lblPayamentDate.AutoSize = true;
            this.lblPayamentDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayamentDate.Location = new System.Drawing.Point(29, 251);
            this.lblPayamentDate.Name = "lblPayamentDate";
            this.lblPayamentDate.Size = new System.Drawing.Size(104, 21);
            this.lblPayamentDate.TabIndex = 6;
            this.lblPayamentDate.Text = "Payment date";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.dgvInvoices);
            this.pnlBody.Controls.Add(this.btnPlus);
            this.pnlBody.Controls.Add(this.lblNew);
            this.pnlBody.Controls.Add(this.lblInvoice);
            this.pnlBody.Controls.Add(this.btnSearchPaymentDate);
            this.pnlBody.Controls.Add(this.txbPaymentDateSearch);
            this.pnlBody.Controls.Add(this.button5);
            this.pnlBody.Controls.Add(this.lblFactor);
            this.pnlBody.Controls.Add(this.lblPaymentdate);
            this.pnlBody.Controls.Add(this.txbPaymentDateCalendar);
            this.pnlBody.Controls.Add(this.btnSearchCompany);
            this.pnlBody.Controls.Add(this.txbCompany);
            this.pnlBody.Location = new System.Drawing.Point(18, 16);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(769, 533);
            this.pnlBody.TabIndex = 7;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoices.ColumnHeadersHeight = 50;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Search,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgvInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvInvoices.Location = new System.Drawing.Point(15, 377);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.RowHeadersWidth = 62;
            this.dgvInvoices.RowTemplate.Height = 28;
            this.dgvInvoices.Size = new System.Drawing.Size(725, 112);
            this.dgvInvoices.TabIndex = 79;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Search
            // 
            this.Search.DataPropertyName = "Search";
            this.Search.HeaderText = "Invoice";
            this.Search.MinimumWidth = 8;
            this.Search.Name = "Search";
            this.Search.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount paid";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Type select";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Payment move";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // btnPlus
            // 
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Image = global::REMAS.Properties.Resources.PlusLg;
            this.btnPlus.Location = new System.Drawing.Point(664, 346);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(23, 25);
            this.btnPlus.TabIndex = 111;
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(685, 348);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(42, 21);
            this.lblNew.TabIndex = 110;
            this.lblNew.Text = "New";
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(11, 348);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(66, 21);
            this.lblInvoice.TabIndex = 109;
            this.lblInvoice.Text = "Invoices";
            // 
            // btnSearchPaymentDate
            // 
            this.btnSearchPaymentDate.FlatAppearance.BorderSize = 0;
            this.btnSearchPaymentDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPaymentDate.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPaymentDate.Image")));
            this.btnSearchPaymentDate.Location = new System.Drawing.Point(714, 277);
            this.btnSearchPaymentDate.Name = "btnSearchPaymentDate";
            this.btnSearchPaymentDate.Size = new System.Drawing.Size(23, 25);
            this.btnSearchPaymentDate.TabIndex = 108;
            this.btnSearchPaymentDate.UseVisualStyleBackColor = true;
            // 
            // txbPaymentDateSearch
            // 
            this.txbPaymentDateSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txbPaymentDateSearch.BorderColor = System.Drawing.SystemColors.ControlText;
            this.txbPaymentDateSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPaymentDateSearch.BorderRadius = 0;
            this.txbPaymentDateSearch.BorderSize = 1;
            this.txbPaymentDateSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPaymentDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPaymentDateSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPaymentDateSearch.Location = new System.Drawing.Point(417, 262);
            this.txbPaymentDateSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txbPaymentDateSearch.MaxLength = 250;
            this.txbPaymentDateSearch.Multiline = false;
            this.txbPaymentDateSearch.Name = "txbPaymentDateSearch";
            this.txbPaymentDateSearch.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbPaymentDateSearch.PasswordChar = false;
            this.txbPaymentDateSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPaymentDateSearch.PlaceholderText = "";
            this.txbPaymentDateSearch.ReadOnly = false;
            this.txbPaymentDateSearch.Size = new System.Drawing.Size(323, 44);
            this.txbPaymentDateSearch.TabIndex = 107;
            this.txbPaymentDateSearch.Texts = "";
            this.txbPaymentDateSearch.UnderlinedStyle = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::REMAS.Properties.Resources.calendarDark;
            this.button5.Location = new System.Drawing.Point(353, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 25);
            this.button5.TabIndex = 106;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txbPaymentDateCalendar
            // 
            this.txbPaymentDateCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.txbPaymentDateCalendar.BorderColor = System.Drawing.SystemColors.ControlText;
            this.txbPaymentDateCalendar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbPaymentDateCalendar.BorderRadius = 0;
            this.txbPaymentDateCalendar.BorderSize = 1;
            this.txbPaymentDateCalendar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPaymentDateCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPaymentDateCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPaymentDateCalendar.Location = new System.Drawing.Point(15, 262);
            this.txbPaymentDateCalendar.Margin = new System.Windows.Forms.Padding(6);
            this.txbPaymentDateCalendar.MaxLength = 250;
            this.txbPaymentDateCalendar.Multiline = false;
            this.txbPaymentDateCalendar.Name = "txbPaymentDateCalendar";
            this.txbPaymentDateCalendar.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbPaymentDateCalendar.PasswordChar = false;
            this.txbPaymentDateCalendar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPaymentDateCalendar.PlaceholderText = "";
            this.txbPaymentDateCalendar.ReadOnly = false;
            this.txbPaymentDateCalendar.Size = new System.Drawing.Size(365, 44);
            this.txbPaymentDateCalendar.TabIndex = 105;
            this.txbPaymentDateCalendar.Texts = "";
            this.txbPaymentDateCalendar.UnderlinedStyle = true;
            // 
            // btnSearchCompany
            // 
            this.btnSearchCompany.FlatAppearance.BorderSize = 0;
            this.btnSearchCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCompany.Image")));
            this.btnSearchCompany.Location = new System.Drawing.Point(355, 137);
            this.btnSearchCompany.Name = "btnSearchCompany";
            this.btnSearchCompany.Size = new System.Drawing.Size(23, 25);
            this.btnSearchCompany.TabIndex = 104;
            this.btnSearchCompany.UseVisualStyleBackColor = true;
            // 
            // txbCompany
            // 
            this.txbCompany.BackColor = System.Drawing.SystemColors.Window;
            this.txbCompany.BorderColor = System.Drawing.SystemColors.ControlText;
            this.txbCompany.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbCompany.BorderRadius = 0;
            this.txbCompany.BorderSize = 1;
            this.txbCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCompany.Location = new System.Drawing.Point(15, 122);
            this.txbCompany.Margin = new System.Windows.Forms.Padding(6);
            this.txbCompany.MaxLength = 250;
            this.txbCompany.Multiline = false;
            this.txbCompany.Name = "txbCompany";
            this.txbCompany.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbCompany.PasswordChar = false;
            this.txbCompany.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCompany.PlaceholderText = "";
            this.txbCompany.ReadOnly = false;
            this.txbCompany.Size = new System.Drawing.Size(365, 44);
            this.txbCompany.TabIndex = 103;
            this.txbCompany.Texts = "";
            this.txbCompany.UnderlinedStyle = true;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Controls.Add(this.separators1);
            this.pnlActions.Controls.Add(this.label6);
            this.pnlActions.Controls.Add(this.btnValidate);
            this.pnlActions.Location = new System.Drawing.Point(793, 16);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(395, 190);
            this.pnlActions.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Emoji", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(5, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(385, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // separators1
            // 
            this.separators1.isVertical = false;
            this.separators1.Location = new System.Drawing.Point(0, 28);
            this.separators1.Name = "separators1";
            this.separators1.Size = new System.Drawing.Size(395, 23);
            this.separators1.TabIndex = 9;
            this.separators1.Text = "separators1";
            this.separators1.Thickness = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Actions";
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Blue;
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI Emoji", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidate.Location = new System.Drawing.Point(3, 54);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(385, 45);
            this.btnValidate.TabIndex = 9;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = false;
            // 
            // btnNewNotification
            // 
            this.btnNewNotification.FlatAppearance.BorderSize = 0;
            this.btnNewNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewNotification.Font = new System.Drawing.Font("Segoe UI Emoji", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNotification.Image = ((System.Drawing.Image)(resources.GetObject("btnNewNotification.Image")));
            this.btnNewNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewNotification.Location = new System.Drawing.Point(22, 49);
            this.btnNewNotification.Name = "btnNewNotification";
            this.btnNewNotification.Size = new System.Drawing.Size(142, 35);
            this.btnNewNotification.TabIndex = 1;
            this.btnNewNotification.Text = "New notification";
            this.btnNewNotification.UseVisualStyleBackColor = true;
            // 
            // btnNotificationValidated
            // 
            this.btnNotificationValidated.FlatAppearance.BorderSize = 0;
            this.btnNotificationValidated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificationValidated.Font = new System.Drawing.Font("Segoe UI Emoji", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificationValidated.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificationValidated.Image")));
            this.btnNotificationValidated.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotificationValidated.Location = new System.Drawing.Point(159, 49);
            this.btnNotificationValidated.Name = "btnNotificationValidated";
            this.btnNotificationValidated.Size = new System.Drawing.Size(183, 35);
            this.btnNotificationValidated.TabIndex = 2;
            this.btnNotificationValidated.Text = "Notification validated";
            this.btnNotificationValidated.UseVisualStyleBackColor = true;
            // 
            // frmDebtRecoveryFactoringNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.lblPayamentDate);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnNewNotification);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNotificationValidated);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDebtRecoveryFactoringNotifications";
            this.Text = "frmDebtRecoveryFactoringNotifications";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNewNotification;
        private System.Windows.Forms.Button btnNotificationValidated;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblFactor;
        private System.Windows.Forms.Label lblPaymentdate;
        private System.Windows.Forms.Label lblPayamentDate;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlActions;
        private Contoller.Separators separators1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnSave;
        private Contoller.RJTextBox txbCompany;
        private System.Windows.Forms.Button btnSearchCompany;
        private System.Windows.Forms.Button button5;
        private Contoller.RJTextBox txbPaymentDateCalendar;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Button btnSearchPaymentDate;
        private Contoller.RJTextBox txbPaymentDateSearch;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}