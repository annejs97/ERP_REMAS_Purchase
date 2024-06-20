namespace REMAS.Forms.Purchasing
{
    partial class frmContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacts));
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearhCont = new System.Windows.Forms.Panel();
            this.btnSearchCont = new System.Windows.Forms.Button();
            this.txbSearchCont = new REMAS.Contoller.RJTextBox();
            this.lblPagesCont = new System.Windows.Forms.Label();
            this.btnLeftCont = new System.Windows.Forms.Button();
            this.btnRightCont = new System.Windows.Forms.Button();
            this.btnExcelCont = new System.Windows.Forms.Button();
            this.btnCreateCont = new System.Windows.Forms.Button();
            this.btnRepeatCont = new System.Windows.Forms.Button();
            this.btnPlusCont = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.pnlSearhCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContacts
            // 
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContacts.BackgroundColor = System.Drawing.Color.White;
            this.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref,
            this.Name,
            this.fixedPhone,
            this.mobilePhone,
            this.email,
            this.mainCompany,
            this.function});
            this.dgvContacts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvContacts.Location = new System.Drawing.Point(5, 71);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersWidth = 62;
            this.dgvContacts.RowTemplate.Height = 28;
            this.dgvContacts.Size = new System.Drawing.Size(1171, 415);
            this.dgvContacts.TabIndex = 13;
            // 
            // Ref
            // 
            this.Ref.HeaderText = "Reference";
            this.Ref.MinimumWidth = 8;
            this.Ref.Name = "Ref";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 8;
            this.Name.Name = "Name";
            // 
            // fixedPhone
            // 
            this.fixedPhone.HeaderText = "Fixed phone";
            this.fixedPhone.MinimumWidth = 8;
            this.fixedPhone.Name = "fixedPhone";
            // 
            // mobilePhone
            // 
            this.mobilePhone.HeaderText = "Mobile Phone";
            this.mobilePhone.MinimumWidth = 8;
            this.mobilePhone.Name = "mobilePhone";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            // 
            // mainCompany
            // 
            this.mainCompany.HeaderText = "Main Company";
            this.mainCompany.MinimumWidth = 8;
            this.mainCompany.Name = "mainCompany";
            // 
            // function
            // 
            this.function.HeaderText = "Function";
            this.function.MinimumWidth = 8;
            this.function.Name = "function";
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
            this.pnlSearhCont.Controls.Add(this.btnCreateCont);
            this.pnlSearhCont.Controls.Add(this.btnRepeatCont);
            this.pnlSearhCont.Controls.Add(this.btnPlusCont);
            this.pnlSearhCont.Location = new System.Drawing.Point(8, 12);
            this.pnlSearhCont.Name = "pnlSearhCont";
            this.pnlSearhCont.Size = new System.Drawing.Size(1171, 50);
            this.pnlSearhCont.TabIndex = 14;
            // 
            // btnSearchCont
            // 
            this.btnSearchCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCont.FlatAppearance.BorderSize = 0;
            this.btnSearchCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCont.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCont.Image")));
            this.btnSearchCont.Location = new System.Drawing.Point(328, 7);
            this.btnSearchCont.Name = "btnSearchCont";
            this.btnSearchCont.Size = new System.Drawing.Size(32, 33);
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
            this.txbSearchCont.Location = new System.Drawing.Point(0, 3);
            this.txbSearchCont.Margin = new System.Windows.Forms.Padding(6);
            this.txbSearchCont.MaxLength = 250;
            this.txbSearchCont.Multiline = false;
            this.txbSearchCont.Name = "txbSearchCont";
            this.txbSearchCont.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbSearchCont.PasswordChar = false;
            this.txbSearchCont.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearchCont.PlaceholderText = "Search";
            this.txbSearchCont.ReadOnly = false;
            this.txbSearchCont.Size = new System.Drawing.Size(357, 45);
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
            this.lblPagesCont.Location = new System.Drawing.Point(1015, 13);
            this.lblPagesCont.Name = "lblPagesCont";
            this.lblPagesCont.Size = new System.Drawing.Size(81, 21);
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
            this.btnLeftCont.Location = new System.Drawing.Point(1099, 7);
            this.btnLeftCont.Name = "btnLeftCont";
            this.btnLeftCont.Size = new System.Drawing.Size(32, 33);
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
            this.btnRightCont.Location = new System.Drawing.Point(1132, 7);
            this.btnRightCont.Name = "btnRightCont";
            this.btnRightCont.Size = new System.Drawing.Size(32, 33);
            this.btnRightCont.TabIndex = 30;
            this.btnRightCont.UseVisualStyleBackColor = true;
            // 
            // btnExcelCont
            // 
            this.btnExcelCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcelCont.FlatAppearance.BorderSize = 0;
            this.btnExcelCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelCont.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelCont.Image")));
            this.btnExcelCont.Location = new System.Drawing.Point(483, 7);
            this.btnExcelCont.Name = "btnExcelCont";
            this.btnExcelCont.Size = new System.Drawing.Size(32, 33);
            this.btnExcelCont.TabIndex = 29;
            this.btnExcelCont.UseVisualStyleBackColor = true;
            // 
            // btnCreateCont
            // 
            this.btnCreateCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateCont.FlatAppearance.BorderSize = 0;
            this.btnCreateCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCont.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateCont.Image")));
            this.btnCreateCont.Location = new System.Drawing.Point(407, 7);
            this.btnCreateCont.Name = "btnCreateCont";
            this.btnCreateCont.Size = new System.Drawing.Size(32, 33);
            this.btnCreateCont.TabIndex = 28;
            this.btnCreateCont.UseVisualStyleBackColor = true;
            // 
            // btnRepeatCont
            // 
            this.btnRepeatCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepeatCont.FlatAppearance.BorderSize = 0;
            this.btnRepeatCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeatCont.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeatCont.Image")));
            this.btnRepeatCont.Location = new System.Drawing.Point(445, 7);
            this.btnRepeatCont.Name = "btnRepeatCont";
            this.btnRepeatCont.Size = new System.Drawing.Size(32, 33);
            this.btnRepeatCont.TabIndex = 27;
            this.btnRepeatCont.UseVisualStyleBackColor = true;
            // 
            // btnPlusCont
            // 
            this.btnPlusCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlusCont.FlatAppearance.BorderSize = 0;
            this.btnPlusCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusCont.Image = ((System.Drawing.Image)(resources.GetObject("btnPlusCont.Image")));
            this.btnPlusCont.Location = new System.Drawing.Point(369, 7);
            this.btnPlusCont.Name = "btnPlusCont";
            this.btnPlusCont.Size = new System.Drawing.Size(32, 33);
            this.btnPlusCont.TabIndex = 26;
            this.btnPlusCont.UseVisualStyleBackColor = true;
            this.btnPlusCont.Click += new System.EventHandler(this.btnPlusCont_Click);
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlSearhCont);
            this.Controls.Add(this.dgvContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "frmContacts";
            this.Text = "frmContacts";
            this.Load += new System.EventHandler(this.frmContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.pnlSearhCont.ResumeLayout(false);
            this.pnlSearhCont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Panel pnlSearhCont;
        private System.Windows.Forms.Label lblPagesCont;
        private System.Windows.Forms.Button btnLeftCont;
        private System.Windows.Forms.Button btnRightCont;
        private System.Windows.Forms.Button btnExcelCont;
        private System.Windows.Forms.Button btnCreateCont;
        private System.Windows.Forms.Button btnRepeatCont;
        private System.Windows.Forms.Button btnPlusCont;
        private System.Windows.Forms.Button btnSearchCont;
        private Contoller.RJTextBox txbSearchCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn function;
    }
}