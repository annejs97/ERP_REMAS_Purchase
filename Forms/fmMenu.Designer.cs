namespace REMAS.Forms
{
    partial class fmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbB = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbA = new System.Windows.Forms.Label();
            this.lbAA = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbIndex = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.pnUserControl = new REMAS.Contoller.CustomPanel();
            this.btnExit = new REMAS.Contoller.CircularButton();
            this.btnChangePass = new REMAS.Contoller.CircularButton();
            this.pbUser = new REMAS.Contoller.CircularPictureBox();
            this.MenuItem = new REMAS.Contoller.NavBar.csNavBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.lbB);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 27);
            this.panel1.TabIndex = 0;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.BackColor = System.Drawing.Color.Transparent;
            this.lbB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbB.Font = new System.Drawing.Font("Dubai", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbB.Location = new System.Drawing.Point(0, 0);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(48, 30);
            this.lbB.TabIndex = 7;
            this.lbB.Text = "HTA";
            this.lbB.Visible = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Honeydew;
            this.btnMinimize.Location = new System.Drawing.Point(1328, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 27);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Honeydew;
            this.btnClose.Location = new System.Drawing.Point(1376, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 27);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::REMAS.Properties.Resources.IconList;
            this.menuButton.Location = new System.Drawing.Point(3, 5);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(20, 20);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 2;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbUser);
            this.panel2.Controls.Add(this.pbUser);
            this.panel2.Controls.Add(this.menuButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(222, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 30);
            this.panel2.TabIndex = 3;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.lbUser.Location = new System.Drawing.Point(879, 4);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(270, 24);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "Adi Ilham";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebarPanel.BackgroundImage")));
            this.sidebarPanel.Controls.Add(this.MenuItem);
            this.sidebarPanel.Controls.Add(this.panel5);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 27);
            this.sidebarPanel.MaximumSize = new System.Drawing.Size(222, 0);
            this.sidebarPanel.MinimumSize = new System.Drawing.Size(37, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(222, 873);
            this.sidebarPanel.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lbA);
            this.panel5.Controls.Add(this.lbAA);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 46);
            this.panel5.TabIndex = 0;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.BackColor = System.Drawing.Color.Transparent;
            this.lbA.Font = new System.Drawing.Font("Dubai", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbA.Location = new System.Drawing.Point(3, 4);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(62, 39);
            this.lbA.TabIndex = 9;
            this.lbA.Text = "HTA";
            // 
            // lbAA
            // 
            this.lbAA.AutoSize = true;
            this.lbAA.BackColor = System.Drawing.Color.Transparent;
            this.lbAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAA.Location = new System.Drawing.Point(71, 6);
            this.lbAA.Name = "lbAA";
            this.lbAA.Size = new System.Drawing.Size(124, 30);
            this.lbAA.TabIndex = 8;
            this.lbAA.Text = "Rubber Seal\r\nManagement System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbIndex);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(222, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 22);
            this.panel3.TabIndex = 11;
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.BackColor = System.Drawing.Color.Transparent;
            this.lbIndex.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbIndex.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex.ForeColor = System.Drawing.Color.Gray;
            this.lbIndex.Location = new System.Drawing.Point(0, 0);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(44, 24);
            this.lbIndex.TabIndex = 8;
            this.lbIndex.Text = "Index";
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.Honeydew;
            this.btnMaximize.Location = new System.Drawing.Point(1352, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 27);
            this.btnMaximize.TabIndex = 15;
            this.btnMaximize.Text = "☐";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pnUserControl
            // 
            this.pnUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnUserControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnUserControl.ColorBottom = System.Drawing.Color.Empty;
            this.pnUserControl.ColorTop = System.Drawing.Color.Empty;
            this.pnUserControl.Controls.Add(this.btnExit);
            this.pnUserControl.Controls.Add(this.btnChangePass);
            this.pnUserControl.Location = new System.Drawing.Point(1273, 57);
            this.pnUserControl.Name = "pnUserControl";
            this.pnUserControl.Radius = 20;
            this.pnUserControl.Size = new System.Drawing.Size(125, 56);
            this.pnUserControl.TabIndex = 7;
            this.pnUserControl.Thickness = 0F;
            this.pnUserControl.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 27;
            this.btnExit.BorderSize = 0;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 27);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "●   Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePass.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnChangePass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangePass.BorderRadius = 27;
            this.btnChangePass.BorderSize = 0;
            this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(0, 0);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(125, 27);
            this.btnChangePass.TabIndex = 0;
            this.btnChangePass.Text = "●   Change Password";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.TextColor = System.Drawing.Color.White;
            this.btnChangePass.UseVisualStyleBackColor = false;
            // 
            // pbUser
            // 
            this.pbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUser.Image = global::REMAS.Properties.Resources.user_50;
            this.pbUser.Location = new System.Drawing.Point(1152, 5);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(22, 22);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            // 
            // MenuItem
            // 
            this.MenuItem.AutoScroll = true;
            this.MenuItem.BackColor = System.Drawing.Color.Transparent;
            this.MenuItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuItem.Location = new System.Drawing.Point(0, 46);
            this.MenuItem.MaximumSize = new System.Drawing.Size(222, 0);
            this.MenuItem.MinimumSize = new System.Drawing.Size(37, 0);
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(222, 827);
            this.MenuItem.TabIndex = 1;
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.pnUserControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "fmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.sidebarPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnUserControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer sidebarTimer;
        private Contoller.CircularPictureBox pbUser;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbUser;
        private Contoller.CustomPanel pnUserControl;
        private Contoller.CircularButton btnExit;
        private Contoller.CircularButton btnChangePass;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbAA;
        private Contoller.NavBar.csNavBar MenuItem;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.Button btnMaximize;
    }
}