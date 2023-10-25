namespace REMAS.Forms.Purchasing
{
    partial class ucAddMaterial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1 = new REMAS.Contoller.CustomPanel();
            this.cmbType = new REMAS.Contoller.RJComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGroup = new REMAS.Contoller.RJComboBox();
            this.cmbCategory = new REMAS.Contoller.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterialName = new REMAS.Contoller.RJTextBox();
            this.customPanel2 = new REMAS.Contoller.CustomPanel();
            this.rjComboBox4 = new REMAS.Contoller.RJComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rjTextBox4 = new REMAS.Contoller.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rjTextBox3 = new REMAS.Contoller.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rjTextBox2 = new REMAS.Contoller.RJTextBox();
            this.cmb = new REMAS.Contoller.RJComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 37);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::REMAS.Properties.Resources.ArrowRepeat;
            this.button3.Location = new System.Drawing.Point(795, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 26);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::REMAS.Properties.Resources.XLg;
            this.button2.Location = new System.Drawing.Point(829, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 26);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::REMAS.Properties.Resources.Save;
            this.button1.Location = new System.Drawing.Point(761, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 26);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE NEW MATERIAL";
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customPanel1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.customPanel1.ColorTop = System.Drawing.Color.Empty;
            this.customPanel1.Controls.Add(this.cmbType);
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.Controls.Add(this.cmbGroup);
            this.customPanel1.Controls.Add(this.cmbCategory);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.txtMaterialName);
            this.customPanel1.Location = new System.Drawing.Point(15, 43);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 20;
            this.customPanel1.Size = new System.Drawing.Size(852, 118);
            this.customPanel1.TabIndex = 3;
            this.customPanel1.Thickness = 5F;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbType.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cmbType.BorderSize = 1;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbType.ForeColor = System.Drawing.Color.DimGray;
            this.cmbType.IconColor = System.Drawing.SystemColors.ControlDark;
            this.cmbType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbType.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbType.Location = new System.Drawing.Point(661, 42);
            this.cmbType.MinimumSize = new System.Drawing.Size(100, 31);
            this.cmbType.Name = "cmbType";
            this.cmbType.Padding = new System.Windows.Forms.Padding(1);
            this.cmbType.Size = new System.Drawing.Size(162, 31);
            this.cmbType.TabIndex = 48;
            this.cmbType.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Material Type";
            // 
            // cmbGroup
            // 
            this.cmbGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGroup.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cmbGroup.BorderSize = 1;
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbGroup.ForeColor = System.Drawing.Color.DimGray;
            this.cmbGroup.IconColor = System.Drawing.SystemColors.ControlDark;
            this.cmbGroup.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbGroup.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbGroup.Location = new System.Drawing.Point(448, 42);
            this.cmbGroup.MinimumSize = new System.Drawing.Size(100, 31);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Padding = new System.Windows.Forms.Padding(1);
            this.cmbGroup.Size = new System.Drawing.Size(162, 31);
            this.cmbGroup.TabIndex = 46;
            this.cmbGroup.Texts = "";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategory.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cmbCategory.BorderSize = 1;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCategory.IconColor = System.Drawing.SystemColors.ControlDark;
            this.cmbCategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCategory.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCategory.Location = new System.Drawing.Point(238, 42);
            this.cmbCategory.MinimumSize = new System.Drawing.Size(100, 31);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Padding = new System.Windows.Forms.Padding(1);
            this.cmbCategory.Size = new System.Drawing.Size(162, 31);
            this.cmbCategory.TabIndex = 45;
            this.cmbCategory.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Material Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Material Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Material Category";
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaterialName.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtMaterialName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaterialName.BorderRadius = 0;
            this.txtMaterialName.BorderSize = 2;
            this.txtMaterialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaterialName.Location = new System.Drawing.Point(27, 43);
            this.txtMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterialName.Multiline = false;
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaterialName.PasswordChar = false;
            this.txtMaterialName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaterialName.PlaceholderText = "Material Name";
            this.txtMaterialName.Size = new System.Drawing.Size(161, 31);
            this.txtMaterialName.TabIndex = 39;
            this.txtMaterialName.Texts = "";
            this.txtMaterialName.UnderlinedStyle = true;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customPanel2.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customPanel2.ColorBottom = System.Drawing.Color.Empty;
            this.customPanel2.ColorTop = System.Drawing.Color.Empty;
            this.customPanel2.Controls.Add(this.rjComboBox4);
            this.customPanel2.Controls.Add(this.label10);
            this.customPanel2.Controls.Add(this.label9);
            this.customPanel2.Controls.Add(this.rjTextBox4);
            this.customPanel2.Controls.Add(this.label8);
            this.customPanel2.Controls.Add(this.rjTextBox3);
            this.customPanel2.Controls.Add(this.label6);
            this.customPanel2.Controls.Add(this.rjTextBox2);
            this.customPanel2.Controls.Add(this.cmb);
            this.customPanel2.Controls.Add(this.label7);
            this.customPanel2.Location = new System.Drawing.Point(13, 179);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Radius = 20;
            this.customPanel2.Size = new System.Drawing.Size(852, 176);
            this.customPanel2.TabIndex = 50;
            this.customPanel2.Thickness = 5F;
            // 
            // rjComboBox4
            // 
            this.rjComboBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox4.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rjComboBox4.BorderSize = 1;
            this.rjComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox4.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox4.IconColor = System.Drawing.SystemColors.ControlDark;
            this.rjComboBox4.Items.AddRange(new object[] {
            "PCS",
            "KG"});
            this.rjComboBox4.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox4.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox4.Location = new System.Drawing.Point(238, 122);
            this.rjComboBox4.MinimumSize = new System.Drawing.Size(100, 31);
            this.rjComboBox4.Name = "rjComboBox4";
            this.rjComboBox4.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox4.Size = new System.Drawing.Size(162, 31);
            this.rjComboBox4.TabIndex = 56;
            this.rjComboBox4.Texts = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Unit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Minimum Stock";
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox4.BorderRadius = 0;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox4.Location = new System.Drawing.Point(27, 122);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.PlaceholderText = "Minimum Stock";
            this.rjTextBox4.Size = new System.Drawing.Size(161, 31);
            this.rjTextBox4.TabIndex = 53;
            this.rjTextBox4.Texts = "";
            this.rjTextBox4.UnderlinedStyle = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Standard Batch";
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderRadius = 0;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.Location = new System.Drawing.Point(448, 43);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "Standard Batch";
            this.rjTextBox3.Size = new System.Drawing.Size(161, 31);
            this.rjTextBox3.TabIndex = 51;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Standard Lot";
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(239, 43);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "Standard Lot";
            this.rjTextBox2.Size = new System.Drawing.Size(161, 31);
            this.rjTextBox2.TabIndex = 49;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = true;
            // 
            // cmb
            // 
            this.cmb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.cmb.BorderSize = 1;
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmb.ForeColor = System.Drawing.Color.DimGray;
            this.cmb.IconColor = System.Drawing.SystemColors.ControlDark;
            this.cmb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb.Location = new System.Drawing.Point(26, 43);
            this.cmb.MinimumSize = new System.Drawing.Size(100, 31);
            this.cmb.Name = "cmb";
            this.cmb.Padding = new System.Windows.Forms.Padding(1);
            this.cmb.Size = new System.Drawing.Size(162, 31);
            this.cmb.TabIndex = 50;
            this.cmb.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Material Status";
            // 
            // ucAddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ucAddMaterial";
            this.Size = new System.Drawing.Size(876, 372);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Contoller.CustomPanel customPanel1;
        private Contoller.RJComboBox cmbType;
        private System.Windows.Forms.Label label5;
        private Contoller.RJComboBox cmbGroup;
        private Contoller.RJComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Contoller.RJTextBox txtMaterialName;
        private Contoller.CustomPanel customPanel2;
        private Contoller.RJComboBox rjComboBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Contoller.RJTextBox rjTextBox4;
        private System.Windows.Forms.Label label8;
        private Contoller.RJTextBox rjTextBox3;
        private System.Windows.Forms.Label label6;
        private Contoller.RJTextBox rjTextBox2;
        private Contoller.RJComboBox cmb;
        private System.Windows.Forms.Label label7;
    }
}
