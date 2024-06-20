namespace REMAS.Forms.Purchasing
{
    partial class frmProductservices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductservices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearchPrdct = new System.Windows.Forms.Panel();
            this.btnSearchPrdct = new System.Windows.Forms.Button();
            this.txbSearchPrdct = new REMAS.Contoller.RJTextBox();
            this.lblPagesPrdct = new System.Windows.Forms.Label();
            this.btnLeftPrdct = new System.Windows.Forms.Button();
            this.btnRightPrdct = new System.Windows.Forms.Button();
            this.btnExcelPrdct = new System.Windows.Forms.Button();
            this.btnCreatePrdct = new System.Windows.Forms.Button();
            this.btnRepeatPrdct = new System.Windows.Forms.Button();
            this.btnPlusPrdct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.journal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearchPrdct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchPrdct
            // 
            this.pnlSearchPrdct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchPrdct.BackColor = System.Drawing.Color.White;
            this.pnlSearchPrdct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearchPrdct.Controls.Add(this.btnSearchPrdct);
            this.pnlSearchPrdct.Controls.Add(this.txbSearchPrdct);
            this.pnlSearchPrdct.Controls.Add(this.lblPagesPrdct);
            this.pnlSearchPrdct.Controls.Add(this.btnLeftPrdct);
            this.pnlSearchPrdct.Controls.Add(this.btnRightPrdct);
            this.pnlSearchPrdct.Controls.Add(this.btnExcelPrdct);
            this.pnlSearchPrdct.Controls.Add(this.btnCreatePrdct);
            this.pnlSearchPrdct.Controls.Add(this.btnRepeatPrdct);
            this.pnlSearchPrdct.Controls.Add(this.btnPlusPrdct);
            this.pnlSearchPrdct.Location = new System.Drawing.Point(8, 11);
            this.pnlSearchPrdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearchPrdct.Name = "pnlSearchPrdct";
            this.pnlSearchPrdct.Size = new System.Drawing.Size(1180, 50);
            this.pnlSearchPrdct.TabIndex = 16;
            // 
            // btnSearchPrdct
            // 
            this.btnSearchPrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPrdct.FlatAppearance.BorderSize = 0;
            this.btnSearchPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPrdct.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPrdct.Image")));
            this.btnSearchPrdct.Location = new System.Drawing.Point(328, 5);
            this.btnSearchPrdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPrdct.Name = "btnSearchPrdct";
            this.btnSearchPrdct.Size = new System.Drawing.Size(32, 32);
            this.btnSearchPrdct.TabIndex = 263;
            this.btnSearchPrdct.UseVisualStyleBackColor = true;
            // 
            // txbSearchPrdct
            // 
            this.txbSearchPrdct.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearchPrdct.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbSearchPrdct.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbSearchPrdct.BorderRadius = 0;
            this.txbSearchPrdct.BorderSize = 1;
            this.txbSearchPrdct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearchPrdct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchPrdct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearchPrdct.Location = new System.Drawing.Point(0, 1);
            this.txbSearchPrdct.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbSearchPrdct.MaxLength = 250;
            this.txbSearchPrdct.Multiline = false;
            this.txbSearchPrdct.Name = "txbSearchPrdct";
            this.txbSearchPrdct.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbSearchPrdct.PasswordChar = false;
            this.txbSearchPrdct.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchPrdct.PlaceholderText = "Search";
            this.txbSearchPrdct.ReadOnly = false;
            this.txbSearchPrdct.Size = new System.Drawing.Size(357, 45);
            this.txbSearchPrdct.TabIndex = 264;
            this.txbSearchPrdct.Texts = "";
            this.txbSearchPrdct.UnderlinedStyle = true;
            // 
            // lblPagesPrdct
            // 
            this.lblPagesPrdct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPagesPrdct.AutoSize = true;
            this.lblPagesPrdct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagesPrdct.ForeColor = System.Drawing.Color.DimGray;
            this.lblPagesPrdct.Location = new System.Drawing.Point(1002, 14);
            this.lblPagesPrdct.Name = "lblPagesPrdct";
            this.lblPagesPrdct.Size = new System.Drawing.Size(81, 21);
            this.lblPagesPrdct.TabIndex = 12;
            this.lblPagesPrdct.Text = "1 to 5 of 5";
            // 
            // btnLeftPrdct
            // 
            this.btnLeftPrdct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeftPrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeftPrdct.FlatAppearance.BorderSize = 0;
            this.btnLeftPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftPrdct.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftPrdct.Image")));
            this.btnLeftPrdct.Location = new System.Drawing.Point(1096, 6);
            this.btnLeftPrdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeftPrdct.Name = "btnLeftPrdct";
            this.btnLeftPrdct.Size = new System.Drawing.Size(32, 32);
            this.btnLeftPrdct.TabIndex = 31;
            this.btnLeftPrdct.UseVisualStyleBackColor = true;
            // 
            // btnRightPrdct
            // 
            this.btnRightPrdct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRightPrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRightPrdct.FlatAppearance.BorderSize = 0;
            this.btnRightPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightPrdct.Image = ((System.Drawing.Image)(resources.GetObject("btnRightPrdct.Image")));
            this.btnRightPrdct.Location = new System.Drawing.Point(1133, 6);
            this.btnRightPrdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRightPrdct.Name = "btnRightPrdct";
            this.btnRightPrdct.Size = new System.Drawing.Size(32, 32);
            this.btnRightPrdct.TabIndex = 30;
            this.btnRightPrdct.UseVisualStyleBackColor = true;
            // 
            // btnExcelPrdct
            // 
            this.btnExcelPrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcelPrdct.FlatAppearance.BorderSize = 0;
            this.btnExcelPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelPrdct.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelPrdct.Image")));
            this.btnExcelPrdct.Location = new System.Drawing.Point(483, 8);
            this.btnExcelPrdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcelPrdct.Name = "btnExcelPrdct";
            this.btnExcelPrdct.Size = new System.Drawing.Size(32, 32);
            this.btnExcelPrdct.TabIndex = 29;
            this.btnExcelPrdct.UseVisualStyleBackColor = true;
            // 
            // btnCreatePrdct
            // 
            this.btnCreatePrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreatePrdct.FlatAppearance.BorderSize = 0;
            this.btnCreatePrdct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrdct.Image = ((System.Drawing.Image)(resources.GetObject("btnCreatePrdct.Image")));
            this.btnCreatePrdct.Location = new System.Drawing.Point(407, 8);
            this.btnCreatePrdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreatePrdct.Name = "btnCreatePrdct";
            this.btnCreatePrdct.Size = new System.Drawing.Size(32, 32);
            this.btnCreatePrdct.TabIndex = 28;
            this.btnCreatePrdct.UseVisualStyleBackColor = true;
            // 
            // btnRepeatPrdct
            // 
            this.btnRepeatPrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepeatPrdct.FlatAppearance.BorderSize = 0;
            this.btnRepeatPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeatPrdct.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeatPrdct.Image")));
            this.btnRepeatPrdct.Location = new System.Drawing.Point(446, 8);
            this.btnRepeatPrdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRepeatPrdct.Name = "btnRepeatPrdct";
            this.btnRepeatPrdct.Size = new System.Drawing.Size(32, 32);
            this.btnRepeatPrdct.TabIndex = 27;
            this.btnRepeatPrdct.UseVisualStyleBackColor = true;
            // 
            // btnPlusPrdct
            // 
            this.btnPlusPrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlusPrdct.FlatAppearance.BorderSize = 0;
            this.btnPlusPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusPrdct.Image = ((System.Drawing.Image)(resources.GetObject("btnPlusPrdct.Image")));
            this.btnPlusPrdct.Location = new System.Drawing.Point(369, 8);
            this.btnPlusPrdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlusPrdct.Name = "btnPlusPrdct";
            this.btnPlusPrdct.Size = new System.Drawing.Size(32, 32);
            this.btnPlusPrdct.TabIndex = 26;
            this.btnPlusPrdct.UseVisualStyleBackColor = true;
            this.btnPlusPrdct.Click += new System.EventHandler(this.btnPlusPrdct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.journal,
            this.period,
            this.date,
            this.partner,
            this.company,
            this.internalDesc});
            this.dgvProducts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProducts.Location = new System.Drawing.Point(8, 84);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1180, 319);
            this.dgvProducts.TabIndex = 15;
            // 
            // journal
            // 
            this.journal.HeaderText = "Journal";
            this.journal.MinimumWidth = 6;
            this.journal.Name = "journal";
            // 
            // period
            // 
            this.period.HeaderText = "Period";
            this.period.MinimumWidth = 6;
            this.period.Name = "period";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // partner
            // 
            this.partner.HeaderText = "Partner";
            this.partner.MinimumWidth = 6;
            this.partner.Name = "partner";
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.MinimumWidth = 6;
            this.company.Name = "company";
            // 
            // internalDesc
            // 
            this.internalDesc.HeaderText = "Internal Description";
            this.internalDesc.MinimumWidth = 6;
            this.internalDesc.Name = "internalDesc";
            // 
            // frmProductservices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlSearchPrdct);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductservices";
            this.Text = "frmProductservices";
            this.Load += new System.EventHandler(this.frmProductservices_Load);
            this.pnlSearchPrdct.ResumeLayout(false);
            this.pnlSearchPrdct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchPrdct;
        private System.Windows.Forms.Button btnExcelPrdct;
        private System.Windows.Forms.Button btnCreatePrdct;
        private System.Windows.Forms.Button btnRepeatPrdct;
        private System.Windows.Forms.Button btnPlusPrdct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnSearchPrdct;
        private Contoller.RJTextBox txbSearchPrdct;
        private System.Windows.Forms.Label lblPagesPrdct;
        private System.Windows.Forms.Button btnLeftPrdct;
        private System.Windows.Forms.Button btnRightPrdct;
        private System.Windows.Forms.DataGridViewTextBoxColumn journal;
        private System.Windows.Forms.DataGridViewTextBoxColumn period;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn partner;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn internalDesc;
    }
}