namespace REMAS.Forms.Accounting
{
    partial class frmFactoringNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactoringNotifications));
            this.dgvFactoringNotifications = new System.Windows.Forms.DataGridView();
            this.pnFactoringNotifications = new REMAS.Contoller.CustomPanel();
            this.txbSearchPerodicProcess = new REMAS.Contoller.RJTextBox();
            this.txbNumberMovlin = new System.Windows.Forms.TextBox();
            this.btnSearcFactoring = new System.Windows.Forms.Button();
            this.btnGsrKanan = new System.Windows.Forms.Button();
            this.btnExcelPeridocProcess = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGsrKiri = new System.Windows.Forms.Button();
            this.btnPlusPeriodicProcess = new System.Windows.Forms.Button();
            this.btnRefreshPeriodicProcess = new System.Windows.Forms.Button();
            this.btnEditPeriodicProcess = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactoringNotifications)).BeginInit();
            this.pnFactoringNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFactoringNotifications
            // 
            this.dgvFactoringNotifications.AllowUserToOrderColumns = true;
            this.dgvFactoringNotifications.BackgroundColor = System.Drawing.Color.White;
            this.dgvFactoringNotifications.ColumnHeadersHeight = 50;
            this.dgvFactoringNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Search,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgvFactoringNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFactoringNotifications.Location = new System.Drawing.Point(4, 73);
            this.dgvFactoringNotifications.Name = "dgvFactoringNotifications";
            this.dgvFactoringNotifications.RowHeadersVisible = false;
            this.dgvFactoringNotifications.RowHeadersWidth = 62;
            this.dgvFactoringNotifications.RowTemplate.Height = 28;
            this.dgvFactoringNotifications.Size = new System.Drawing.Size(1192, 167);
            this.dgvFactoringNotifications.TabIndex = 77;
            // 
            // pnFactoringNotifications
            // 
            this.pnFactoringNotifications.BackColor = System.Drawing.Color.White;
            this.pnFactoringNotifications.BorderColor = System.Drawing.Color.White;
            this.pnFactoringNotifications.ColorBottom = System.Drawing.Color.Empty;
            this.pnFactoringNotifications.ColorTop = System.Drawing.Color.Empty;
            this.pnFactoringNotifications.Controls.Add(this.btnSearcFactoring);
            this.pnFactoringNotifications.Controls.Add(this.btnGsrKanan);
            this.pnFactoringNotifications.Controls.Add(this.txbSearchPerodicProcess);
            this.pnFactoringNotifications.Controls.Add(this.btnExcelPeridocProcess);
            this.pnFactoringNotifications.Controls.Add(this.btnSearch);
            this.pnFactoringNotifications.Controls.Add(this.btnGsrKiri);
            this.pnFactoringNotifications.Controls.Add(this.btnPlusPeriodicProcess);
            this.pnFactoringNotifications.Controls.Add(this.btnRefreshPeriodicProcess);
            this.pnFactoringNotifications.Controls.Add(this.btnEditPeriodicProcess);
            this.pnFactoringNotifications.Controls.Add(this.txbNumberMovlin);
            this.pnFactoringNotifications.Location = new System.Drawing.Point(4, 3);
            this.pnFactoringNotifications.Name = "pnFactoringNotifications";
            this.pnFactoringNotifications.Radius = 20;
            this.pnFactoringNotifications.Size = new System.Drawing.Size(1192, 60);
            this.pnFactoringNotifications.TabIndex = 76;
            this.pnFactoringNotifications.Thickness = 5F;
            // 
            // txbSearchPerodicProcess
            // 
            this.txbSearchPerodicProcess.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearchPerodicProcess.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbSearchPerodicProcess.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbSearchPerodicProcess.BorderRadius = 0;
            this.txbSearchPerodicProcess.BorderSize = 1;
            this.txbSearchPerodicProcess.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearchPerodicProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchPerodicProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearchPerodicProcess.Location = new System.Drawing.Point(46, 8);
            this.txbSearchPerodicProcess.Margin = new System.Windows.Forms.Padding(6);
            this.txbSearchPerodicProcess.MaxLength = 250;
            this.txbSearchPerodicProcess.Multiline = false;
            this.txbSearchPerodicProcess.Name = "txbSearchPerodicProcess";
            this.txbSearchPerodicProcess.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbSearchPerodicProcess.PasswordChar = false;
            this.txbSearchPerodicProcess.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchPerodicProcess.PlaceholderText = "Search";
            this.txbSearchPerodicProcess.ReadOnly = false;
            this.txbSearchPerodicProcess.Size = new System.Drawing.Size(271, 44);
            this.txbSearchPerodicProcess.TabIndex = 66;
            this.txbSearchPerodicProcess.Texts = "";
            this.txbSearchPerodicProcess.UnderlinedStyle = true;
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
            // btnSearcFactoring
            // 
            this.btnSearcFactoring.FlatAppearance.BorderSize = 0;
            this.btnSearcFactoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearcFactoring.Image = ((System.Drawing.Image)(resources.GetObject("btnSearcFactoring.Image")));
            this.btnSearcFactoring.Location = new System.Drawing.Point(278, 13);
            this.btnSearcFactoring.Name = "btnSearcFactoring";
            this.btnSearcFactoring.Size = new System.Drawing.Size(40, 33);
            this.btnSearcFactoring.TabIndex = 79;
            this.btnSearcFactoring.UseVisualStyleBackColor = true;
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
            // btnExcelPeridocProcess
            // 
            this.btnExcelPeridocProcess.FlatAppearance.BorderSize = 0;
            this.btnExcelPeridocProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelPeridocProcess.Image = global::REMAS.Properties.Resources.Excel_App;
            this.btnExcelPeridocProcess.Location = new System.Drawing.Point(439, 3);
            this.btnExcelPeridocProcess.Name = "btnExcelPeridocProcess";
            this.btnExcelPeridocProcess.Size = new System.Drawing.Size(40, 39);
            this.btnExcelPeridocProcess.TabIndex = 58;
            this.btnExcelPeridocProcess.UseVisualStyleBackColor = true;
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
            // btnPlusPeriodicProcess
            // 
            this.btnPlusPeriodicProcess.FlatAppearance.BorderSize = 0;
            this.btnPlusPeriodicProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusPeriodicProcess.Image = global::REMAS.Properties.Resources.PlusLg;
            this.btnPlusPeriodicProcess.Location = new System.Drawing.Point(319, 11);
            this.btnPlusPeriodicProcess.Name = "btnPlusPeriodicProcess";
            this.btnPlusPeriodicProcess.Size = new System.Drawing.Size(46, 27);
            this.btnPlusPeriodicProcess.TabIndex = 61;
            this.btnPlusPeriodicProcess.UseVisualStyleBackColor = true;
            // 
            // btnRefreshPeriodicProcess
            // 
            this.btnRefreshPeriodicProcess.FlatAppearance.BorderSize = 0;
            this.btnRefreshPeriodicProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPeriodicProcess.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.btnRefreshPeriodicProcess.Location = new System.Drawing.Point(402, 7);
            this.btnRefreshPeriodicProcess.Name = "btnRefreshPeriodicProcess";
            this.btnRefreshPeriodicProcess.Size = new System.Drawing.Size(38, 32);
            this.btnRefreshPeriodicProcess.TabIndex = 59;
            this.btnRefreshPeriodicProcess.UseVisualStyleBackColor = true;
            // 
            // btnEditPeriodicProcess
            // 
            this.btnEditPeriodicProcess.FlatAppearance.BorderSize = 0;
            this.btnEditPeriodicProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPeriodicProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPeriodicProcess.Image")));
            this.btnEditPeriodicProcess.Location = new System.Drawing.Point(366, 11);
            this.btnEditPeriodicProcess.Name = "btnEditPeriodicProcess";
            this.btnEditPeriodicProcess.Size = new System.Drawing.Size(32, 25);
            this.btnEditPeriodicProcess.TabIndex = 60;
            this.btnEditPeriodicProcess.UseVisualStyleBackColor = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 270;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Subrogation release";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Payment date";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Search
            // 
            this.Search.DataPropertyName = "Search";
            this.Search.Frozen = true;
            this.Search.HeaderText = "Factor";
            this.Search.MinimumWidth = 8;
            this.Search.Name = "Search";
            this.Search.Width = 300;
            // 
            // frmFactoringNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dgvFactoringNotifications);
            this.Controls.Add(this.pnFactoringNotifications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactoringNotifications";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactoringNotifications)).EndInit();
            this.pnFactoringNotifications.ResumeLayout(false);
            this.pnFactoringNotifications.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Contoller.CustomPanel pnFactoringNotifications;
        private System.Windows.Forms.Button btnGsrKanan;
        private Contoller.RJTextBox txbSearchPerodicProcess;
        private System.Windows.Forms.Button btnExcelPeridocProcess;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGsrKiri;
        private System.Windows.Forms.Button btnPlusPeriodicProcess;
        private System.Windows.Forms.Button btnRefreshPeriodicProcess;
        private System.Windows.Forms.Button btnEditPeriodicProcess;
        private System.Windows.Forms.TextBox txbNumberMovlin;
        private System.Windows.Forms.Button btnSearcFactoring;
        private System.Windows.Forms.DataGridView dgvFactoringNotifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
    }
}