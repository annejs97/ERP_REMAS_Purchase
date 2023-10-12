namespace REMAS.Forms.Account
{
    partial class fmChangePassword
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmChangePassword));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.lbWarning = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtPasswordConfirm = new MetroFramework.Controls.MetroTextBox();
            this.txtPasswordNew = new MetroFramework.Controls.MetroTextBox();
            this.txtPasswordOld = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtUserCd = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lbHeader = new MetroFramework.Controls.MetroLabel();
            this.ellipseControl1 = new REMAS.Controller.EllipseControl();
            this.metroPanel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(274, 193);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.lbWarning);
            this.metroPanel4.Controls.Add(this.btnCancel);
            this.metroPanel4.Controls.Add(this.btnSave);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 157);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(274, 36);
            this.metroPanel4.TabIndex = 8;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // lbWarning
            // 
            this.lbWarning.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(5, 2);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(264, 33);
            this.lbWarning.TabIndex = 16;
            this.lbWarning.Text = "Password must be at least 8 character and contains one (digit - lowercase - upper" +
    "case - unique char)";
            this.lbWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbWarning.UseCustomBackColor = true;
            this.lbWarning.UseCustomForeColor = true;
            this.lbWarning.UseStyleColors = true;
            this.lbWarning.Visible = false;
            this.lbWarning.WrapToLine = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(197, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(124, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.txtPasswordConfirm);
            this.metroPanel2.Controls.Add(this.txtPasswordNew);
            this.metroPanel2.Controls.Add(this.txtPasswordOld);
            this.metroPanel2.Controls.Add(this.txtUserName);
            this.metroPanel2.Controls.Add(this.txtUserCd);
            this.metroPanel2.Controls.Add(this.button1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 29);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(274, 128);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtPasswordConfirm
            // 
            // 
            // 
            // 
            this.txtPasswordConfirm.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.txtPasswordConfirm.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPasswordConfirm.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPasswordConfirm.CustomButton.Image = null;
            this.txtPasswordConfirm.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtPasswordConfirm.CustomButton.Name = "";
            this.txtPasswordConfirm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordConfirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordConfirm.CustomButton.TabIndex = 1;
            this.txtPasswordConfirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordConfirm.CustomButton.UseSelectable = true;
            this.txtPasswordConfirm.Icon = ((System.Drawing.Image)(resources.GetObject("txtPasswordConfirm.Icon")));
            this.txtPasswordConfirm.Lines = new string[0];
            this.txtPasswordConfirm.Location = new System.Drawing.Point(5, 99);
            this.txtPasswordConfirm.MaxLength = 32767;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '\0';
            this.txtPasswordConfirm.PromptText = "Password Confirm";
            this.txtPasswordConfirm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordConfirm.SelectedText = "";
            this.txtPasswordConfirm.SelectionLength = 0;
            this.txtPasswordConfirm.SelectionStart = 0;
            this.txtPasswordConfirm.ShortcutsEnabled = true;
            this.txtPasswordConfirm.ShowButton = true;
            this.txtPasswordConfirm.Size = new System.Drawing.Size(264, 23);
            this.txtPasswordConfirm.TabIndex = 14;
            this.txtPasswordConfirm.UseCustomBackColor = true;
            this.txtPasswordConfirm.UseCustomForeColor = true;
            this.txtPasswordConfirm.UseSelectable = true;
            this.txtPasswordConfirm.UseStyleColors = true;
            this.txtPasswordConfirm.WaterMark = "Password Confirm";
            this.txtPasswordConfirm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordConfirm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasswordConfirm.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtPasswordConfirm_ButtonClick);
            this.txtPasswordConfirm.Leave += new System.EventHandler(this.txtPasswordConfirm_Leave);
            // 
            // txtPasswordNew
            // 
            // 
            // 
            // 
            this.txtPasswordNew.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.txtPasswordNew.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPasswordNew.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPasswordNew.CustomButton.Image = null;
            this.txtPasswordNew.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtPasswordNew.CustomButton.Name = "";
            this.txtPasswordNew.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordNew.CustomButton.TabIndex = 1;
            this.txtPasswordNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordNew.CustomButton.UseSelectable = true;
            this.txtPasswordNew.Icon = ((System.Drawing.Image)(resources.GetObject("txtPasswordNew.Icon")));
            this.txtPasswordNew.Lines = new string[0];
            this.txtPasswordNew.Location = new System.Drawing.Point(5, 75);
            this.txtPasswordNew.MaxLength = 32767;
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '\0';
            this.txtPasswordNew.PromptText = "Password New";
            this.txtPasswordNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordNew.SelectedText = "";
            this.txtPasswordNew.SelectionLength = 0;
            this.txtPasswordNew.SelectionStart = 0;
            this.txtPasswordNew.ShortcutsEnabled = true;
            this.txtPasswordNew.ShowButton = true;
            this.txtPasswordNew.Size = new System.Drawing.Size(264, 23);
            this.txtPasswordNew.TabIndex = 13;
            this.txtPasswordNew.UseCustomBackColor = true;
            this.txtPasswordNew.UseCustomForeColor = true;
            this.txtPasswordNew.UseSelectable = true;
            this.txtPasswordNew.UseStyleColors = true;
            this.txtPasswordNew.WaterMark = "Password New";
            this.txtPasswordNew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordNew.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasswordNew.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtPasswordNew_ButtonClick);
            // 
            // txtPasswordOld
            // 
            // 
            // 
            // 
            this.txtPasswordOld.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage2")));
            this.txtPasswordOld.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPasswordOld.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPasswordOld.CustomButton.Image = null;
            this.txtPasswordOld.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtPasswordOld.CustomButton.Name = "";
            this.txtPasswordOld.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordOld.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordOld.CustomButton.TabIndex = 1;
            this.txtPasswordOld.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordOld.CustomButton.UseSelectable = true;
            this.txtPasswordOld.Icon = ((System.Drawing.Image)(resources.GetObject("txtPasswordOld.Icon")));
            this.txtPasswordOld.Lines = new string[0];
            this.txtPasswordOld.Location = new System.Drawing.Point(5, 51);
            this.txtPasswordOld.MaxLength = 32767;
            this.txtPasswordOld.Name = "txtPasswordOld";
            this.txtPasswordOld.PasswordChar = '\0';
            this.txtPasswordOld.PromptText = "Password Recently";
            this.txtPasswordOld.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordOld.SelectedText = "";
            this.txtPasswordOld.SelectionLength = 0;
            this.txtPasswordOld.SelectionStart = 0;
            this.txtPasswordOld.ShortcutsEnabled = true;
            this.txtPasswordOld.ShowButton = true;
            this.txtPasswordOld.Size = new System.Drawing.Size(264, 23);
            this.txtPasswordOld.TabIndex = 12;
            this.txtPasswordOld.UseCustomBackColor = true;
            this.txtPasswordOld.UseCustomForeColor = true;
            this.txtPasswordOld.UseSelectable = true;
            this.txtPasswordOld.UseStyleColors = true;
            this.txtPasswordOld.WaterMark = "Password Recently";
            this.txtPasswordOld.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordOld.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasswordOld.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtPasswordOld_ButtonClick);
            this.txtPasswordOld.Leave += new System.EventHandler(this.txtPasswordOld_Leave);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Icon = ((System.Drawing.Image)(resources.GetObject("txtUserName.Icon")));
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(5, 27);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ReadOnly = true;
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(264, 23);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.UseCustomBackColor = true;
            this.txtUserName.UseCustomForeColor = true;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.UseStyleColors = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserCd
            // 
            // 
            // 
            // 
            this.txtUserCd.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUserCd.CustomButton.Image = null;
            this.txtUserCd.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtUserCd.CustomButton.Name = "";
            this.txtUserCd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserCd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserCd.CustomButton.TabIndex = 1;
            this.txtUserCd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserCd.CustomButton.UseSelectable = true;
            this.txtUserCd.CustomButton.Visible = false;
            this.txtUserCd.Icon = ((System.Drawing.Image)(resources.GetObject("txtUserCd.Icon")));
            this.txtUserCd.Lines = new string[0];
            this.txtUserCd.Location = new System.Drawing.Point(5, 3);
            this.txtUserCd.MaxLength = 32767;
            this.txtUserCd.Name = "txtUserCd";
            this.txtUserCd.PasswordChar = '\0';
            this.txtUserCd.ReadOnly = true;
            this.txtUserCd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserCd.SelectedText = "";
            this.txtUserCd.SelectionLength = 0;
            this.txtUserCd.SelectionStart = 0;
            this.txtUserCd.ShortcutsEnabled = true;
            this.txtUserCd.Size = new System.Drawing.Size(264, 23);
            this.txtUserCd.TabIndex = 10;
            this.txtUserCd.UseCustomBackColor = true;
            this.txtUserCd.UseCustomForeColor = true;
            this.txtUserCd.UseSelectable = true;
            this.txtUserCd.UseStyleColors = true;
            this.txtUserCd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserCd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(239, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.lbHeader);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(274, 29);
            this.metroPanel3.TabIndex = 7;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbHeader.Location = new System.Drawing.Point(7, 6);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(10, 15);
            this.lbHeader.TabIndex = 2;
            this.lbHeader.Text = ":";
            this.lbHeader.UseCustomBackColor = true;
            this.lbHeader.UseCustomForeColor = true;
            this.lbHeader.UseStyleColors = true;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 15;
            this.ellipseControl1.TargetControl = this;
            // 
            // fmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 243);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmChangePassword";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Load += new System.EventHandler(this.fmChangePassword_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private Controller.EllipseControl ellipseControl1;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtUserCd;
        private MetroFramework.Controls.MetroTextBox txtPasswordOld;
        private MetroFramework.Controls.MetroTextBox txtPasswordConfirm;
        private MetroFramework.Controls.MetroTextBox txtPasswordNew;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel lbHeader;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel lbWarning;
    }
}