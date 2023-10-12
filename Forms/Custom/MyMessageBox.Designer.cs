namespace REMAS.Forms.Custom
{
    partial class MyMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessageBox));
            this.lbHeader = new MetroFramework.Controls.MetroLabel();
            this.btnYes = new MetroFramework.Controls.MetroButton();
            this.btnNo = new MetroFramework.Controls.MetroButton();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMessage = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbHeader.Location = new System.Drawing.Point(4, 7);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(10, 15);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = ":";
            this.lbHeader.UseCustomBackColor = true;
            this.lbHeader.UseCustomForeColor = true;
            this.lbHeader.UseStyleColors = true;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnYes.Highlight = true;
            this.btnYes.Location = new System.Drawing.Point(99, 105);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(72, 23);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.UseCustomBackColor = true;
            this.btnYes.UseSelectable = true;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNo.Highlight = true;
            this.btnNo.Location = new System.Drawing.Point(173, 105);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(72, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseCustomBackColor = true;
            this.btnNo.UseSelectable = true;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOk.Highlight = true;
            this.btnOk.Location = new System.Drawing.Point(173, 105);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(72, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseCustomBackColor = true;
            this.btnOk.UseSelectable = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbMessage);
            this.panel1.Location = new System.Drawing.Point(13, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 66);
            this.panel1.TabIndex = 5;
            // 
            // lbMessage
            // 
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbMessage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbMessage.Location = new System.Drawing.Point(0, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(238, 66);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "Message Text";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbMessage.UseCustomBackColor = true;
            this.lbMessage.UseCustomForeColor = true;
            this.lbMessage.UseStyleColors = true;
            this.lbMessage.WrapToLine = true;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 145);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lbHeader);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "MyMessageBox";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbHeader;
        private MetroFramework.Controls.MetroButton btnYes;
        private MetroFramework.Controls.MetroButton btnNo;
        private MetroFramework.Controls.MetroButton btnOk;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbMessage;
    }
}