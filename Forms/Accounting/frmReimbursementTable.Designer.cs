namespace REMAS.Forms.Accounting
{
    partial class frmReimbursementTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReimbursementTable));
            this.pnlReimbursementTable = new REMAS.Contoller.CustomPanel();
            this.txbSearch = new REMAS.Contoller.RJTextBox();
            this.txbNumberMovlin = new System.Windows.Forms.TextBox();
            this.btnSearchFactoring = new System.Windows.Forms.Button();
            this.btnGsrKanan = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGsrKiri = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvReimbursementTable = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReimbursementTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReimbursementTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReimbursementTable
            // 
            this.pnlReimbursementTable.BackColor = System.Drawing.Color.White;
            this.pnlReimbursementTable.BorderColor = System.Drawing.Color.White;
            this.pnlReimbursementTable.ColorBottom = System.Drawing.Color.Empty;
            this.pnlReimbursementTable.ColorTop = System.Drawing.Color.Empty;
            this.pnlReimbursementTable.Controls.Add(this.btnSearchFactoring);
            this.pnlReimbursementTable.Controls.Add(this.btnGsrKanan);
            this.pnlReimbursementTable.Controls.Add(this.txbSearch);
            this.pnlReimbursementTable.Controls.Add(this.btnExcel);
            this.pnlReimbursementTable.Controls.Add(this.btnSearch);
            this.pnlReimbursementTable.Controls.Add(this.btnGsrKiri);
            this.pnlReimbursementTable.Controls.Add(this.btnPlus);
            this.pnlReimbursementTable.Controls.Add(this.btnRefresh);
            this.pnlReimbursementTable.Controls.Add(this.btnEdit);
            this.pnlReimbursementTable.Controls.Add(this.txbNumberMovlin);
            this.pnlReimbursementTable.Location = new System.Drawing.Point(4, 14);
            this.pnlReimbursementTable.Name = "pnlReimbursementTable";
            this.pnlReimbursementTable.Radius = 20;
            this.pnlReimbursementTable.Size = new System.Drawing.Size(1192, 60);
            this.pnlReimbursementTable.TabIndex = 78;
            this.pnlReimbursementTable.Thickness = 5F;
            // 
            // txbSearch
            // 
            this.txbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearch.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbSearch.BorderRadius = 0;
            this.txbSearch.BorderSize = 1;
            this.txbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.Location = new System.Drawing.Point(46, 8);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txbSearch.MaxLength = 250;
            this.txbSearch.Multiline = false;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbSearch.PasswordChar = false;
            this.txbSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearch.PlaceholderText = "Search";
            this.txbSearch.ReadOnly = false;
            this.txbSearch.Size = new System.Drawing.Size(271, 44);
            this.txbSearch.TabIndex = 66;
            this.txbSearch.Texts = "";
            this.txbSearch.UnderlinedStyle = true;
            // 
            // txbNumberMovlin
            // 
            this.txbNumberMovlin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNumberMovlin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumberMovlin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbNumberMovlin.Location = new System.Drawing.Point(987, 11);
            this.txbNumberMovlin.Multiline = true;
            this.txbNumberMovlin.Name = "txbNumberMovlin";
            this.txbNumberMovlin.Size = new System.Drawing.Size(135, 28);
            this.txbNumberMovlin.TabIndex = 63;
            this.txbNumberMovlin.Text = "    1 to 5 of 5";
            // 
            // btnSearchFactoring
            // 
            this.btnSearchFactoring.FlatAppearance.BorderSize = 0;
            this.btnSearchFactoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFactoring.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFactoring.Image")));
            this.btnSearchFactoring.Location = new System.Drawing.Point(278, 13);
            this.btnSearchFactoring.Name = "btnSearchFactoring";
            this.btnSearchFactoring.Size = new System.Drawing.Size(40, 33);
            this.btnSearchFactoring.TabIndex = 79;
            this.btnSearchFactoring.UseVisualStyleBackColor = true;
            // 
            // btnGsrKanan
            // 
            this.btnGsrKanan.FlatAppearance.BorderSize = 0;
            this.btnGsrKanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGsrKanan.Image = ((System.Drawing.Image)(resources.GetObject("btnGsrKanan.Image")));
            this.btnGsrKanan.Location = new System.Drawing.Point(1148, 10);
            this.btnGsrKanan.Name = "btnGsrKanan";
            this.btnGsrKanan.Size = new System.Drawing.Size(29, 23);
            this.btnGsrKanan.TabIndex = 65;
            this.btnGsrKanan.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Image = global::REMAS.Properties.Resources.Excel_App;
            this.btnExcel.Location = new System.Drawing.Point(439, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 39);
            this.btnExcel.TabIndex = 58;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(273, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 33);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnGsrKiri
            // 
            this.btnGsrKiri.FlatAppearance.BorderSize = 0;
            this.btnGsrKiri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGsrKiri.Image = ((System.Drawing.Image)(resources.GetObject("btnGsrKiri.Image")));
            this.btnGsrKiri.Location = new System.Drawing.Point(1121, 10);
            this.btnGsrKiri.Name = "btnGsrKiri";
            this.btnGsrKiri.Size = new System.Drawing.Size(26, 23);
            this.btnGsrKiri.TabIndex = 64;
            this.btnGsrKiri.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Image = global::REMAS.Properties.Resources.PlusLg;
            this.btnPlus.Location = new System.Drawing.Point(319, 11);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(46, 27);
            this.btnPlus.TabIndex = 61;
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.btnRefresh.Location = new System.Drawing.Point(402, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(38, 32);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(366, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 25);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dgvReimbursementTable
            // 
            this.dgvReimbursementTable.AllowUserToOrderColumns = true;
            this.dgvReimbursementTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvReimbursementTable.ColumnHeadersHeight = 50;
            this.dgvReimbursementTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Search,
            this.Column3,
            this.Column1});
            this.dgvReimbursementTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvReimbursementTable.Location = new System.Drawing.Point(4, 94);
            this.dgvReimbursementTable.Name = "dgvReimbursementTable";
            this.dgvReimbursementTable.RowHeadersVisible = false;
            this.dgvReimbursementTable.RowHeadersWidth = 62;
            this.dgvReimbursementTable.RowTemplate.Height = 28;
            this.dgvReimbursementTable.Size = new System.Drawing.Size(1192, 167);
            this.dgvReimbursementTable.TabIndex = 79;
            // 
            // Search
            // 
            this.Search.DataPropertyName = "Search";
            this.Search.Frozen = true;
            this.Search.HeaderText = "Ref.";
            this.Search.MinimumWidth = 8;
            this.Search.Name = "Search";
            this.Search.Width = 400;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 385;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Amount to reimburse";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 400;
            // 
            // frmReimbursementTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dgvReimbursementTable);
            this.Controls.Add(this.pnlReimbursementTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReimbursementTable";
            this.Text = "frmReimbursementTable";
            this.pnlReimbursementTable.ResumeLayout(false);
            this.pnlReimbursementTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReimbursementTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Contoller.CustomPanel pnlReimbursementTable;
        private System.Windows.Forms.Button btnSearchFactoring;
        private System.Windows.Forms.Button btnGsrKanan;
        private Contoller.RJTextBox txbSearch;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGsrKiri;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txbNumberMovlin;
        private System.Windows.Forms.DataGridView dgvReimbursementTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}