namespace REMAS.Forms.Purchasing
{
    partial class frmPopupSupl
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
            this.sptrSettingsuctInf = new REMAS.Contoller.Separators();
            this.sptrBawah = new REMAS.Contoller.Separators();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTengah = new System.Windows.Forms.Panel();
            this.sptrArrivalProduct = new REMAS.Contoller.Separators();
            this.nudArrivalProduct = new System.Windows.Forms.NumericUpDown();
            this.lblArrivalProduct = new System.Windows.Forms.Label();
            this.lblQualityRating = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txbQualityRating = new REMAS.Contoller.RJTextBox();
            this.txbSearch = new REMAS.Contoller.RJTextBox();
            this.lblPartnerProduct = new System.Windows.Forms.Label();
            this.pnlTengah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // sptrSettingsuctInf
            // 
            this.sptrSettingsuctInf.BackColor = System.Drawing.Color.White;
            this.sptrSettingsuctInf.ForeColor = System.Drawing.Color.Silver;
            this.sptrSettingsuctInf.isVertical = false;
            this.sptrSettingsuctInf.Location = new System.Drawing.Point(-2, 34);
            this.sptrSettingsuctInf.Name = "sptrSettingsuctInf";
            this.sptrSettingsuctInf.Size = new System.Drawing.Size(1004, 23);
            this.sptrSettingsuctInf.TabIndex = 242;
            this.sptrSettingsuctInf.Thickness = 1;
            // 
            // sptrBawah
            // 
            this.sptrBawah.BackColor = System.Drawing.Color.White;
            this.sptrBawah.ForeColor = System.Drawing.Color.Silver;
            this.sptrBawah.isVertical = false;
            this.sptrBawah.Location = new System.Drawing.Point(-2, 225);
            this.sptrBawah.Name = "sptrBawah";
            this.sptrBawah.Size = new System.Drawing.Size(1004, 23);
            this.sptrBawah.TabIndex = 243;
            this.sptrBawah.Thickness = 1;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(880, 242);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 35);
            this.btnOK.TabIndex = 264;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(808, 242);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 35);
            this.btnClose.TabIndex = 265;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTengah
            // 
            this.pnlTengah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTengah.Controls.Add(this.sptrArrivalProduct);
            this.pnlTengah.Controls.Add(this.nudArrivalProduct);
            this.pnlTengah.Controls.Add(this.lblArrivalProduct);
            this.pnlTengah.Controls.Add(this.lblQualityRating);
            this.pnlTengah.Controls.Add(this.lblProduct);
            this.pnlTengah.Controls.Add(this.txbQualityRating);
            this.pnlTengah.Controls.Add(this.txbSearch);
            this.pnlTengah.Location = new System.Drawing.Point(24, 55);
            this.pnlTengah.Name = "pnlTengah";
            this.pnlTengah.Size = new System.Drawing.Size(948, 164);
            this.pnlTengah.TabIndex = 266;
            // 
            // sptrArrivalProduct
            // 
            this.sptrArrivalProduct.BackColor = System.Drawing.Color.White;
            this.sptrArrivalProduct.isVertical = false;
            this.sptrArrivalProduct.Location = new System.Drawing.Point(604, 63);
            this.sptrArrivalProduct.Name = "sptrArrivalProduct";
            this.sptrArrivalProduct.Size = new System.Drawing.Size(316, 23);
            this.sptrArrivalProduct.TabIndex = 285;
            this.sptrArrivalProduct.Thickness = 1;
            // 
            // nudArrivalProduct
            // 
            this.nudArrivalProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudArrivalProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudArrivalProduct.Location = new System.Drawing.Point(604, 42);
            this.nudArrivalProduct.Name = "nudArrivalProduct";
            this.nudArrivalProduct.Size = new System.Drawing.Size(316, 22);
            this.nudArrivalProduct.TabIndex = 284;
            this.nudArrivalProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblArrivalProduct
            // 
            this.lblArrivalProduct.AutoSize = true;
            this.lblArrivalProduct.BackColor = System.Drawing.Color.White;
            this.lblArrivalProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalProduct.Location = new System.Drawing.Point(600, 14);
            this.lblArrivalProduct.Name = "lblArrivalProduct";
            this.lblArrivalProduct.Size = new System.Drawing.Size(175, 21);
            this.lblArrivalProduct.TabIndex = 283;
            this.lblArrivalProduct.Text = "Arrival product quantity";
            // 
            // lblQualityRating
            // 
            this.lblQualityRating.AutoSize = true;
            this.lblQualityRating.BackColor = System.Drawing.Color.White;
            this.lblQualityRating.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualityRating.Location = new System.Drawing.Point(292, 14);
            this.lblQualityRating.Name = "lblQualityRating";
            this.lblQualityRating.Size = new System.Drawing.Size(105, 21);
            this.lblQualityRating.TabIndex = 281;
            this.lblQualityRating.Text = "Quality rating";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.White;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(14, 14);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(64, 21);
            this.lblProduct.TabIndex = 280;
            this.lblProduct.Text = "Product";
            // 
            // txbQualityRating
            // 
            this.txbQualityRating.BackColor = System.Drawing.SystemColors.Window;
            this.txbQualityRating.BorderColor = System.Drawing.Color.Black;
            this.txbQualityRating.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbQualityRating.BorderRadius = 0;
            this.txbQualityRating.BorderSize = 1;
            this.txbQualityRating.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbQualityRating.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbQualityRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQualityRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbQualityRating.Location = new System.Drawing.Point(296, 31);
            this.txbQualityRating.Margin = new System.Windows.Forms.Padding(6);
            this.txbQualityRating.MaxLength = 250;
            this.txbQualityRating.Multiline = false;
            this.txbQualityRating.Name = "txbQualityRating";
            this.txbQualityRating.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbQualityRating.PasswordChar = false;
            this.txbQualityRating.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbQualityRating.PlaceholderText = "";
            this.txbQualityRating.ReadOnly = false;
            this.txbQualityRating.Size = new System.Drawing.Size(276, 44);
            this.txbQualityRating.TabIndex = 279;
            this.txbQualityRating.Texts = "";
            this.txbQualityRating.UnderlinedStyle = true;
            // 
            // txbSearch
            // 
            this.txbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txbSearch.BorderColor = System.Drawing.Color.Black;
            this.txbSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txbSearch.BorderRadius = 0;
            this.txbSearch.BorderSize = 1;
            this.txbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.Location = new System.Drawing.Point(15, 31);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txbSearch.MaxLength = 250;
            this.txbSearch.Multiline = false;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Padding = new System.Windows.Forms.Padding(2, 11, 2, 8);
            this.txbSearch.PasswordChar = false;
            this.txbSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSearch.PlaceholderText = "Search";
            this.txbSearch.ReadOnly = false;
            this.txbSearch.Size = new System.Drawing.Size(254, 44);
            this.txbSearch.TabIndex = 278;
            this.txbSearch.Texts = "";
            this.txbSearch.UnderlinedStyle = true;
            // 
            // lblPartnerProduct
            // 
            this.lblPartnerProduct.AutoSize = true;
            this.lblPartnerProduct.BackColor = System.Drawing.Color.White;
            this.lblPartnerProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartnerProduct.Location = new System.Drawing.Point(20, 9);
            this.lblPartnerProduct.Name = "lblPartnerProduct";
            this.lblPartnerProduct.Size = new System.Drawing.Size(238, 21);
            this.lblPartnerProduct.TabIndex = 267;
            this.lblPartnerProduct.Text = "Partner product quality rating";
            // 
            // frmPopupSupl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 277);
            this.Controls.Add(this.lblPartnerProduct);
            this.Controls.Add(this.pnlTengah);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.sptrBawah);
            this.Controls.Add(this.sptrSettingsuctInf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPopupSupl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPopupSupl";
            this.TopMost = true;
            this.pnlTengah.ResumeLayout(false);
            this.pnlTengah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArrivalProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Contoller.Separators sptrSettingsuctInf;
        private Contoller.Separators sptrBawah;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlTengah;
        private System.Windows.Forms.Label lblPartnerProduct;
        private Contoller.RJTextBox txbQualityRating;
        private Contoller.RJTextBox txbSearch;
        private System.Windows.Forms.Label lblQualityRating;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblArrivalProduct;
        private System.Windows.Forms.NumericUpDown nudArrivalProduct;
        private Contoller.Separators sptrArrivalProduct;
    }
}