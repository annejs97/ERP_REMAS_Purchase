namespace REMAS.Forms.Accounting
{
    partial class uctPaymentSchedule_s_Rejected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctPaymentSchedule_s_Rejected));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ProgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnPlus);
            this.panel2.Location = new System.Drawing.Point(17, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 120);
            this.panel2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(741, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "New";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(676, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Select";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.Location = new System.Drawing.Point(720, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 23);
            this.btnPlus.TabIndex = 22;
            this.btnPlus.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(653, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Payment schedule(s) rejected";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgName,
            this.MenuName,
            this.Column1});
            this.dgvList.Location = new System.Drawing.Point(12, 36);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(764, 67);
            this.dgvList.TabIndex = 22;
            // 
            // ProgName
            // 
            this.ProgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProgName.HeaderText = "";
            this.ProgName.Name = "ProgName";
            // 
            // MenuName
            // 
            this.MenuName.FillWeight = 150F;
            this.MenuName.HeaderText = "Payment Schedule";
            this.MenuName.Name = "MenuName";
            this.MenuName.Width = 350;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Schedule line N°";
            this.Column1.Name = "Column1";
            this.Column1.Width = 325;
            // 
            // uctPaymentSchedule_s_Rejected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "uctPaymentSchedule_s_Rejected";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.uctPaymentSchedule_s_Rejected_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
