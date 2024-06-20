namespace REMAS.Forms.Account
{
    partial class frmSystemUser
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new REMAS.Contoller.RJTextBox();
            this.rbBlocked = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlUC = new REMAS.Contoller.CustomPanel();
            this.dragControl1 = new REMAS.Contoller.DragControl();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 26);
            this.panel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "SYSTEM USER";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Crimson;
            this.btnClose.Location = new System.Drawing.Point(855, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 26);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "❎";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.rbBlocked);
            this.panel1.Controls.Add(this.rbActive);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 54);
            this.panel1.TabIndex = 12;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(181, 13);
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
            this.txtSearch.Location = new System.Drawing.Point(11, 18);
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
            this.txtSearch.TabIndex = 53;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // rbBlocked
            // 
            this.rbBlocked.AutoSize = true;
            this.rbBlocked.Location = new System.Drawing.Point(728, 18);
            this.rbBlocked.Name = "rbBlocked";
            this.rbBlocked.Size = new System.Drawing.Size(64, 17);
            this.rbBlocked.TabIndex = 10;
            this.rbBlocked.TabStop = true;
            this.rbBlocked.Text = "Blocked";
            this.rbBlocked.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(645, 18);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(55, 17);
            this.rbActive.TabIndex = 9;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(281, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(31, 26);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
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
            // btnExportExcel
            // 
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Image = global::REMAS.Properties.Resources.Excel_App;
            this.btnExportExcel.Location = new System.Drawing.Point(363, 13);
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
            this.btnRefresh.Location = new System.Drawing.Point(321, 13);
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
            this.btnAdd.Location = new System.Drawing.Point(243, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.NIK,
            this.UserName,
            this.Email,
            this.UserGroup,
            this.DeptCd,
            this.DeptName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 80);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(879, 674);
            this.dgvList.TabIndex = 13;
            // 
            // pnlUC
            // 
            this.pnlUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlUC.BorderColor = System.Drawing.Color.Transparent;
            this.pnlUC.ColorBottom = System.Drawing.Color.Empty;
            this.pnlUC.ColorTop = System.Drawing.Color.Empty;
            this.pnlUC.Location = new System.Drawing.Point(790, 242);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlUC.Radius = 10;
            this.pnlUC.Size = new System.Drawing.Size(102, 100);
            this.pnlUC.TabIndex = 14;
            this.pnlUC.Thickness = 5F;
            this.pnlUC.Visible = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel2;
            // 
            // No
            // 
            this.No.FillWeight = 50F;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 50;
            // 
            // NIK
            // 
            this.NIK.HeaderText = "NIK";
            this.NIK.Name = "NIK";
            this.NIK.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.HeaderText = "Username";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // UserGroup
            // 
            this.UserGroup.HeaderText = "Group";
            this.UserGroup.Name = "UserGroup";
            this.UserGroup.ReadOnly = true;
            this.UserGroup.Width = 150;
            // 
            // DeptCd
            // 
            this.DeptCd.HeaderText = "DeptCd";
            this.DeptCd.Name = "DeptCd";
            this.DeptCd.ReadOnly = true;
            this.DeptCd.Visible = false;
            // 
            // DeptName
            // 
            this.DeptName.HeaderText = "Department";
            this.DeptName.Name = "DeptName";
            this.DeptName.ReadOnly = true;
            // 
            // fmSystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 754);
            this.ControlBox = false;
            this.Controls.Add(this.pnlUC);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "fmSystemUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private Contoller.DragControl dragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvList;
        private Contoller.CustomPanel pnlUC;
        private System.Windows.Forms.RadioButton rbBlocked;
        private System.Windows.Forms.RadioButton rbActive;
        private Contoller.RJTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
    }
}