namespace REMAS.Forms.Purchasing
{
    partial class frmSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearhCont = new System.Windows.Forms.Panel();
            this.btnSearchCont = new System.Windows.Forms.Button();
            this.txbSearchCont = new REMAS.Contoller.RJTextBox();
            this.lblPagesCont = new System.Windows.Forms.Label();
            this.btnLeftCont = new System.Windows.Forms.Button();
            this.btnRightCont = new System.Windows.Forms.Button();
            this.btnExcelCont = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRepeatCont = new System.Windows.Forms.Button();
            this.btnPlusCont = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearhCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(436, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "No record found.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlSearhCont
            // 
            this.pnlSearhCont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearhCont.BackColor = System.Drawing.Color.White;
            this.pnlSearhCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearhCont.Controls.Add(this.btnSearchCont);
            this.pnlSearhCont.Controls.Add(this.txbSearchCont);
            this.pnlSearhCont.Controls.Add(this.lblPagesCont);
            this.pnlSearhCont.Controls.Add(this.btnLeftCont);
            this.pnlSearhCont.Controls.Add(this.btnRightCont);
            this.pnlSearhCont.Controls.Add(this.btnExcelCont);
            this.pnlSearhCont.Controls.Add(this.btnEdit);
            this.pnlSearhCont.Controls.Add(this.btnRepeatCont);
            this.pnlSearhCont.Controls.Add(this.btnPlusCont);
            this.pnlSearhCont.Location = new System.Drawing.Point(11, 10);
            this.pnlSearhCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearhCont.Name = "pnlSearhCont";
            this.pnlSearhCont.Size = new System.Drawing.Size(1041, 41);
            this.pnlSearhCont.TabIndex = 66;
            // 
            // btnSearchCont
            // 
            this.btnSearchCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCont.FlatAppearance.BorderSize = 0;
            this.btnSearchCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCont.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCont.Image")));
            this.btnSearchCont.Location = new System.Drawing.Point(292, 6);
            this.btnSearchCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCont.Name = "btnSearchCont";
            this.btnSearchCont.Size = new System.Drawing.Size(28, 26);
            this.btnSearchCont.TabIndex = 261;
            this.btnSearchCont.UseVisualStyleBackColor = true;
            // 
            // txbSearchCont
            // 
            this.txbSearchCont.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearchCont.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbSearchCont.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbSearchCont.BorderRadius = 0;
            this.txbSearchCont.BorderSize = 1;
            this.txbSearchCont.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearchCont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearchCont.Location = new System.Drawing.Point(0, 2);
            this.txbSearchCont.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbSearchCont.MaxLength = 250;
            this.txbSearchCont.Multiline = false;
            this.txbSearchCont.Name = "txbSearchCont";
            this.txbSearchCont.Padding = new System.Windows.Forms.Padding(2, 9, 2, 6);
            this.txbSearchCont.PasswordChar = false;
            this.txbSearchCont.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchCont.PlaceholderText = "Search";
            this.txbSearchCont.ReadOnly = false;
            this.txbSearchCont.Size = new System.Drawing.Size(317, 36);
            this.txbSearchCont.TabIndex = 262;
            this.txbSearchCont.Texts = "";
            this.txbSearchCont.UnderlinedStyle = true;
            // 
            // lblPagesCont
            // 
            this.lblPagesCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPagesCont.AutoSize = true;
            this.lblPagesCont.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagesCont.ForeColor = System.Drawing.Color.DimGray;
            this.lblPagesCont.Location = new System.Drawing.Point(905, 10);
            this.lblPagesCont.Name = "lblPagesCont";
            this.lblPagesCont.Size = new System.Drawing.Size(74, 19);
            this.lblPagesCont.TabIndex = 12;
            this.lblPagesCont.Text = "1 to 5 of 5";
            // 
            // btnLeftCont
            // 
            this.btnLeftCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeftCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeftCont.FlatAppearance.BorderSize = 0;
            this.btnLeftCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftCont.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftCont.Image")));
            this.btnLeftCont.Location = new System.Drawing.Point(978, 6);
            this.btnLeftCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeftCont.Name = "btnLeftCont";
            this.btnLeftCont.Size = new System.Drawing.Size(28, 26);
            this.btnLeftCont.TabIndex = 31;
            this.btnLeftCont.UseVisualStyleBackColor = true;
            // 
            // btnRightCont
            // 
            this.btnRightCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRightCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRightCont.FlatAppearance.BorderSize = 0;
            this.btnRightCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightCont.Image = ((System.Drawing.Image)(resources.GetObject("btnRightCont.Image")));
            this.btnRightCont.Location = new System.Drawing.Point(1006, 6);
            this.btnRightCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRightCont.Name = "btnRightCont";
            this.btnRightCont.Size = new System.Drawing.Size(28, 26);
            this.btnRightCont.TabIndex = 30;
            this.btnRightCont.UseVisualStyleBackColor = true;
            // 
            // btnExcelCont
            // 
            this.btnExcelCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcelCont.FlatAppearance.BorderSize = 0;
            this.btnExcelCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelCont.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelCont.Image")));
            this.btnExcelCont.Location = new System.Drawing.Point(429, 6);
            this.btnExcelCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcelCont.Name = "btnExcelCont";
            this.btnExcelCont.Size = new System.Drawing.Size(28, 26);
            this.btnExcelCont.TabIndex = 29;
            this.btnExcelCont.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(362, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(28, 26);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRepeatCont
            // 
            this.btnRepeatCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepeatCont.FlatAppearance.BorderSize = 0;
            this.btnRepeatCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeatCont.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeatCont.Image")));
            this.btnRepeatCont.Location = new System.Drawing.Point(396, 6);
            this.btnRepeatCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRepeatCont.Name = "btnRepeatCont";
            this.btnRepeatCont.Size = new System.Drawing.Size(28, 26);
            this.btnRepeatCont.TabIndex = 27;
            this.btnRepeatCont.UseVisualStyleBackColor = true;
            this.btnRepeatCont.Click += new System.EventHandler(this.btnRepeatCont_Click);
            // 
            // btnPlusCont
            // 
            this.btnPlusCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlusCont.FlatAppearance.BorderSize = 0;
            this.btnPlusCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusCont.Image = ((System.Drawing.Image)(resources.GetObject("btnPlusCont.Image")));
            this.btnPlusCont.Location = new System.Drawing.Point(328, 6);
            this.btnPlusCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlusCont.Name = "btnPlusCont";
            this.btnPlusCont.Size = new System.Drawing.Size(28, 26);
            this.btnPlusCont.TabIndex = 26;
            this.btnPlusCont.UseVisualStyleBackColor = true;
            this.btnPlusCont.Click += new System.EventHandler(this.btnPlusCont_Click);
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref,
            this.Supplier,
            this.StockLocation,
            this.Status});
            this.dgvSupplier.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvSupplier.Location = new System.Drawing.Point(11, 63);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.Size = new System.Drawing.Size(1041, 372);
            this.dgvSupplier.TabIndex = 67;
            this.dgvSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellContentClick);
            // 
            // Ref
            // 
            this.Ref.HeaderText = "Ref.";
            this.Ref.MinimumWidth = 8;
            this.Ref.Name = "Ref";
            this.Ref.Width = 300;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 8;
            this.Supplier.Name = "Supplier";
            this.Supplier.Width = 300;
            // 
            // StockLocation
            // 
            this.StockLocation.HeaderText = "Stock Location";
            this.StockLocation.MinimumWidth = 8;
            this.StockLocation.Name = "StockLocation";
            this.StockLocation.Width = 300;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 300;
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.pnlSearhCont);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSuppliers";
            this.Text = "frmSuppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            this.pnlSearhCont.ResumeLayout(false);
            this.pnlSearhCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSearhCont;
        private System.Windows.Forms.Button btnSearchCont;
        private Contoller.RJTextBox txbSearchCont;
        private System.Windows.Forms.Label lblPagesCont;
        private System.Windows.Forms.Button btnLeftCont;
        private System.Windows.Forms.Button btnRightCont;
        private System.Windows.Forms.Button btnExcelCont;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRepeatCont;
        private System.Windows.Forms.Button btnPlusCont;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}