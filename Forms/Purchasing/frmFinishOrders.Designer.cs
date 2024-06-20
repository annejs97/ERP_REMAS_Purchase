namespace REMAS.Forms.Purchasing
{
    partial class frmFinishOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinishOrders));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ProgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvList.Location = new System.Drawing.Point(8, 92);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 62;
            this.dgvList.Size = new System.Drawing.Size(1171, 175);
            this.dgvList.TabIndex = 89;
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
            this.MenuName.Width = 200;
            // 
            // MainRoot
            // 
            this.MainRoot.HeaderText = "Company";
            this.MainRoot.MinimumWidth = 8;
            this.MainRoot.Name = "MainRoot";
            this.MainRoot.Width = 200;
            // 
            // SubRoot
            // 
            this.SubRoot.HeaderText = "Stock Location";
            this.SubRoot.MinimumWidth = 8;
            this.SubRoot.Name = "SubRoot";
            this.SubRoot.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Supplier";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Supplier ref.";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Order Date";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Buyer";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total A.T.I";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "Status";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 150;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pnlHeader.Location = new System.Drawing.Point(8, 12);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1169, 62);
            this.pnlHeader.TabIndex = 3;
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
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = global::REMAS.Properties.Resources.icons8_back_24__1_;
            this.btnRight.Location = new System.Drawing.Point(1114, 14);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(38, 35);
            this.btnRight.TabIndex = 64;
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(1080, 14);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(38, 35);
            this.btnLeft.TabIndex = 63;
            this.btnLeft.UseVisualStyleBackColor = false;
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.White;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPage.Location = new System.Drawing.Point(973, 16);
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
            // frmFinishOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFinishOrders";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.frmFinishOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
    }
}