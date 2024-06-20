namespace REMAS.Forms.Purchasing
{
    partial class uctSuppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctSuppliers));
            this.label_PurchaseOI = new System.Windows.Forms.Label();
            this.textBox1_Supplier = new System.Windows.Forms.TextBox();
            this.label_PaymentC = new System.Windows.Forms.Label();
            this.textBox2_Supplier = new System.Windows.Forms.TextBox();
            this.label_InPaymentM = new System.Windows.Forms.Label();
            this.label_InpaymentM2 = new System.Windows.Forms.Label();
            this.SearchSideTextBox_Supplier = new System.Windows.Forms.TextBox();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.label_diSupplier = new System.Windows.Forms.Label();
            this.dataGridView_SupplierPchse = new System.Windows.Forms.DataGridView();
            this.sptPaymentCondition = new REMAS.Contoller.Separators();
            this.sptInPaymentMode = new REMAS.Contoller.Separators();
            this.sptPaymentMode = new REMAS.Contoller.Separators();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlus1uctDel = new System.Windows.Forms.Button();
            this.lblNew2uctDel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupplierPchse)).BeginInit();
            this.SuspendLayout();
            // 
            // label_PurchaseOI
            // 
            this.label_PurchaseOI.AutoSize = true;
            this.label_PurchaseOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PurchaseOI.Location = new System.Drawing.Point(20, 23);
            this.label_PurchaseOI.Name = "label_PurchaseOI";
            this.label_PurchaseOI.Size = new System.Drawing.Size(252, 22);
            this.label_PurchaseOI.TabIndex = 73;
            this.label_PurchaseOI.Text = "Purchase order information";
            // 
            // textBox1_Supplier
            // 
            this.textBox1_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_Supplier.Location = new System.Drawing.Point(24, 49);
            this.textBox1_Supplier.Multiline = true;
            this.textBox1_Supplier.Name = "textBox1_Supplier";
            this.textBox1_Supplier.Size = new System.Drawing.Size(624, 207);
            this.textBox1_Supplier.TabIndex = 74;
            // 
            // label_PaymentC
            // 
            this.label_PaymentC.AutoSize = true;
            this.label_PaymentC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PaymentC.Location = new System.Drawing.Point(732, 23);
            this.label_PaymentC.Name = "label_PaymentC";
            this.label_PaymentC.Size = new System.Drawing.Size(178, 22);
            this.label_PaymentC.TabIndex = 76;
            this.label_PaymentC.Text = "Payment Condition";
            // 
            // textBox2_Supplier
            // 
            this.textBox2_Supplier.BackColor = System.Drawing.Color.White;
            this.textBox2_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_Supplier.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2_Supplier.Location = new System.Drawing.Point(736, 49);
            this.textBox2_Supplier.Name = "textBox2_Supplier";
            this.textBox2_Supplier.Size = new System.Drawing.Size(452, 23);
            this.textBox2_Supplier.TabIndex = 77;
            // 
            // label_InPaymentM
            // 
            this.label_InPaymentM.AutoSize = true;
            this.label_InPaymentM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InPaymentM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_InPaymentM.Location = new System.Drawing.Point(20, 289);
            this.label_InPaymentM.Name = "label_InPaymentM";
            this.label_InPaymentM.Size = new System.Drawing.Size(163, 22);
            this.label_InPaymentM.TabIndex = 80;
            this.label_InPaymentM.Text = "In Payment Mode";
            // 
            // label_InpaymentM2
            // 
            this.label_InpaymentM2.AutoSize = true;
            this.label_InpaymentM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InpaymentM2.Location = new System.Drawing.Point(378, 289);
            this.label_InpaymentM2.Name = "label_InpaymentM2";
            this.label_InpaymentM2.Size = new System.Drawing.Size(163, 22);
            this.label_InpaymentM2.TabIndex = 84;
            this.label_InpaymentM2.Text = "In Payment Mode";
            // 
            // SearchSideTextBox_Supplier
            // 
            this.SearchSideTextBox_Supplier.BackColor = System.Drawing.SystemColors.Window;
            this.SearchSideTextBox_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchSideTextBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSideTextBox_Supplier.ForeColor = System.Drawing.Color.Silver;
            this.SearchSideTextBox_Supplier.Location = new System.Drawing.Point(24, 315);
            this.SearchSideTextBox_Supplier.Name = "SearchSideTextBox_Supplier";
            this.SearchSideTextBox_Supplier.Size = new System.Drawing.Size(290, 19);
            this.SearchSideTextBox_Supplier.TabIndex = 85;
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Supplier.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Supplier.Location = new System.Drawing.Point(382, 315);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(290, 19);
            this.textBox_Supplier.TabIndex = 86;
            // 
            // label_diSupplier
            // 
            this.label_diSupplier.AutoSize = true;
            this.label_diSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diSupplier.Location = new System.Drawing.Point(20, 366);
            this.label_diSupplier.Name = "label_diSupplier";
            this.label_diSupplier.Size = new System.Drawing.Size(252, 22);
            this.label_diSupplier.TabIndex = 89;
            this.label_diSupplier.Text = "Purchase order information";
            // 
            // dataGridView_SupplierPchse
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_SupplierPchse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_SupplierPchse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SupplierPchse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductColumn,
            this.QualityColumn,
            this.ArrivalColumn});
            this.dataGridView_SupplierPchse.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_SupplierPchse.Location = new System.Drawing.Point(24, 417);
            this.dataGridView_SupplierPchse.Name = "dataGridView_SupplierPchse";
            this.dataGridView_SupplierPchse.RowHeadersWidth = 62;
            this.dataGridView_SupplierPchse.RowTemplate.Height = 28;
            this.dataGridView_SupplierPchse.Size = new System.Drawing.Size(1164, 80);
            this.dataGridView_SupplierPchse.TabIndex = 91;
            // 
            // sptPaymentCondition
            // 
            this.sptPaymentCondition.isVertical = false;
            this.sptPaymentCondition.Location = new System.Drawing.Point(736, 68);
            this.sptPaymentCondition.Name = "sptPaymentCondition";
            this.sptPaymentCondition.Size = new System.Drawing.Size(452, 23);
            this.sptPaymentCondition.TabIndex = 94;
            this.sptPaymentCondition.Thickness = 1;
            // 
            // sptInPaymentMode
            // 
            this.sptInPaymentMode.isVertical = false;
            this.sptInPaymentMode.Location = new System.Drawing.Point(24, 330);
            this.sptInPaymentMode.Name = "sptInPaymentMode";
            this.sptInPaymentMode.Size = new System.Drawing.Size(290, 23);
            this.sptInPaymentMode.TabIndex = 95;
            this.sptInPaymentMode.Text = "separators2";
            this.sptInPaymentMode.Thickness = 1;
            // 
            // sptPaymentMode
            // 
            this.sptPaymentMode.isVertical = false;
            this.sptPaymentMode.Location = new System.Drawing.Point(382, 330);
            this.sptPaymentMode.Name = "sptPaymentMode";
            this.sptPaymentMode.Size = new System.Drawing.Size(290, 23);
            this.sptPaymentMode.TabIndex = 96;
            this.sptPaymentMode.Text = "separators3";
            this.sptPaymentMode.Thickness = 1;
            // 
            // ProductColumn
            // 
            this.ProductColumn.HeaderText = "Product";
            this.ProductColumn.MinimumWidth = 8;
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.Width = 370;
            // 
            // QualityColumn
            // 
            this.QualityColumn.HeaderText = "Quality rating";
            this.QualityColumn.MinimumWidth = 8;
            this.QualityColumn.Name = "QualityColumn";
            this.QualityColumn.Width = 360;
            // 
            // ArrivalColumn
            // 
            this.ArrivalColumn.HeaderText = "Arrival product quantity";
            this.ArrivalColumn.MinimumWidth = 8;
            this.ArrivalColumn.Name = "ArrivalColumn";
            this.ArrivalColumn.Width = 370;
            // 
            // btnPlus1uctDel
            // 
            this.btnPlus1uctDel.BackColor = System.Drawing.Color.White;
            this.btnPlus1uctDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlus1uctDel.FlatAppearance.BorderSize = 0;
            this.btnPlus1uctDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus1uctDel.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus1uctDel.Image")));
            this.btnPlus1uctDel.Location = new System.Drawing.Point(1107, 378);
            this.btnPlus1uctDel.Name = "btnPlus1uctDel";
            this.btnPlus1uctDel.Size = new System.Drawing.Size(32, 32);
            this.btnPlus1uctDel.TabIndex = 256;
            this.btnPlus1uctDel.UseVisualStyleBackColor = false;
            this.btnPlus1uctDel.Click += new System.EventHandler(this.btnPlus1uctDel_Click);
            // 
            // lblNew2uctDel
            // 
            this.lblNew2uctDel.AutoSize = true;
            this.lblNew2uctDel.BackColor = System.Drawing.Color.White;
            this.lblNew2uctDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew2uctDel.Location = new System.Drawing.Point(1142, 385);
            this.lblNew2uctDel.Name = "lblNew2uctDel";
            this.lblNew2uctDel.Size = new System.Drawing.Size(40, 20);
            this.lblNew2uctDel.TabIndex = 257;
            this.lblNew2uctDel.Text = "New";
            // 
            // uctSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNew2uctDel);
            this.Controls.Add(this.btnPlus1uctDel);
            this.Controls.Add(this.sptPaymentMode);
            this.Controls.Add(this.dataGridView_SupplierPchse);
            this.Controls.Add(this.label_diSupplier);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.SearchSideTextBox_Supplier);
            this.Controls.Add(this.label_InpaymentM2);
            this.Controls.Add(this.label_InPaymentM);
            this.Controls.Add(this.textBox2_Supplier);
            this.Controls.Add(this.label_PaymentC);
            this.Controls.Add(this.textBox1_Supplier);
            this.Controls.Add(this.label_PurchaseOI);
            this.Controls.Add(this.sptPaymentCondition);
            this.Controls.Add(this.sptInPaymentMode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uctSuppliers";
            this.Size = new System.Drawing.Size(1200, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupplierPchse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PurchaseOI;
        private System.Windows.Forms.TextBox textBox1_Supplier;
        private System.Windows.Forms.Label label_PaymentC;
        private System.Windows.Forms.TextBox textBox2_Supplier;
        private System.Windows.Forms.Label label_InPaymentM;
        private System.Windows.Forms.Label label_InpaymentM2;
        private System.Windows.Forms.TextBox SearchSideTextBox_Supplier;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.Label label_diSupplier;
        private System.Windows.Forms.DataGridView dataGridView_SupplierPchse;
        private Contoller.Separators sptPaymentCondition;
        private Contoller.Separators sptInPaymentMode;
        private Contoller.Separators sptPaymentMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalColumn;
        private System.Windows.Forms.Button btnPlus1uctDel;
        private System.Windows.Forms.Label lblNew2uctDel;
    }
}
