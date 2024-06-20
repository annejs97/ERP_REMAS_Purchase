namespace REMAS.Forms.Custom
{
    partial class myMsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myMsgBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.ellipseControl1 = new REMAS.Controller.EllipseControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 22);
            this.panel1.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(5, 5);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(11, 13);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = ":";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.lbMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 96);
            this.panel2.TabIndex = 1;
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Black;
            this.lbMessage.Location = new System.Drawing.Point(0, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(272, 96);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Message Text";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel3.Controls.Add(this.btnOk);
            this.panel3.Controls.Add(this.btnNo);
            this.panel3.Controls.Add(this.btnYes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 36);
            this.panel3.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnOk.Location = new System.Drawing.Point(189, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.White;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnNo.Location = new System.Drawing.Point(189, 6);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.White;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnYes.Location = new System.Drawing.Point(115, 6);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // myMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(272, 154);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(288, 170);
            this.MinimumSize = new System.Drawing.Size(283, 165);
            this.Name = "myMsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private Controller.EllipseControl ellipseControl1;
    }
}