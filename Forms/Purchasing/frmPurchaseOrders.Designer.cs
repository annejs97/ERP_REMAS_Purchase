namespace REMAS
{
    partial class frmPurchaseOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrders));
            this.dgvPurchorder = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnInternalnot = new REMAS.Contoller.CustomPanel();
            this.txbGarisInternal = new REMAS.Contoller.RJTextBox();
            this.btnRatakanan = new System.Windows.Forms.Button();
            this.btnRataKiri = new System.Windows.Forms.Button();
            this.btnWaterdrop = new System.Windows.Forms.Button();
            this.btnBrush = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnStrikethrough = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnTypography = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnParagraph = new System.Windows.Forms.Button();
            this.txbInternalnot = new System.Windows.Forms.TextBox();
            this.sptrInternalnot = new REMAS.Contoller.Separators();
            this.lblInternalnote = new System.Windows.Forms.Label();
            this.pnDraft = new REMAS.Contoller.CustomPanel();
            this.cmbCompany = new REMAS.Contoller.RJComboBox();
            this.separators1 = new REMAS.Contoller.Separators();
            this.lblDraft = new System.Windows.Forms.Label();
            this.pnlDraft = new shape.ArrowPentagon();
            this.lblCanceled = new System.Windows.Forms.Label();
            this.pnlCanceled = new shape.ArrowChevron();
            this.lblFinished = new System.Windows.Forms.Label();
            this.lblValidated = new System.Windows.Forms.Label();
            this.lblRequested = new System.Windows.Forms.Label();
            this.pnlFinished = new shape.ArrowChevron();
            this.pnlValidated = new shape.ArrowChevron();
            this.pnlRequested = new shape.ArrowChevron();
            this.pcbTandaseru = new System.Windows.Forms.PictureBox();
            this.btnTextcurrency = new System.Windows.Forms.Button();
            this.btnSearchCurrency = new System.Windows.Forms.Button();
            this.btnPricelist = new System.Windows.Forms.Button();
            this.lblPricelist = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbSupplier = new REMAS.Contoller.RJComboBox();
            this.sptrSourceuctInf = new REMAS.Contoller.Separators();
            this.chbInATI = new System.Windows.Forms.CheckBox();
            this.lblInAti = new System.Windows.Forms.Label();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.cmbCurrency = new REMAS.Contoller.RJComboBox();
            this.separators2 = new REMAS.Contoller.Separators();
            this.separators3 = new REMAS.Contoller.Separators();
            this.cmbPriceList = new REMAS.Contoller.RJComboBox();
            this.cmbContact = new REMAS.Contoller.RJComboBox();
            this.separators4 = new REMAS.Contoller.Separators();
            this.pnPurchOrde = new REMAS.Contoller.CustomPanel();
            this.btnGsrKanan = new System.Windows.Forms.Button();
            this.btnExcelPurchorder = new System.Windows.Forms.Button();
            this.btnGsrKiri = new System.Windows.Forms.Button();
            this.btnSearchpurchorde = new System.Windows.Forms.Button();
            this.txbNumberPurchorder = new System.Windows.Forms.TextBox();
            this.btnRefreshPurchorder = new System.Windows.Forms.Button();
            this.txbSearchPurchOrder = new REMAS.Contoller.RJTextBox();
            this.btnEditPurchorder = new System.Windows.Forms.Button();
            this.btnPlusPurchord = new System.Windows.Forms.Button();
            this.pnlRequestClose = new REMAS.Contoller.UPanel();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnValidated = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchorder)).BeginInit();
            this.pnInternalnot.SuspendLayout();
            this.pnDraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTandaseru)).BeginInit();
            this.pnPurchOrde.SuspendLayout();
            this.pnlRequestClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPurchorder
            // 
            this.dgvPurchorder.AllowUserToOrderColumns = true;
            this.dgvPurchorder.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPurchorder.ColumnHeadersHeight = 40;
            this.dgvPurchorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Search,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvPurchorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPurchorder.Location = new System.Drawing.Point(14, 90);
            this.dgvPurchorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPurchorder.Name = "dgvPurchorder";
            this.dgvPurchorder.RowHeadersWidth = 62;
            this.dgvPurchorder.RowTemplate.Height = 28;
            this.dgvPurchorder.Size = new System.Drawing.Size(1583, 168);
            this.dgvPurchorder.TabIndex = 51;
            // 
            // Search
            // 
            this.Search.DataPropertyName = "Search";
            this.Search.Frozen = true;
            this.Search.HeaderText = "Ref";
            this.Search.MinimumWidth = 150;
            this.Search.Name = "Search";
            this.Search.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Search.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Company";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Stock location";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Supplier";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 115;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Supplier ref.";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 122;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Order date";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 121;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Buyer";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 110;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total A.T.I.";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Status";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column9.Width = 107;
            // 
            // pnInternalnot
            // 
            this.pnInternalnot.BackColor = System.Drawing.Color.White;
            this.pnInternalnot.BorderColor = System.Drawing.Color.White;
            this.pnInternalnot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnInternalnot.ColorBottom = System.Drawing.Color.Empty;
            this.pnInternalnot.ColorTop = System.Drawing.Color.Empty;
            this.pnInternalnot.Controls.Add(this.txbGarisInternal);
            this.pnInternalnot.Controls.Add(this.btnRatakanan);
            this.pnInternalnot.Controls.Add(this.btnRataKiri);
            this.pnInternalnot.Controls.Add(this.btnWaterdrop);
            this.pnInternalnot.Controls.Add(this.btnBrush);
            this.pnInternalnot.Controls.Add(this.btnEraser);
            this.pnInternalnot.Controls.Add(this.btnStrikethrough);
            this.pnInternalnot.Controls.Add(this.btnUnderline);
            this.pnInternalnot.Controls.Add(this.btnItalic);
            this.pnInternalnot.Controls.Add(this.btnBold);
            this.pnInternalnot.Controls.Add(this.btnTypography);
            this.pnInternalnot.Controls.Add(this.btnA);
            this.pnInternalnot.Controls.Add(this.btnParagraph);
            this.pnInternalnot.Controls.Add(this.txbInternalnot);
            this.pnInternalnot.Controls.Add(this.sptrInternalnot);
            this.pnInternalnot.Controls.Add(this.lblInternalnote);
            this.pnInternalnot.Location = new System.Drawing.Point(1109, 276);
            this.pnInternalnot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnInternalnot.Name = "pnInternalnot";
            this.pnInternalnot.Radius = 20;
            this.pnInternalnot.Size = new System.Drawing.Size(488, 308);
            this.pnInternalnot.TabIndex = 65;
            this.pnInternalnot.Thickness = 5F;
            // 
            // txbGarisInternal
            // 
            this.txbGarisInternal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txbGarisInternal.BorderColor = System.Drawing.Color.Transparent;
            this.txbGarisInternal.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txbGarisInternal.BorderRadius = 0;
            this.txbGarisInternal.BorderSize = 1;
            this.txbGarisInternal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbGarisInternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGarisInternal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbGarisInternal.Location = new System.Drawing.Point(0, -25);
            this.txbGarisInternal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbGarisInternal.MaxLength = 250;
            this.txbGarisInternal.Multiline = false;
            this.txbGarisInternal.Name = "txbGarisInternal";
            this.txbGarisInternal.Padding = new System.Windows.Forms.Padding(1, 8, 1, 5);
            this.txbGarisInternal.PasswordChar = false;
            this.txbGarisInternal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbGarisInternal.PlaceholderText = "";
            this.txbGarisInternal.ReadOnly = false;
            this.txbGarisInternal.Size = new System.Drawing.Size(428, 38);
            this.txbGarisInternal.TabIndex = 66;
            this.txbGarisInternal.Texts = "";
            this.txbGarisInternal.UnderlinedStyle = false;
            // 
            // btnRatakanan
            // 
            this.btnRatakanan.FlatAppearance.BorderSize = 0;
            this.btnRatakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRatakanan.Image = ((System.Drawing.Image)(resources.GetObject("btnRatakanan.Image")));
            this.btnRatakanan.Location = new System.Drawing.Point(296, 75);
            this.btnRatakanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRatakanan.Name = "btnRatakanan";
            this.btnRatakanan.Size = new System.Drawing.Size(21, 21);
            this.btnRatakanan.TabIndex = 55;
            this.btnRatakanan.UseVisualStyleBackColor = true;
            // 
            // btnRataKiri
            // 
            this.btnRataKiri.FlatAppearance.BorderSize = 0;
            this.btnRataKiri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRataKiri.Image = ((System.Drawing.Image)(resources.GetObject("btnRataKiri.Image")));
            this.btnRataKiri.Location = new System.Drawing.Point(267, 75);
            this.btnRataKiri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRataKiri.Name = "btnRataKiri";
            this.btnRataKiri.Size = new System.Drawing.Size(27, 21);
            this.btnRataKiri.TabIndex = 55;
            this.btnRataKiri.UseVisualStyleBackColor = true;
            // 
            // btnWaterdrop
            // 
            this.btnWaterdrop.FlatAppearance.BorderSize = 0;
            this.btnWaterdrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaterdrop.Image = ((System.Drawing.Image)(resources.GetObject("btnWaterdrop.Image")));
            this.btnWaterdrop.Location = new System.Drawing.Point(245, 76);
            this.btnWaterdrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWaterdrop.Name = "btnWaterdrop";
            this.btnWaterdrop.Size = new System.Drawing.Size(19, 19);
            this.btnWaterdrop.TabIndex = 55;
            this.btnWaterdrop.UseVisualStyleBackColor = true;
            // 
            // btnBrush
            // 
            this.btnBrush.FlatAppearance.BorderSize = 0;
            this.btnBrush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrush.Image = ((System.Drawing.Image)(resources.GetObject("btnBrush.Image")));
            this.btnBrush.Location = new System.Drawing.Point(219, 75);
            this.btnBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(21, 22);
            this.btnBrush.TabIndex = 55;
            this.btnBrush.UseVisualStyleBackColor = true;
            // 
            // btnEraser
            // 
            this.btnEraser.FlatAppearance.BorderSize = 0;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnEraser.Image")));
            this.btnEraser.Location = new System.Drawing.Point(195, 76);
            this.btnEraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(18, 18);
            this.btnEraser.TabIndex = 55;
            this.btnEraser.UseVisualStyleBackColor = true;
            // 
            // btnStrikethrough
            // 
            this.btnStrikethrough.FlatAppearance.BorderSize = 0;
            this.btnStrikethrough.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrikethrough.Image = ((System.Drawing.Image)(resources.GetObject("btnStrikethrough.Image")));
            this.btnStrikethrough.Location = new System.Drawing.Point(171, 75);
            this.btnStrikethrough.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStrikethrough.Name = "btnStrikethrough";
            this.btnStrikethrough.Size = new System.Drawing.Size(18, 20);
            this.btnStrikethrough.TabIndex = 55;
            this.btnStrikethrough.UseVisualStyleBackColor = true;
            // 
            // btnUnderline
            // 
            this.btnUnderline.FlatAppearance.BorderSize = 0;
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.Location = new System.Drawing.Point(144, 78);
            this.btnUnderline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(24, 18);
            this.btnUnderline.TabIndex = 55;
            this.btnUnderline.UseVisualStyleBackColor = true;
            // 
            // btnItalic
            // 
            this.btnItalic.FlatAppearance.BorderSize = 0;
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.Location = new System.Drawing.Point(125, 75);
            this.btnItalic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(16, 19);
            this.btnItalic.TabIndex = 55;
            this.btnItalic.UseVisualStyleBackColor = true;
            // 
            // btnBold
            // 
            this.btnBold.FlatAppearance.BorderSize = 0;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.Location = new System.Drawing.Point(96, 76);
            this.btnBold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(27, 18);
            this.btnBold.TabIndex = 55;
            this.btnBold.UseVisualStyleBackColor = true;
            // 
            // btnTypography
            // 
            this.btnTypography.FlatAppearance.BorderSize = 0;
            this.btnTypography.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypography.Image = ((System.Drawing.Image)(resources.GetObject("btnTypography.Image")));
            this.btnTypography.Location = new System.Drawing.Point(72, 76);
            this.btnTypography.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTypography.Name = "btnTypography";
            this.btnTypography.Size = new System.Drawing.Size(26, 19);
            this.btnTypography.TabIndex = 55;
            this.btnTypography.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Image = ((System.Drawing.Image)(resources.GetObject("btnA.Image")));
            this.btnA.Location = new System.Drawing.Point(50, 76);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(26, 16);
            this.btnA.TabIndex = 55;
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnParagraph
            // 
            this.btnParagraph.FlatAppearance.BorderSize = 0;
            this.btnParagraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParagraph.Image = ((System.Drawing.Image)(resources.GetObject("btnParagraph.Image")));
            this.btnParagraph.Location = new System.Drawing.Point(27, 76);
            this.btnParagraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParagraph.Name = "btnParagraph";
            this.btnParagraph.Size = new System.Drawing.Size(25, 18);
            this.btnParagraph.TabIndex = 55;
            this.btnParagraph.UseVisualStyleBackColor = true;
            // 
            // txbInternalnot
            // 
            this.txbInternalnot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbInternalnot.Location = new System.Drawing.Point(26, 74);
            this.txbInternalnot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbInternalnot.Multiline = true;
            this.txbInternalnot.Name = "txbInternalnot";
            this.txbInternalnot.Size = new System.Drawing.Size(436, 192);
            this.txbInternalnot.TabIndex = 55;
            // 
            // sptrInternalnot
            // 
            this.sptrInternalnot.isVertical = false;
            this.sptrInternalnot.Location = new System.Drawing.Point(2, 39);
            this.sptrInternalnot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sptrInternalnot.Name = "sptrInternalnot";
            this.sptrInternalnot.Size = new System.Drawing.Size(486, 10);
            this.sptrInternalnot.TabIndex = 55;
            this.sptrInternalnot.Text = "separators2";
            this.sptrInternalnot.Thickness = 1;
            // 
            // lblInternalnote
            // 
            this.lblInternalnote.AutoSize = true;
            this.lblInternalnote.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternalnote.Location = new System.Drawing.Point(6, 15);
            this.lblInternalnote.Name = "lblInternalnote";
            this.lblInternalnote.Size = new System.Drawing.Size(98, 21);
            this.lblInternalnote.TabIndex = 55;
            this.lblInternalnote.Text = "Internal note";
            // 
            // pnDraft
            // 
            this.pnDraft.BackColor = System.Drawing.Color.White;
            this.pnDraft.BorderColor = System.Drawing.Color.White;
            this.pnDraft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDraft.ColorBottom = System.Drawing.Color.Empty;
            this.pnDraft.ColorTop = System.Drawing.Color.Empty;
            this.pnDraft.Controls.Add(this.cmbCompany);
            this.pnDraft.Controls.Add(this.separators1);
            this.pnDraft.Controls.Add(this.lblDraft);
            this.pnDraft.Controls.Add(this.pnlDraft);
            this.pnDraft.Controls.Add(this.lblCanceled);
            this.pnDraft.Controls.Add(this.pnlCanceled);
            this.pnDraft.Controls.Add(this.lblFinished);
            this.pnDraft.Controls.Add(this.lblValidated);
            this.pnDraft.Controls.Add(this.lblRequested);
            this.pnDraft.Controls.Add(this.pnlFinished);
            this.pnDraft.Controls.Add(this.pnlValidated);
            this.pnDraft.Controls.Add(this.pnlRequested);
            this.pnDraft.Controls.Add(this.pcbTandaseru);
            this.pnDraft.Controls.Add(this.btnTextcurrency);
            this.pnDraft.Controls.Add(this.btnSearchCurrency);
            this.pnDraft.Controls.Add(this.btnPricelist);
            this.pnDraft.Controls.Add(this.lblPricelist);
            this.pnDraft.Controls.Add(this.lblCurrency);
            this.pnDraft.Controls.Add(this.btnSearchSupplier);
            this.pnDraft.Controls.Add(this.lblSupplier);
            this.pnDraft.Controls.Add(this.lblCompany);
            this.pnDraft.Controls.Add(this.cmbSupplier);
            this.pnDraft.Controls.Add(this.sptrSourceuctInf);
            this.pnDraft.Controls.Add(this.chbInATI);
            this.pnDraft.Controls.Add(this.lblInAti);
            this.pnDraft.Controls.Add(this.btnSearchContact);
            this.pnDraft.Controls.Add(this.lblContact);
            this.pnDraft.Controls.Add(this.cmbCurrency);
            this.pnDraft.Controls.Add(this.separators2);
            this.pnDraft.Controls.Add(this.separators3);
            this.pnDraft.Controls.Add(this.cmbPriceList);
            this.pnDraft.Controls.Add(this.cmbContact);
            this.pnDraft.Controls.Add(this.separators4);
            this.pnDraft.Location = new System.Drawing.Point(14, 276);
            this.pnDraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDraft.Name = "pnDraft";
            this.pnDraft.Radius = 20;
            this.pnDraft.Size = new System.Drawing.Size(1071, 308);
            this.pnDraft.TabIndex = 54;
            this.pnDraft.Thickness = 5F;
            // 
            // cmbCompany
            // 
            this.cmbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompany.BackColor = System.Drawing.Color.White;
            this.cmbCompany.BorderColor = System.Drawing.Color.Gray;
            this.cmbCompany.BorderSize = 0;
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCompany.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCompany.IconColor = System.Drawing.Color.DarkGray;
            this.cmbCompany.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCompany.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCompany.Location = new System.Drawing.Point(6, 121);
            this.cmbCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCompany.MinimumSize = new System.Drawing.Size(100, 15);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(244, 40);
            this.cmbCompany.TabIndex = 435;
            this.cmbCompany.Texts = "";
            // 
            // separators1
            // 
            this.separators1.BackColor = System.Drawing.Color.White;
            this.separators1.ForeColor = System.Drawing.Color.Silver;
            this.separators1.isVertical = false;
            this.separators1.Location = new System.Drawing.Point(6, 156);
            this.separators1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separators1.Name = "separators1";
            this.separators1.Size = new System.Drawing.Size(245, 22);
            this.separators1.TabIndex = 434;
            this.separators1.Thickness = 1;
            // 
            // lblDraft
            // 
            this.lblDraft.AutoSize = true;
            this.lblDraft.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDraft.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraft.Location = new System.Drawing.Point(37, 35);
            this.lblDraft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDraft.Name = "lblDraft";
            this.lblDraft.Size = new System.Drawing.Size(43, 20);
            this.lblDraft.TabIndex = 430;
            this.lblDraft.Text = "Draft";
            // 
            // pnlDraft
            // 
            this.pnlDraft.ArrowColor = System.Drawing.Color.RoyalBlue;
            this.pnlDraft.BorderColor = System.Drawing.Color.Transparent;
            this.pnlDraft.Location = new System.Drawing.Point(12, 15);
            this.pnlDraft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDraft.MinimumSize = new System.Drawing.Size(45, 25);
            this.pnlDraft.Name = "pnlDraft";
            this.pnlDraft.Size = new System.Drawing.Size(96, 64);
            this.pnlDraft.TabIndex = 429;
            this.pnlDraft.Text = "arrowPentagon1";
            // 
            // lblCanceled
            // 
            this.lblCanceled.AutoSize = true;
            this.lblCanceled.BackColor = System.Drawing.Color.DarkGray;
            this.lblCanceled.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanceled.Location = new System.Drawing.Point(385, 35);
            this.lblCanceled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanceled.Name = "lblCanceled";
            this.lblCanceled.Size = new System.Drawing.Size(70, 20);
            this.lblCanceled.TabIndex = 428;
            this.lblCanceled.Text = "Canceled";
            // 
            // pnlCanceled
            // 
            this.pnlCanceled.ArrowColor = System.Drawing.Color.DarkGray;
            this.pnlCanceled.BorderColor = System.Drawing.Color.Transparent;
            this.pnlCanceled.Location = new System.Drawing.Point(354, 15);
            this.pnlCanceled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCanceled.MinimumSize = new System.Drawing.Size(45, 25);
            this.pnlCanceled.Name = "pnlCanceled";
            this.pnlCanceled.Size = new System.Drawing.Size(114, 64);
            this.pnlCanceled.TabIndex = 423;
            this.pnlCanceled.Text = "arrowChevron7";
            // 
            // lblFinished
            // 
            this.lblFinished.AutoSize = true;
            this.lblFinished.BackColor = System.Drawing.Color.DarkGray;
            this.lblFinished.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinished.Location = new System.Drawing.Point(306, 35);
            this.lblFinished.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(63, 20);
            this.lblFinished.TabIndex = 427;
            this.lblFinished.Text = "Finished";
            // 
            // lblValidated
            // 
            this.lblValidated.AutoSize = true;
            this.lblValidated.BackColor = System.Drawing.Color.DarkGray;
            this.lblValidated.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidated.Location = new System.Drawing.Point(216, 35);
            this.lblValidated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidated.Name = "lblValidated";
            this.lblValidated.Size = new System.Drawing.Size(72, 20);
            this.lblValidated.TabIndex = 426;
            this.lblValidated.Text = "Validated";
            // 
            // lblRequested
            // 
            this.lblRequested.AutoSize = true;
            this.lblRequested.BackColor = System.Drawing.Color.DarkGray;
            this.lblRequested.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequested.Location = new System.Drawing.Point(118, 35);
            this.lblRequested.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequested.Name = "lblRequested";
            this.lblRequested.Size = new System.Drawing.Size(79, 20);
            this.lblRequested.TabIndex = 425;
            this.lblRequested.Text = "Requested";
            // 
            // pnlFinished
            // 
            this.pnlFinished.ArrowColor = System.Drawing.Color.DarkGray;
            this.pnlFinished.BorderColor = System.Drawing.Color.Transparent;
            this.pnlFinished.Location = new System.Drawing.Point(276, 15);
            this.pnlFinished.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFinished.MinimumSize = new System.Drawing.Size(45, 25);
            this.pnlFinished.Name = "pnlFinished";
            this.pnlFinished.Size = new System.Drawing.Size(101, 64);
            this.pnlFinished.TabIndex = 422;
            this.pnlFinished.Text = "arrowChevron6";
            // 
            // pnlValidated
            // 
            this.pnlValidated.ArrowColor = System.Drawing.Color.DarkGray;
            this.pnlValidated.BorderColor = System.Drawing.Color.Transparent;
            this.pnlValidated.Location = new System.Drawing.Point(184, 15);
            this.pnlValidated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlValidated.MinimumSize = new System.Drawing.Size(45, 25);
            this.pnlValidated.Name = "pnlValidated";
            this.pnlValidated.Size = new System.Drawing.Size(115, 64);
            this.pnlValidated.TabIndex = 421;
            this.pnlValidated.Text = "arrowChevron3";
            // 
            // pnlRequested
            // 
            this.pnlRequested.ArrowColor = System.Drawing.Color.DarkGray;
            this.pnlRequested.BorderColor = System.Drawing.Color.Transparent;
            this.pnlRequested.Location = new System.Drawing.Point(88, 15);
            this.pnlRequested.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRequested.MinimumSize = new System.Drawing.Size(45, 25);
            this.pnlRequested.Name = "pnlRequested";
            this.pnlRequested.Size = new System.Drawing.Size(123, 64);
            this.pnlRequested.TabIndex = 420;
            this.pnlRequested.Text = "arrowChevron2";
            // 
            // pcbTandaseru
            // 
            this.pcbTandaseru.Image = ((System.Drawing.Image)(resources.GetObject("pcbTandaseru.Image")));
            this.pcbTandaseru.Location = new System.Drawing.Point(939, 84);
            this.pcbTandaseru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbTandaseru.Name = "pcbTandaseru";
            this.pcbTandaseru.Size = new System.Drawing.Size(18, 20);
            this.pcbTandaseru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbTandaseru.TabIndex = 128;
            this.pcbTandaseru.TabStop = false;
            // 
            // btnTextcurrency
            // 
            this.btnTextcurrency.FlatAppearance.BorderSize = 0;
            this.btnTextcurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextcurrency.Image = ((System.Drawing.Image)(resources.GetObject("btnTextcurrency.Image")));
            this.btnTextcurrency.Location = new System.Drawing.Point(764, 134);
            this.btnTextcurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextcurrency.Name = "btnTextcurrency";
            this.btnTextcurrency.Size = new System.Drawing.Size(29, 31);
            this.btnTextcurrency.TabIndex = 54;
            this.btnTextcurrency.UseVisualStyleBackColor = true;
            // 
            // btnSearchCurrency
            // 
            this.btnSearchCurrency.FlatAppearance.BorderSize = 0;
            this.btnSearchCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCurrency.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCurrency.Image")));
            this.btnSearchCurrency.Location = new System.Drawing.Point(799, 134);
            this.btnSearchCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCurrency.Name = "btnSearchCurrency";
            this.btnSearchCurrency.Size = new System.Drawing.Size(26, 28);
            this.btnSearchCurrency.TabIndex = 58;
            this.btnSearchCurrency.UseVisualStyleBackColor = true;
            // 
            // btnPricelist
            // 
            this.btnPricelist.FlatAppearance.BorderSize = 0;
            this.btnPricelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPricelist.Image = ((System.Drawing.Image)(resources.GetObject("btnPricelist.Image")));
            this.btnPricelist.Location = new System.Drawing.Point(1012, 132);
            this.btnPricelist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPricelist.Name = "btnPricelist";
            this.btnPricelist.Size = new System.Drawing.Size(40, 32);
            this.btnPricelist.TabIndex = 61;
            this.btnPricelist.UseVisualStyleBackColor = true;
            // 
            // lblPricelist
            // 
            this.lblPricelist.AutoSize = true;
            this.lblPricelist.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricelist.Location = new System.Drawing.Point(875, 95);
            this.lblPricelist.Name = "lblPricelist";
            this.lblPricelist.Size = new System.Drawing.Size(68, 21);
            this.lblPricelist.TabIndex = 59;
            this.lblPricelist.Text = "Price list";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(575, 95);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(73, 21);
            this.lblCurrency.TabIndex = 56;
            this.lblCurrency.Text = "Currency";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.FlatAppearance.BorderSize = 0;
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchSupplier.Image")));
            this.btnSearchSupplier.Location = new System.Drawing.Point(511, 132);
            this.btnSearchSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(40, 32);
            this.btnSearchSupplier.TabIndex = 49;
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(303, 95);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(68, 21);
            this.lblSupplier.TabIndex = 54;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(1, 95);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(77, 21);
            this.lblCompany.TabIndex = 51;
            this.lblCompany.Text = "Company";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.White;
            this.cmbSupplier.BorderColor = System.Drawing.Color.Gray;
            this.cmbSupplier.BorderSize = 0;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSupplier.IconColor = System.Drawing.Color.Transparent;
            this.cmbSupplier.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSupplier.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSupplier.Location = new System.Drawing.Point(307, 128);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSupplier.MinimumSize = new System.Drawing.Size(100, 15);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(244, 40);
            this.cmbSupplier.TabIndex = 431;
            this.cmbSupplier.Texts = "";
            this.cmbSupplier.OnSelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // sptrSourceuctInf
            // 
            this.sptrSourceuctInf.BackColor = System.Drawing.Color.White;
            this.sptrSourceuctInf.ForeColor = System.Drawing.Color.Silver;
            this.sptrSourceuctInf.isVertical = false;
            this.sptrSourceuctInf.Location = new System.Drawing.Point(307, 156);
            this.sptrSourceuctInf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sptrSourceuctInf.Name = "sptrSourceuctInf";
            this.sptrSourceuctInf.Size = new System.Drawing.Size(245, 22);
            this.sptrSourceuctInf.TabIndex = 432;
            this.sptrSourceuctInf.Thickness = 1;
            // 
            // chbInATI
            // 
            this.chbInATI.AutoSize = true;
            this.chbInATI.Location = new System.Drawing.Point(381, 248);
            this.chbInATI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbInATI.Name = "chbInATI";
            this.chbInATI.Size = new System.Drawing.Size(22, 21);
            this.chbInATI.TabIndex = 54;
            this.chbInATI.UseVisualStyleBackColor = true;
            this.chbInATI.CheckedChanged += new System.EventHandler(this.chbInATI_CheckedChanged);
            // 
            // lblInAti
            // 
            this.lblInAti.AutoSize = true;
            this.lblInAti.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInAti.Location = new System.Drawing.Point(370, 226);
            this.lblInAti.Name = "lblInAti";
            this.lblInAti.Size = new System.Drawing.Size(44, 19);
            this.lblInAti.TabIndex = 64;
            this.lblInAti.Text = "In ATI";
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.FlatAppearance.BorderSize = 0;
            this.btnSearchContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchContact.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchContact.Image")));
            this.btnSearchContact.Location = new System.Drawing.Point(307, 218);
            this.btnSearchContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(40, 32);
            this.btnSearchContact.TabIndex = 63;
            this.btnSearchContact.UseVisualStyleBackColor = true;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(1, 182);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 21);
            this.lblContact.TabIndex = 62;
            this.lblContact.Text = "Contact";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.BackColor = System.Drawing.Color.White;
            this.cmbCurrency.BorderColor = System.Drawing.Color.Gray;
            this.cmbCurrency.BorderSize = 0;
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCurrency.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCurrency.IconColor = System.Drawing.Color.Transparent;
            this.cmbCurrency.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCurrency.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCurrency.Location = new System.Drawing.Point(579, 125);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCurrency.MinimumSize = new System.Drawing.Size(100, 15);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(244, 40);
            this.cmbCurrency.TabIndex = 436;
            this.cmbCurrency.Texts = "";
            // 
            // separators2
            // 
            this.separators2.BackColor = System.Drawing.Color.White;
            this.separators2.ForeColor = System.Drawing.Color.Silver;
            this.separators2.isVertical = false;
            this.separators2.Location = new System.Drawing.Point(579, 154);
            this.separators2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separators2.Name = "separators2";
            this.separators2.Size = new System.Drawing.Size(245, 22);
            this.separators2.TabIndex = 437;
            this.separators2.Thickness = 1;
            // 
            // separators3
            // 
            this.separators3.BackColor = System.Drawing.Color.White;
            this.separators3.ForeColor = System.Drawing.Color.Silver;
            this.separators3.isVertical = false;
            this.separators3.Location = new System.Drawing.Point(880, 154);
            this.separators3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separators3.Name = "separators3";
            this.separators3.Size = new System.Drawing.Size(174, 22);
            this.separators3.TabIndex = 439;
            this.separators3.Thickness = 1;
            // 
            // cmbPriceList
            // 
            this.cmbPriceList.BackColor = System.Drawing.Color.White;
            this.cmbPriceList.BorderColor = System.Drawing.Color.Gray;
            this.cmbPriceList.BorderSize = 0;
            this.cmbPriceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPriceList.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPriceList.IconColor = System.Drawing.Color.Transparent;
            this.cmbPriceList.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPriceList.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPriceList.Location = new System.Drawing.Point(880, 125);
            this.cmbPriceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPriceList.MinimumSize = new System.Drawing.Size(100, 15);
            this.cmbPriceList.Name = "cmbPriceList";
            this.cmbPriceList.Size = new System.Drawing.Size(173, 40);
            this.cmbPriceList.TabIndex = 438;
            this.cmbPriceList.Texts = "";
            // 
            // cmbContact
            // 
            this.cmbContact.BackColor = System.Drawing.Color.White;
            this.cmbContact.BorderColor = System.Drawing.Color.Gray;
            this.cmbContact.BorderSize = 0;
            this.cmbContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbContact.ForeColor = System.Drawing.Color.DimGray;
            this.cmbContact.IconColor = System.Drawing.Color.Transparent;
            this.cmbContact.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbContact.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbContact.Location = new System.Drawing.Point(12, 218);
            this.cmbContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbContact.MinimumSize = new System.Drawing.Size(100, 15);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(335, 40);
            this.cmbContact.TabIndex = 440;
            this.cmbContact.Texts = "";
            // 
            // separators4
            // 
            this.separators4.BackColor = System.Drawing.Color.White;
            this.separators4.ForeColor = System.Drawing.Color.Silver;
            this.separators4.isVertical = false;
            this.separators4.Location = new System.Drawing.Point(12, 246);
            this.separators4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separators4.Name = "separators4";
            this.separators4.Size = new System.Drawing.Size(336, 22);
            this.separators4.TabIndex = 441;
            this.separators4.Thickness = 1;
            // 
            // pnPurchOrde
            // 
            this.pnPurchOrde.BackColor = System.Drawing.Color.White;
            this.pnPurchOrde.BorderColor = System.Drawing.Color.White;
            this.pnPurchOrde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnPurchOrde.ColorBottom = System.Drawing.Color.Empty;
            this.pnPurchOrde.ColorTop = System.Drawing.Color.Empty;
            this.pnPurchOrde.Controls.Add(this.btnGsrKanan);
            this.pnPurchOrde.Controls.Add(this.btnExcelPurchorder);
            this.pnPurchOrde.Controls.Add(this.btnGsrKiri);
            this.pnPurchOrde.Controls.Add(this.btnSearchpurchorde);
            this.pnPurchOrde.Controls.Add(this.txbNumberPurchorder);
            this.pnPurchOrde.Controls.Add(this.btnRefreshPurchorder);
            this.pnPurchOrde.Controls.Add(this.txbSearchPurchOrder);
            this.pnPurchOrde.Controls.Add(this.btnEditPurchorder);
            this.pnPurchOrde.Controls.Add(this.btnPlusPurchord);
            this.pnPurchOrde.Location = new System.Drawing.Point(14, 20);
            this.pnPurchOrde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPurchOrde.Name = "pnPurchOrde";
            this.pnPurchOrde.Radius = 20;
            this.pnPurchOrde.Size = new System.Drawing.Size(1583, 51);
            this.pnPurchOrde.TabIndex = 0;
            this.pnPurchOrde.Thickness = 5F;
            // 
            // btnGsrKanan
            // 
            this.btnGsrKanan.FlatAppearance.BorderSize = 0;
            this.btnGsrKanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGsrKanan.Image = ((System.Drawing.Image)(resources.GetObject("btnGsrKanan.Image")));
            this.btnGsrKanan.Location = new System.Drawing.Point(1554, 12);
            this.btnGsrKanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGsrKanan.Name = "btnGsrKanan";
            this.btnGsrKanan.Size = new System.Drawing.Size(29, 22);
            this.btnGsrKanan.TabIndex = 24;
            this.btnGsrKanan.UseVisualStyleBackColor = true;
            // 
            // btnExcelPurchorder
            // 
            this.btnExcelPurchorder.FlatAppearance.BorderSize = 0;
            this.btnExcelPurchorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelPurchorder.Image = global::REMAS.Properties.Resources.Excel_App;
            this.btnExcelPurchorder.Location = new System.Drawing.Point(436, 5);
            this.btnExcelPurchorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcelPurchorder.Name = "btnExcelPurchorder";
            this.btnExcelPurchorder.Size = new System.Drawing.Size(40, 39);
            this.btnExcelPurchorder.TabIndex = 2;
            this.btnExcelPurchorder.UseVisualStyleBackColor = true;
            // 
            // btnGsrKiri
            // 
            this.btnGsrKiri.FlatAppearance.BorderSize = 0;
            this.btnGsrKiri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGsrKiri.Image = ((System.Drawing.Image)(resources.GetObject("btnGsrKiri.Image")));
            this.btnGsrKiri.Location = new System.Drawing.Point(1529, 12);
            this.btnGsrKiri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGsrKiri.Name = "btnGsrKiri";
            this.btnGsrKiri.Size = new System.Drawing.Size(26, 22);
            this.btnGsrKiri.TabIndex = 23;
            this.btnGsrKiri.UseVisualStyleBackColor = true;
            // 
            // btnSearchpurchorde
            // 
            this.btnSearchpurchorde.FlatAppearance.BorderSize = 0;
            this.btnSearchpurchorde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchpurchorde.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchpurchorde.Image")));
            this.btnSearchpurchorde.Location = new System.Drawing.Point(252, 8);
            this.btnSearchpurchorde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchpurchorde.Name = "btnSearchpurchorde";
            this.btnSearchpurchorde.Size = new System.Drawing.Size(40, 32);
            this.btnSearchpurchorde.TabIndex = 3;
            this.btnSearchpurchorde.UseVisualStyleBackColor = true;
            // 
            // txbNumberPurchorder
            // 
            this.txbNumberPurchorder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNumberPurchorder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumberPurchorder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbNumberPurchorder.Location = new System.Drawing.Point(1395, 11);
            this.txbNumberPurchorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNumberPurchorder.Multiline = true;
            this.txbNumberPurchorder.Name = "txbNumberPurchorder";
            this.txbNumberPurchorder.Size = new System.Drawing.Size(135, 28);
            this.txbNumberPurchorder.TabIndex = 22;
            this.txbNumberPurchorder.Text = "    1 to 5 of 5";
            // 
            // btnRefreshPurchorder
            // 
            this.btnRefreshPurchorder.FlatAppearance.BorderSize = 0;
            this.btnRefreshPurchorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPurchorder.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.btnRefreshPurchorder.Location = new System.Drawing.Point(399, 9);
            this.btnRefreshPurchorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshPurchorder.Name = "btnRefreshPurchorder";
            this.btnRefreshPurchorder.Size = new System.Drawing.Size(38, 32);
            this.btnRefreshPurchorder.TabIndex = 3;
            this.btnRefreshPurchorder.UseVisualStyleBackColor = true;
            // 
            // txbSearchPurchOrder
            // 
            this.txbSearchPurchOrder.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearchPurchOrder.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txbSearchPurchOrder.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbSearchPurchOrder.BorderRadius = 0;
            this.txbSearchPurchOrder.BorderSize = 1;
            this.txbSearchPurchOrder.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearchPurchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchPurchOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearchPurchOrder.Location = new System.Drawing.Point(22, 1);
            this.txbSearchPurchOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbSearchPurchOrder.MaxLength = 250;
            this.txbSearchPurchOrder.Multiline = false;
            this.txbSearchPurchOrder.Name = "txbSearchPurchOrder";
            this.txbSearchPurchOrder.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbSearchPurchOrder.PasswordChar = false;
            this.txbSearchPurchOrder.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchPurchOrder.PlaceholderText = "Search";
            this.txbSearchPurchOrder.ReadOnly = false;
            this.txbSearchPurchOrder.Size = new System.Drawing.Size(271, 44);
            this.txbSearchPurchOrder.TabIndex = 49;
            this.txbSearchPurchOrder.Texts = "";
            this.txbSearchPurchOrder.UnderlinedStyle = true;
            // 
            // btnEditPurchorder
            // 
            this.btnEditPurchorder.FlatAppearance.BorderSize = 0;
            this.btnEditPurchorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPurchorder.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPurchorder.Image")));
            this.btnEditPurchorder.Location = new System.Drawing.Point(363, 12);
            this.btnEditPurchorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPurchorder.Name = "btnEditPurchorder";
            this.btnEditPurchorder.Size = new System.Drawing.Size(32, 25);
            this.btnEditPurchorder.TabIndex = 4;
            this.btnEditPurchorder.UseVisualStyleBackColor = true;
            // 
            // btnPlusPurchord
            // 
            this.btnPlusPurchord.FlatAppearance.BorderSize = 0;
            this.btnPlusPurchord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusPurchord.Image = global::REMAS.Properties.Resources.PlusLg;
            this.btnPlusPurchord.Location = new System.Drawing.Point(316, 12);
            this.btnPlusPurchord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlusPurchord.Name = "btnPlusPurchord";
            this.btnPlusPurchord.Size = new System.Drawing.Size(46, 28);
            this.btnPlusPurchord.TabIndex = 5;
            this.btnPlusPurchord.UseVisualStyleBackColor = true;
            // 
            // pnlRequestClose
            // 
            this.pnlRequestClose.BackColor = System.Drawing.Color.White;
            this.pnlRequestClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRequestClose.Controls.Add(this.btnRequest);
            this.pnlRequestClose.Controls.Add(this.btnValidated);
            this.pnlRequestClose.Controls.Add(this.btnCancel);
            this.pnlRequestClose.Controls.Add(this.btnDraft);
            this.pnlRequestClose.Controls.Add(this.btnFinished);
            this.pnlRequestClose.Location = new System.Drawing.Point(14, 609);
            this.pnlRequestClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRequestClose.Name = "pnlRequestClose";
            this.pnlRequestClose.Size = new System.Drawing.Size(292, 135);
            this.pnlRequestClose.TabIndex = 71;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Image = global::REMAS.Properties.Resources.megaphone__3_;
            this.btnRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequest.Location = new System.Drawing.Point(21, 20);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(252, 45);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "  Request";
            this.btnRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnValidated
            // 
            this.btnValidated.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnValidated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidated.FlatAppearance.BorderSize = 0;
            this.btnValidated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidated.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidated.ForeColor = System.Drawing.Color.White;
            this.btnValidated.Location = new System.Drawing.Point(21, 20);
            this.btnValidated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValidated.Name = "btnValidated";
            this.btnValidated.Size = new System.Drawing.Size(252, 45);
            this.btnValidated.TabIndex = 4;
            this.btnValidated.Text = "Validated";
            this.btnValidated.UseVisualStyleBackColor = false;
            this.btnValidated.Click += new System.EventHandler(this.btnValidated_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::REMAS.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(21, 72);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(252, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDraft
            // 
            this.btnDraft.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDraft.FlatAppearance.BorderSize = 0;
            this.btnDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraft.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraft.ForeColor = System.Drawing.Color.White;
            this.btnDraft.Location = new System.Drawing.Point(21, 20);
            this.btnDraft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(252, 45);
            this.btnDraft.TabIndex = 4;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = false;
            this.btnDraft.Click += new System.EventHandler(this.btnDraft_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFinished.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinished.FlatAppearance.BorderSize = 0;
            this.btnFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinished.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinished.ForeColor = System.Drawing.Color.White;
            this.btnFinished.Location = new System.Drawing.Point(21, 20);
            this.btnFinished.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(252, 45);
            this.btnFinished.TabIndex = 4;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = false;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // frmPurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1616, 791);
            this.Controls.Add(this.pnlRequestClose);
            this.Controls.Add(this.pnInternalnot);
            this.Controls.Add(this.pnDraft);
            this.Controls.Add(this.dgvPurchorder);
            this.Controls.Add(this.pnPurchOrde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPurchaseOrders";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPurchaseOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchorder)).EndInit();
            this.pnInternalnot.ResumeLayout(false);
            this.pnInternalnot.PerformLayout();
            this.pnDraft.ResumeLayout(false);
            this.pnDraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTandaseru)).EndInit();
            this.pnPurchOrde.ResumeLayout(false);
            this.pnPurchOrde.PerformLayout();
            this.pnlRequestClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Contoller.CustomPanel pnPurchOrde;
        private Contoller.RJTextBox txbSearchPurchOrder;
        private System.Windows.Forms.Button btnSearchpurchorde;
        private System.Windows.Forms.Button btnExcelPurchorder;
        private System.Windows.Forms.Button btnRefreshPurchorder;
        private System.Windows.Forms.Button btnEditPurchorder;
        private System.Windows.Forms.Button btnPlusPurchord;
        private System.Windows.Forms.Button btnGsrKanan;
        private System.Windows.Forms.Button btnGsrKiri;
        private System.Windows.Forms.TextBox txbNumberPurchorder;
        private System.Windows.Forms.DataGridView dgvPurchorder;
        private Contoller.CustomPanel pnDraft;
        private System.Windows.Forms.CheckBox chbInATI;
        private System.Windows.Forms.Label lblInAti;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.Button btnTextcurrency;
        private System.Windows.Forms.Button btnSearchCurrency;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Button btnPricelist;
        private System.Windows.Forms.Label lblPricelist;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblCompany;
        private Contoller.CustomPanel pnInternalnot;
        private System.Windows.Forms.Button btnRatakanan;
        private System.Windows.Forms.Button btnRataKiri;
        private System.Windows.Forms.Button btnWaterdrop;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnStrikethrough;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnTypography;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnParagraph;
        private System.Windows.Forms.TextBox txbInternalnot;
        private Contoller.Separators sptrInternalnot;
        private System.Windows.Forms.Label lblInternalnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column7;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column8;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column9;
        private Contoller.RJTextBox txbGarisInternal;
        private System.Windows.Forms.PictureBox pcbTandaseru;
        private System.Windows.Forms.Label lblCanceled;
        private shape.ArrowChevron pnlCanceled;
        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.Label lblValidated;
        private System.Windows.Forms.Label lblRequested;
        private shape.ArrowChevron pnlFinished;
        private shape.ArrowChevron pnlValidated;
        private shape.ArrowChevron pnlRequested;
        private System.Windows.Forms.Label lblDraft;
        private shape.ArrowPentagon pnlDraft;
        public Contoller.RJComboBox cmbSupplier;
        private Contoller.Separators sptrSourceuctInf;
        private Contoller.Separators separators1;
        public Contoller.RJComboBox cmbCompany;
        public Contoller.RJComboBox cmbCurrency;
        private Contoller.Separators separators2;
        private Contoller.Separators separators3;
        public Contoller.RJComboBox cmbPriceList;
        public Contoller.RJComboBox cmbContact;
        private Contoller.Separators separators4;
        private Contoller.UPanel pnlRequestClose;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnValidated;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.Button btnFinished;
    }
}