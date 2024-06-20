namespace REMAS.Forms.Account
{
    partial class uctAddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctAddUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cbBlock = new System.Windows.Forms.CheckBox();
            this.txtEmail = new REMAS.Contoller.RJTextBox();
            this.separators3 = new REMAS.Contoller.Separators();
            this.separators1 = new REMAS.Contoller.Separators();
            this.txtUsername = new REMAS.Contoller.RJTextBox();
            this.txtNIK = new REMAS.Contoller.RJTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnView2 = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.separators5 = new REMAS.Contoller.Separators();
            this.txtConfirmPass = new REMAS.Contoller.RJTextBox();
            this.separators4 = new REMAS.Contoller.Separators();
            this.txtNewPass = new REMAS.Contoller.RJTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.txtSearch = new REMAS.Contoller.RJTextBox();
            this.separators2 = new REMAS.Contoller.Separators();
            this.ProgCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowAccess = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 37);
            this.panel1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.btnRefresh.Location = new System.Drawing.Point(673, 5);
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
            this.btnClose.Location = new System.Drawing.Point(747, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 26);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::REMAS.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(710, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(31, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeader.Location = new System.Drawing.Point(22, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(122, 17);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "CREATE NEW USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "NIK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Overview";
            // 
            // cmbDept
            // 
            this.cmbDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(25, 120);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(350, 21);
            this.cmbDept.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Email";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHeader.Controls.Add(this.cbBlock);
            this.pnlHeader.Controls.Add(this.txtEmail);
            this.pnlHeader.Controls.Add(this.label7);
            this.pnlHeader.Controls.Add(this.separators3);
            this.pnlHeader.Controls.Add(this.label6);
            this.pnlHeader.Controls.Add(this.cmbDept);
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.separators1);
            this.pnlHeader.Controls.Add(this.txtUsername);
            this.pnlHeader.Controls.Add(this.txtNIK);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Location = new System.Drawing.Point(10, 43);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(783, 193);
            this.pnlHeader.TabIndex = 15;
            // 
            // cbBlock
            // 
            this.cbBlock.AutoSize = true;
            this.cbBlock.Location = new System.Drawing.Point(24, 157);
            this.cbBlock.Name = "cbBlock";
            this.cbBlock.Size = new System.Drawing.Size(65, 17);
            this.cbBlock.TabIndex = 60;
            this.cbBlock.Text = "Blocked";
            this.cbBlock.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(406, 114);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 250;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(350, 29);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // separators3
            // 
            this.separators3.ForeColor = System.Drawing.Color.DarkGray;
            this.separators3.isVertical = false;
            this.separators3.Location = new System.Drawing.Point(25, 137);
            this.separators3.Name = "separators3";
            this.separators3.Size = new System.Drawing.Size(349, 10);
            this.separators3.TabIndex = 57;
            this.separators3.Text = "separators3";
            this.separators3.Thickness = 1;
            // 
            // separators1
            // 
            this.separators1.ForeColor = System.Drawing.Color.DarkGray;
            this.separators1.isVertical = false;
            this.separators1.Location = new System.Drawing.Point(2, 23);
            this.separators1.Name = "separators1";
            this.separators1.Size = new System.Drawing.Size(771, 23);
            this.separators1.TabIndex = 55;
            this.separators1.Text = "separators1";
            this.separators1.Thickness = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtUsername.BorderRadius = 0;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(406, 63);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 250;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "USERNAME";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(350, 29);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = true;
            // 
            // txtNIK
            // 
            this.txtNIK.BackColor = System.Drawing.SystemColors.Window;
            this.txtNIK.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtNIK.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtNIK.BorderRadius = 0;
            this.txtNIK.BorderSize = 1;
            this.txtNIK.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNIK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNIK.Location = new System.Drawing.Point(25, 63);
            this.txtNIK.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIK.MaxLength = 250;
            this.txtNIK.Multiline = false;
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtNIK.PasswordChar = false;
            this.txtNIK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNIK.PlaceholderText = "NIK";
            this.txtNIK.ReadOnly = false;
            this.txtNIK.Size = new System.Drawing.Size(350, 29);
            this.txtNIK.TabIndex = 5;
            this.txtNIK.Texts = "";
            this.txtNIK.UnderlinedStyle = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "New Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Authorization";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Confirm Password";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.lbWarning.Location = new System.Drawing.Point(22, 200);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(496, 13);
            this.lbWarning.TabIndex = 63;
            this.lbWarning.Text = "*** Password must be at least 8 character and contains one (digit - lowercase - u" +
    "ppercase - unique char)";
            this.lbWarning.Visible = false;
            // 
            // cmbGroup
            // 
            this.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(24, 73);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(732, 21);
            this.cmbGroup.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Group";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBody.Controls.Add(this.btnView2);
            this.pnlBody.Controls.Add(this.btnView);
            this.pnlBody.Controls.Add(this.separators5);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.cmbGroup);
            this.pnlBody.Controls.Add(this.lbWarning);
            this.pnlBody.Controls.Add(this.txtConfirmPass);
            this.pnlBody.Controls.Add(this.label8);
            this.pnlBody.Controls.Add(this.label9);
            this.pnlBody.Controls.Add(this.separators4);
            this.pnlBody.Controls.Add(this.txtNewPass);
            this.pnlBody.Controls.Add(this.label11);
            this.pnlBody.Location = new System.Drawing.Point(10, 242);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(783, 235);
            this.pnlBody.TabIndex = 16;
            // 
            // btnView2
            // 
            this.btnView2.FlatAppearance.BorderSize = 0;
            this.btnView2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView2.Image = global::REMAS.Properties.Resources.hidepass;
            this.btnView2.Location = new System.Drawing.Point(725, 170);
            this.btnView2.Name = "btnView2";
            this.btnView2.Size = new System.Drawing.Size(30, 23);
            this.btnView2.TabIndex = 66;
            this.btnView2.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Image = global::REMAS.Properties.Resources.hidepass;
            this.btnView.Location = new System.Drawing.Point(726, 121);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(30, 23);
            this.btnView.TabIndex = 17;
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // separators5
            // 
            this.separators5.ForeColor = System.Drawing.Color.DarkGray;
            this.separators5.isVertical = false;
            this.separators5.Location = new System.Drawing.Point(24, 90);
            this.separators5.Name = "separators5";
            this.separators5.Size = new System.Drawing.Size(731, 10);
            this.separators5.TabIndex = 65;
            this.separators5.Text = "separators5";
            this.separators5.Thickness = 1;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmPass.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtConfirmPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtConfirmPass.BorderRadius = 0;
            this.txtConfirmPass.BorderSize = 1;
            this.txtConfirmPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(25, 166);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.MaxLength = 250;
            this.txtConfirmPass.Multiline = false;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtConfirmPass.PasswordChar = true;
            this.txtConfirmPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPass.PlaceholderText = "Confirm Password";
            this.txtConfirmPass.ReadOnly = false;
            this.txtConfirmPass.Size = new System.Drawing.Size(731, 29);
            this.txtConfirmPass.TabIndex = 11;
            this.txtConfirmPass.Texts = "";
            this.txtConfirmPass.UnderlinedStyle = true;
            // 
            // separators4
            // 
            this.separators4.ForeColor = System.Drawing.Color.DarkGray;
            this.separators4.isVertical = false;
            this.separators4.Location = new System.Drawing.Point(2, 23);
            this.separators4.Name = "separators4";
            this.separators4.Size = new System.Drawing.Size(771, 23);
            this.separators4.TabIndex = 55;
            this.separators4.Text = "separators4";
            this.separators4.Thickness = 1;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPass.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtNewPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtNewPass.BorderRadius = 0;
            this.txtNewPass.BorderSize = 1;
            this.txtNewPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.Location = new System.Drawing.Point(25, 117);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.MaxLength = 250;
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtNewPass.PasswordChar = true;
            this.txtNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPass.PlaceholderText = "New Password";
            this.txtNewPass.ReadOnly = false;
            this.txtNewPass.Size = new System.Drawing.Size(731, 29);
            this.txtNewPass.TabIndex = 10;
            this.txtNewPass.Texts = "";
            this.txtNewPass.UnderlinedStyle = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "Permission";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbSearch.Location = new System.Drawing.Point(21, 49);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(61, 13);
            this.lbSearch.TabIndex = 58;
            this.lbSearch.Text = "Search by :";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(194, 66);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(31, 26);
            this.btnFind.TabIndex = 57;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.ProgCd,
            this.ProgName,
            this.MenuName,
            this.MainRoot,
            this.SubRoot,
            this.AllowAccess});
            this.dgvList.Location = new System.Drawing.Point(24, 102);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(737, 230);
            this.dgvList.TabIndex = 12;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFooter.Controls.Add(this.dgvList);
            this.pnlFooter.Controls.Add(this.btnFind);
            this.pnlFooter.Controls.Add(this.txtSearch);
            this.pnlFooter.Controls.Add(this.lbSearch);
            this.pnlFooter.Controls.Add(this.label12);
            this.pnlFooter.Controls.Add(this.separators2);
            this.pnlFooter.Location = new System.Drawing.Point(10, 483);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(783, 349);
            this.pnlFooter.TabIndex = 7;
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
            this.txtSearch.Location = new System.Drawing.Point(24, 66);
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
            this.txtSearch.TabIndex = 59;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // separators2
            // 
            this.separators2.ForeColor = System.Drawing.Color.DarkGray;
            this.separators2.isVertical = false;
            this.separators2.Location = new System.Drawing.Point(2, 23);
            this.separators2.Name = "separators2";
            this.separators2.Size = new System.Drawing.Size(771, 23);
            this.separators2.TabIndex = 55;
            this.separators2.Text = "separators2";
            this.separators2.Thickness = 1;
            // 
            // ProgCd
            // 
            this.ProgCd.HeaderText = "Program Code";
            this.ProgCd.Name = "ProgCd";
            // 
            // ProgName
            // 
            this.ProgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProgName.HeaderText = "Program Name";
            this.ProgName.Name = "ProgName";
            // 
            // MenuName
            // 
            this.MenuName.FillWeight = 150F;
            this.MenuName.HeaderText = "Menu Name";
            this.MenuName.Name = "MenuName";
            this.MenuName.Width = 150;
            // 
            // MainRoot
            // 
            this.MainRoot.HeaderText = "Main Root";
            this.MainRoot.Name = "MainRoot";
            // 
            // SubRoot
            // 
            this.SubRoot.HeaderText = "Sub Root";
            this.SubRoot.Name = "SubRoot";
            // 
            // AllowAccess
            // 
            this.AllowAccess.FalseValue = "false";
            this.AllowAccess.FillWeight = 80F;
            this.AllowAccess.HeaderText = "Allowed";
            this.AllowAccess.Name = "AllowAccess";
            this.AllowAccess.TrueValue = "true";
            this.AllowAccess.Width = 80;
            // 
            // ucAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(820, 650);
            this.Name = "ucAddUser";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Size = new System.Drawing.Size(803, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Contoller.RJTextBox txtNIK;
        private Contoller.RJTextBox txtUsername;
        private Contoller.Separators separators1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label label6;
        private Contoller.Separators separators3;
        private System.Windows.Forms.Label label7;
        private Contoller.RJTextBox txtEmail;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label11;
        private Contoller.RJTextBox txtNewPass;
        private Contoller.Separators separators4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Contoller.RJTextBox txtConfirmPass;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label4;
        private Contoller.Separators separators5;
        private System.Windows.Forms.Panel pnlBody;
        private Contoller.Separators separators2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSearch;
        private Contoller.RJTextBox txtSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnView2;
        private System.Windows.Forms.CheckBox cbBlock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubRoot;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AllowAccess;
    }
}
