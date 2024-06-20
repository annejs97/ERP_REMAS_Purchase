namespace REMAS.Forms.Accounting
{
    partial class frmSEPACreditTransferTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSEPACreditTransferTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnReplace);
            this.pnlHeader.Controls.Add(this.btnFind);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.btnRight);
            this.pnlHeader.Controls.Add(this.btnLeft);
            this.pnlHeader.Controls.Add(this.lblPage);
            this.pnlHeader.Controls.Add(this.btnExcel);
            this.pnlHeader.Controls.Add(this.btnNotes);
            this.pnlHeader.Controls.Add(this.btnPlus);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1168, 40);
            this.pnlHeader.TabIndex = 8;
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.White;
            this.btnReplace.FlatAppearance.BorderSize = 0;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.btnReplace.Location = new System.Drawing.Point(338, 9);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(25, 23);
            this.btnReplace.TabIndex = 65;
            this.btnReplace.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(241, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(31, 26);
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
            this.txtSearch.Location = new System.Drawing.Point(15, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 250;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(1, 7, 1, 5);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(257, 29);
            this.txtSearch.TabIndex = 60;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = global::REMAS.Properties.Resources.icons8_back_24__1_;
            this.btnRight.Location = new System.Drawing.Point(1134, 10);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(25, 23);
            this.btnRight.TabIndex = 64;
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(1104, 10);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(25, 23);
            this.btnLeft.TabIndex = 63;
            this.btnLeft.UseVisualStyleBackColor = false;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.White;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPage.Location = new System.Drawing.Point(1029, 12);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(69, 17);
            this.lblPage.TabIndex = 62;
            this.lblPage.Text = "1 to 5 of 5";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Image = global::REMAS.Properties.Resources.Excel_App;
            this.btnExcel.Location = new System.Drawing.Point(370, 8);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(25, 23);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnNotes
            // 
            this.btnNotes.BackColor = System.Drawing.Color.White;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Image = global::REMAS.Properties.Resources.icons8_create_20;
            this.btnNotes.Location = new System.Drawing.Point(308, 7);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(25, 23);
            this.btnNotes.TabIndex = 3;
            this.btnNotes.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Image = global::REMAS.Properties.Resources.PlusLg;
            this.btnPlus.Location = new System.Drawing.Point(279, 9);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 23);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.UseVisualStyleBackColor = false;
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
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvList.Location = new System.Drawing.Point(12, 58);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(1168, 54);
            this.dgvList.TabIndex = 16;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sequence";
            this.Column3.Name = "Column3";
            this.Column3.Width = 400;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Partner Type";
            this.Column4.Name = "Column4";
            this.Column4.Width = 400;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Bank order due date";
            this.Column5.Name = "Column5";
            this.Column5.Width = 400;
            // 
            // frmSEPACreditTransferTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSEPACreditTransferTable";
            this.Text = "frmSEPACreditTransferTable";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}